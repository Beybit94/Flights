import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

export class NavMenu extends Component {
    static displayName = NavMenu.name;

    constructor(props) {
        super(props);

        this.toggleNavbar = this.toggleNavbar.bind(this);
        this.state = { user: null, collapsed: true };
    }

    componentDidMount() {
        const token = localStorage.getItem("token");
        this.setState({ token: token });
    }

    toggleNavbar() {
        this.setState({ collapsed: !this.state.collapsed });
    }

    render() {
        const { token } = this.state;

        let brand;
        let navs;

        if (token) {
            brand = <NavbarBrand tag={Link} to="/dashboard">Home</NavbarBrand>
            navs = <>
                <NavItem>
                    <NavLink tag={Link} className="text-dark" to="/logout">Logout</NavLink>
                </NavItem>
                <NavItem>
                    <NavLink tag={Link} className="text-dark" to="/dashboard">Dashboard</NavLink>
                </NavItem>
            </>
        } else {
            brand = <NavbarBrand tag={Link} to="/flights">Home</NavbarBrand>
            navs = <>
                <NavItem>
                    <NavLink tag={Link} className="text-dark" to="/">Login</NavLink>
                </NavItem>
                <NavItem>
                    <NavLink tag={Link} className="text-dark" to="/flights">Flights</NavLink>
                </NavItem>
            </>
        }

        return (
            <header>
                <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" light>
                    <Container>
                        {brand}
                        <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
                        <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar>
                            <ul className="navbar-nav flex-grow">
                                {navs}
                            </ul>
                        </Collapse>
                    </Container>
                </Navbar>
            </header>
        );
    }
}
