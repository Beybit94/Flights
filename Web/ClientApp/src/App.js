import React, { Component } from 'react';
import { withRouter, Route } from 'react-router';

import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Logout } from './components/Logout';
import { FetchData } from './components/FetchData';

import './custom.css'

class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route exact path='/' render={(props) => <Home {...props} />} />
                <Route path='/logout' component={Logout}/>
                <Route path='/flights' component={FetchData} />
                <Route path='/dashboard' component={FetchData} />
            </Layout>
        );
    }
}

export default withRouter(App);