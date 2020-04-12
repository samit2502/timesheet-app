import React from 'react';
import { connect } from 'react-redux';

import { employeeActions } from '../_actions';
import './EmployeeTable.css';
import '../_fonts/font-awesome-4.7.0/css/font-awesome.min.css';

class EmployeeTable extends React.Component {

    constructor(props) {
        super(props);

        this.renderTableData = this.renderTableData.bind(this);
    }

    componentDidMount() {
        this.props.dispatch(employeeActions.getAll());
    }

    renderTableData(employees) {
        return employees.items.map((employee, index) => {
           return (
              <tr key={employee.id}>
                <td>{index + 1}</td>
                <td>{employee.fullName}</td>
                <td>{employee.designation}</td>
                <td>{employee.userName}</td>
                <td>{employee.project}</td>
                <td>{employee.isManager}</td>
                <td>
                    <button type='button' className='btn btn-primary fa fa-edit'>&nbsp;&nbsp;Edit</button>
                    &nbsp;&nbsp;
                    <button type='button' className='btn btn-danger fa fa-trash'>&nbsp;&nbsp;Delete</button>
                </td>
              </tr>
           )
        })
     }

    render() {
        const { employees } = this.props;
        return(
            <div>
                <br />
                <input type="text" id="myInput" placeholder="Search for usernames..." />

                <table id="myTable">
                    <thead>
                        <tr className="header">
                            <th>#</th>
                            <th>Full Name</th>
                            <th>Designation</th>
                            <th>Username</th>
                            <th>Project</th>
                            <th>IsManager?</th>
                            <th>Actions</th>
                        </tr>
                    </thead>

                    {/* <tbody> */}
                    {/* { employees.loading && <em>Loading employees...</em> }
                    { employees.error && <span className='text-danger'>ERROR: {employees.error}</span> } */}
                    {/* { employees.items && 
                        <ul>
                            { employees.items.map((employee, index) => 
                                <tr key={index + 1}>
                                    <td>{index + 1}</td>
                                    <td>{employee.fullName}</td>
                                    <td>{employee.designation}</td>
                                    <td>{employee.userName}</td>
                                    <td>{employee.project}</td>
                                    <td>{employee.isManager}</td>
                                    <td>
                                        <button type='button' className='btn btn-primary'>Edit</button>
                                        
                                        <button type='button' className='btn btn-danger'>Delete</button>
                                    </td>
                                </tr>
                            )}
                        </ul>
                    }
                    </tbody> */}
                    {employees.items &&
                    <tbody>
                        {this.renderTableData(employees)}
                    </tbody>
                    }
                </table>
            </div>
        );
    }
}

function mapPropsToState(state) {
    return {
        employees: state.employees
    };
}

const connectedEmployeeTable = connect(mapPropsToState)(EmployeeTable);
export { connectedEmployeeTable as EmployeeTable };