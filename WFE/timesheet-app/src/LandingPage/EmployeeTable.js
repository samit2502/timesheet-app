import React from 'react';
import { connect } from 'react-redux';

import './EmployeeTable.css';

class EmployeeTable extends React.Component {
    constructor(props){
        super(props);
    }

    render() {
        return(
            <div>
                <input type="text" id="myInput" placeholder="Search for usernames..." />

                <table id="myTable">
                    <tr className="header">
                        <th style={{"width": "10%"}}>#</th>
                        <th style={{"width": "30%"}}>Full Name</th>
                        <th style={{"width": "10%"}}>Designation</th>
                        <th style={{"width": "10%"}}>Username</th>
                        <th style={{"width": "20%"}}>Project</th>
                        <th style={{"width": "5%"}}>IsManager?</th>
                        <th style={{"width": "20%"}}>Actions</th>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>Samitanjaya Mishra</td>
                        <td>Associate Senior Software Engineer</td>
                        <td>SM07296090</td>
                        <td>Outpatient Pharmacy</td>
                        <td>No</td>
                        <td>
                            <button type='button' className='btn btn-primary'>Edit</button>
                            &nbsp; | &nbsp;
                            <button type='button' className='btn btn-danger'>Delete</button>
                        </td>
                    </tr>
                </table>
            </div>
        );
    }
}

export { EmployeeTable };