import { authHeader, config } from '../_helpers'

export const employeeService = {
    register,
    login,
    getAll,
    getById,
    // update,
    // delete: _delete,
    logout
};

function login (userName, password) {
    const requestOptions = {
        method: 'POST',
        headers: { 'Content-type': 'application/json' },
        body: JSON.stringify({ userName, password })
    };

    return fetch(config.apiUrl + '/api/account/login', requestOptions)
    .then(handleResponse, handleError)
    .then(employee => {
        if(employee && employee.token) {
            localStorage.setItem('employee', JSON.stringify(employee));
        }
        return employee;
    });
}

function logout() {
    localStorage.removeItem('employee');
}

function getAll() {
    const requestOptions = {
        method: 'GET',
        headers: authHeader()
    };

    return fetch(config.apiUrl + '/employee', requestOptions).then(handleResponse, handleError);
}

function getById(id) {
    const requestOptions = {
        method: 'GET',
        headers: authHeader()
    };

    return fetch(config.apiUrl + '/employees/' + id, requestOptions).then(handleResponse, handleError);
}

function register(employee) {
    const requestOptions = {
        method: 'POST',
        headers: { 'Content-type': 'application/json' },
        body: JSON.stringify(employee)
    };

    return fetch(config.apiUrl + 'api/account/register', requestOptions).then(handleResponse, handleError);
}

function handleResponse(response) {
    return new Promise((resolve, reject) => {
        if(response.ok) {
            var contentType = response.headers.get("content-type");
            if(contentType && contentType.includes("application/json")){
                response.json().then(json => resolve(json));
            }
            else {
                resolve();
            }
        }
        else {
            response.text().then(text => reject(text));
        }
    });
}

function handleError(error) {
    return Promise.reject(error && error.message);
}