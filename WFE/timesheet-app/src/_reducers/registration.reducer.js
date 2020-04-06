import { employeeConstants } from '../_constants';

export function registration(state = {}, action) {
    switch(action.type) {
        case employeeConstants.REGISTER_REQUEST:
            return { registering: true };
        case employeeConstants.REGISTER_SUCCESS:
            return {};
        case employeeConstants.REGISTER_FAILURE:
            return {};
        default:
            return state
    }
}