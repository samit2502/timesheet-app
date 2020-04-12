import React from 'react';
import { Route, Router } from 'react-router-dom';
import { connect } from 'react-redux';

import { history } from '../_helpers';
import { alertActions } from '../_actions';
import { PrivateRoute } from '../_components';
import { LoginPage } from '../LoginPage';
import { LandingPage } from '../LandingPage';

class App extends React.Component {
  constructor(props){
    super(props);

    const { dispatch } = this.props;
    history.listen((location, action) => {
      //clear alert on locaiton change
      dispatch(alertActions.clear());
    });
  }

  render() {
    const { alert } = this.props;
    return(
      <div>
        {/* <div className='container-fluid'>
          <div className='col-sm-8 col-sm-offset-2'> */}
            {alert.message &&
                <div className={`alert ${alert.type}`}>{alert.message}</div>
            }
            <Router history={history}>
              <div>
                <PrivateRoute exact path="/" component={LoginPage} />
                <Route path="/login" component={LoginPage} />
                <PrivateRoute path="/landingPage" component={LandingPage} />
              </div>
            </Router>
          {/* </div>
        </div> */}
      </div>
    );
  }
}

function mapStateToProps(state) {
  const{ alert } = state;
  return {
    alert
  };
}

const connectedApp = connect(mapStateToProps)(App);
export { connectedApp as App };