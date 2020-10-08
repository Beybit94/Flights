import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;
   
    constructor(props) {
        super(props);
        console.log(props);
        this.state = { data: null, loading: false, login: "", password: "" };

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    componentDidMount() {
        //this.props.updateNav();
        const token = localStorage.getItem("token");
        if (token) {
            this.props.history.push("/dashboard");
        }
    }

    handleChange(event){
        this.setState({
            [event.target.name]: event.target.value
        });
    };

    async handleSubmit(event) {
        try {
            this.setState({ loading: true });

            const requestOptions = {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ Username: this.state.login, Password: this.state.password })
            };
            const response = await fetch('https://localhost:44399/api/Account/Authenticate', requestOptions)
            const data = await response.json();
            localStorage.setItem("token", data.token);
            this.setState({ data: data });
            window.location.reload(false);
        } catch (ex) {
            alert(ex);
        } finally {
            this.setState({ loading: false });
        }
    };

    renderContent() {
        const { login, password } = this.state;

        return (
            <form onSubmit={this.handleSubmit}>
                <div className="form-group">
                    <label>Login</label>
                    <input
                        value={login}
                        onChange={this.handleChange}
                        name="login" type="text" className="form-control" />
                </div>

                <div className="form-group">
                    <label>Password</label>
                    <input
                        value={password}
                        onChange={this.handleChange}
                        name="password" type="password" className="form-control" />
                </div>
                <button type="submit" className="btn btn-primary btn-block">Login</button>
            </form>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderContent();

        return (
            <div>
                {contents}
            </div>
        );
    }
}
