import React, { Component } from 'react';
import { Redirect } from "react-router-dom";

export class Logout extends Component {
    static displayName = Logout.name;

    constructor(props) {
        super(props);
    }

    componentDidMount() {
        localStorage.removeItem("token");
    }
    render() {
        return <Redirect push to="/" />;
    }
}
