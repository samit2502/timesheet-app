import { alertActions } from './';
import { employeeConstants } from '../_constants';
import { history } from '../_helpers';
import { employeeService } from '../_services';

export const employeeActions = {
    login,
    logout,
    register,
    getAll
};

function login(username, password) {
    return dispatch => {
        dispatch(request({ username }));

        employeeService.login(username, password)
            .then(
                employee => {
                    dispatch(success(employee));
                    history.push('/landingPage');
                },
                error => {
                    dispatch(failure(error));
                    dispatch(alertActions.error(error));
                }
            );
    };

    function request(employee) { return { type: employeeConstants.LOGIN_REQUEST, employee } }
    function success(employee) { return { type: employeeConstants.LOGIN_SUCCESS, employee } }
    function failure(error) { return { type: employeeConstants.LOGIN_FAILURE, error } }
}

function logout() {
    employeeService.logout();
    return { type: employeeConstants.LOGOUT };
}

function register(employee) {
    return dispatch => {
        dispatch(request(employee));

        employeeService.register(employee)
            .then(
                () => {
                    dispatch(success());
                    history.push('/login');
                    dispatch(alertActions.success('Registration is successful'));
                },
                error => {
                    dispatch(failure(error));
                    dispatch(alertActions.error(error));
                }
        );
    };

    function request(employee) { return { type: employeeConstants.REGISTER_REQUEST, employee } }
    function success(employee) { return { type: employeeConstants.REGISTER_SUCCESS, employee } }
    function failure(error) { return { type: employeeConstants.REGISTER_FAILURE, error } }
}

function getAll() {
    return dispatch => {
        dispatch(request());

        employeeService.getAll()
            .then(
                employees => dispatch(success(employees)),
                error => dispatch(failure(error))
            );
    };

    function request() {return { type: employeeConstants.GETALL_REQUEST } }
    function success(employees) {return { type: employeeConstants.GETALL_SUCCESS, employees } }
    function failure(error) {return { type: employeeConstants.GETALL_FAILURE, error } }
}