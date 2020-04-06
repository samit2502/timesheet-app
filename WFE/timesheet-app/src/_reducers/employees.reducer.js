import { employeeConstants } from '../_constants';

export function employees(state = {}, action) {
    switch(action.type) {
        case employeeConstants.GETALL_REQUEST:
            return {
                loading: true
            };
        case employeeConstants.GETALL_SUCCESS:
            return {
                items: action.employees
            };
        case employeeConstants.GETALL_FAILURE:
            return {
                error: action.error
            };
        case employeeConstants.DELETE_REQUEST:
            return {
                ...state,
                items: state.items.map(employee =>
                        employee.id === action.id
                        ? (...employee, deleting: true)
                        : employee
                    )
            };
        case employeeConstants.DELETE_SUCCESS:
            return {
                items: state.items.filter(employee => employee.Id !== action.Id)
            };
        default:
            return state
    }
}