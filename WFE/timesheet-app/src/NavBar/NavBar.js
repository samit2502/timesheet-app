import React from 'react';
// import { connect } from 'react-redux';
import { Link } from 'react-router-dom';

import './NavBar.css';

class NavBar extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            menu: false,
            FullName: props.FullName
        };

        this.toggleMenu = this.toggleMenu.bind(this);
    }

    toggleMenu() {
        this.setState({menu: !this.state.menu})
    }
    render() {
        const show = (this.state.menu) ? "show": "";
        const FullName = this.state.FullName;

        return(
            <nav className="navbar navbar-expand-sm bg-dark navbar-dark">
                {/* Brand */}
                <a className="navbar-brand" href="#">Logo</a>

                {/* Links */}
                <ul className="navbar-nav">
                    <li className="nav-item">
                        <a className="nav-link" href="#">Link 1</a>
                    </li>
                    <li className="nav-item">
                        <a className="nav-link" href="#">Link 2</a>
                    </li>

                    {/* Dropdown */}
                    <li className="nav-item dropdown navbar-dropdown">
                        <a className="nav-link dropdown-toggle" href="#" id="navbardrop" onClick={ this.toggleMenu }>
                            {FullName}
                        </a>
                        <div className={ "dropdown-menu navbar-dropdown-menu " + show}>
                            <a className="dropdown-item" href="#">Link 1</a>
                            <a className="dropdown-item" href="#">Link 2</a>
                            {/* <a className="dropdown-item" href="#">Link 3</a> */}
                            <Link to='/login'>Logout</Link>
                        </div>
                    </li>
                </ul>
            </nav>
        );
    }
}

// function mapStateToProps(state) {

// }

// const connectedNavBar = connect(mapStateToProps)(NavBar);
export {  NavBar };