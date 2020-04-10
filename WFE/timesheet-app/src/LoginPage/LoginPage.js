import React from 'react';
import { connect } from 'react-redux';
import 'bootstrap/dist/css/bootstrap.min.css'
import './LoginPage.css';
import './util.css';
import BackGroundImage from '../_images/bg-01.jpg';

import { employeeActions } from '../_actions';

class LoginPage extends React.Component {
    constructor(props){
        super(props)

        //reset login status
        this.props.dispatch(employeeActions.logout());

        this.state = {
            username: '',
            password: '',
            submitted: false
        };

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleChange(e) {
        const { name, value } = e.target;
        this.setState({ [name]: value })
    }

    handleSubmit(e) {
        e.preventDefault();
        this.setState({ submitted: true });
        const{ username, password} = this.state;
        const{ dispatch } = this.props;
        dispatch(employeeActions.login(username, password));
    }

    render() {
        const { loggingIn } = this.props;
        const { username, password, submitted } = this.state;

        return (
            <div className='limiter'>
		        <div className="container-login100">
			        <div className="wrap-login100">
				        <div className="login100-form-title" style={{backgroundImage: `url(${BackGroundImage})`}}>
					        <span className="login100-form-title-1">
						        Sign In
					        </span>
				        </div>

                        <form name='loginForm' className="login100-form validate-form" onSubmit={this.handleSubmit}>
                            <div className={'form-group' + ' wrap-input100' + ' validate-input'+ ' m-b-26'  + 
                                            (submitted && !username ? ' has-error' : '')}>
                                <span className="label-input100">Username</span>
                                <input className="input100" type="text" name="username" value={username}
                                       onChange={this.handleChange} placeholder="Enter username" />
                                {submitted && !username &&
                                    <div className="help-block">Username is required</div>
                                }
                            </div>

                            <div className={'form-group' + ' wrap-input100' + ' validate-input'+ ' m-b-18'  + 
                                            (submitted && !password ? ' has-error' : '')}>
                                <span className="label-input100">Password</span>
                                <input className="input100" type="password" name="password" value={password}
                                       onChange={this.handleChange} placeholder="Enter password" />
                                {submitted && !username &&
                                    <div className="help-block">Password is required</div>
                                }
                            </div>
                            <div className="form-group container-login100-form-btn">
                                <button className="login100-form-btn">
                                    Login
                                </button>
                                {loggingIn &&
                                    <img alt="" src="data:image/gif;base64,R0lGODlhEAAQAPIAAP///wAAAMLCwkJCQgAAAGJiYoKCgpKSkiH/C05FVFNDQVBFMi4wAwEAAAAh/hpDcmVhdGVkIHdpdGggYWpheGxvYWQuaW5mbwAh+QQJCgAAACwAAAAAEAAQAAADMwi63P4wyklrE2MIOggZnAdOmGYJRbExwroUmcG2LmDEwnHQLVsYOd2mBzkYDAdKa+dIAAAh+QQJCgAAACwAAAAAEAAQAAADNAi63P5OjCEgG4QMu7DmikRxQlFUYDEZIGBMRVsaqHwctXXf7WEYB4Ag1xjihkMZsiUkKhIAIfkECQoAAAAsAAAAABAAEAAAAzYIujIjK8pByJDMlFYvBoVjHA70GU7xSUJhmKtwHPAKzLO9HMaoKwJZ7Rf8AYPDDzKpZBqfvwQAIfkECQoAAAAsAAAAABAAEAAAAzMIumIlK8oyhpHsnFZfhYumCYUhDAQxRIdhHBGqRoKw0R8DYlJd8z0fMDgsGo/IpHI5TAAAIfkECQoAAAAsAAAAABAAEAAAAzIIunInK0rnZBTwGPNMgQwmdsNgXGJUlIWEuR5oWUIpz8pAEAMe6TwfwyYsGo/IpFKSAAAh+QQJCgAAACwAAAAAEAAQAAADMwi6IMKQORfjdOe82p4wGccc4CEuQradylesojEMBgsUc2G7sDX3lQGBMLAJibufbSlKAAAh+QQJCgAAACwAAAAAEAAQAAADMgi63P7wCRHZnFVdmgHu2nFwlWCI3WGc3TSWhUFGxTAUkGCbtgENBMJAEJsxgMLWzpEAACH5BAkKAAAALAAAAAAQABAAAAMyCLrc/jDKSatlQtScKdceCAjDII7HcQ4EMTCpyrCuUBjCYRgHVtqlAiB1YhiCnlsRkAAAOwAAAAAAAAAAAA==" />
                                }
                                
                            </div>
                        </form>
			        </div>
		        </div>
	        </div>
        );
    }
}

function mapStateToProps(state) {
    // const { authentication } = state;
    return {
        loggingIn: state.authentication
    };
}

const connectedLoginPage = connect(mapStateToProps)(LoginPage);
export { connectedLoginPage as LoginPage }
