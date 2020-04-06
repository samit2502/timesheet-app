import { employeeConstants } from '../_constants';

let employee = JSON.parse(localStorage.getItem('employee'));
const initialState = employee ? { loggedIn: true, employee } : {};

export function authenticate(state = initialState, action) {
    switch(action.type) {
        case employeeConstants.LOGIN_REQUEST:
            return {
                loggingIn: true,
                employee: action.employee
            };
        case employeeConstants.LOGIN_SUCCESS:
            return {
                loggedIn: true,
                employee: action.employee
            };
        case employeeConstants.LOGIN_FAILURE:
            return {};
        case employeeConstants.LOGOUT:
            return {};
        default:
            return state
    }
}