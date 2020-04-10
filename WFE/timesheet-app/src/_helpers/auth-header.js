export function authHeader(){
    //return authorization header with jwt token
    let employee = JSON.parse(localStorage.getItem('employee'));

    if(employee && employee.token) {
        return { 'Authorization': 'Bearer ' + employee.token };
    }
    else {
        return {};
    }
}