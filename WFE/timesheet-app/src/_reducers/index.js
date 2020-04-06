import { combineReducers } from 'redux';

import { alert } from './alert.reducer';
import { authenticate } from './authenticate.reducer';
import { employees } from './employees.reducer';
import { registration } from './registration.reducer';

const rootReducer = combineReducers({
    authenticate,
    registration,
    employees,
    alert
});

export default rootReducer;