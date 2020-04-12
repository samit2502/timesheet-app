import React from 'react';
import { connect } from 'react-redux';

import { employeeActions } from '../_actions';
import { NavBar } from '../NavBar';
import { EmployeeTable } from './EmployeeTable';

class LandingPage extends React.Component {

    // componentDidMount() {
    //     this.props.dispatch(employeeActions.getAll());
    // }

    render() {
        const {employee} = this.props;
        return (
            <div>
                <NavBar FullName={employee.employee.fullName} />
                <br /><br />
                <div>
                     <EmployeeTable />
                </div>
            </div>
        );
    }
}

function mapPropsToState(state) {
    return {
        // employees: state.employees,
        employee: state.authenticate 
    };
}

const LandingPageConnected = connect(mapPropsToState)(LandingPage);
export { LandingPageConnected as LandingPage };