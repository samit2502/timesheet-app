import React from 'react';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';

import { employeeActions } from '../_actions';
import { NavBar } from '../NavBar';
import { EmployeeTable } from './EmployeeTable';

class LandingPage extends React.Component {

    componentDidMount() {
        this.props.dispatch(employeeActions.getAll());
    }

    render() {
        const {employee, employees} = this.props;
        return (
            <div>
                <NavBar />
                <br /><br />
                {/* <div className='col-md-6 col-md-offset-3'> */}
                <div>
                    {/* <h3>All Registered Users:</h3>
                    { employees.loading && <em>Loading employees...</em> }
                    { employees.error && <span className='text-danger'>ERROR: {employees.error}</span> }
                    { employees.items &&
                        <ul>
                            {employees.items.map((employee, index) =>
                                <li key={employee.id}>
                                    {employee.fullName}
                                </li>
                            )}
                        </ul>
                    } */}
                    {/* <p>
                        <Link to='/login'>Logout</Link>
                    </p> */}
                    <EmployeeTable />
                </div>
            </div>
        );
    }
}

function mapPropsToState(state) {
    return {
        employees: state.employees,
        employee: state.authenticate 
    };
}

const LandingPageConnected = connect(mapPropsToState)(LandingPage);
export { LandingPageConnected as LandingPage };