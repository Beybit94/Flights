import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from './NavMenu';

export class Layout extends Component {
    static displayName = Layout.name;

    constructor(props) {
        super(props);
        this.updateNav = this.updateNav.bind(this)
    }

    updateNav = () => {
        this.forceUpdate();
    }

    render() {
        const childrenWithProps = React.Children.map(this.props.children, child => {
            if (React.isValidElement(child)) {
                console.log(child);
                return React.cloneElement(child, { updateNav: this.updateNav });
            }
            return child;
        });
        return (
            <div className="App">
                <div className="auth-wrapper">
                    <NavMenu />
                    <div className="auth-inner">
                        <Container>
                            {childrenWithProps}
                        </Container>
                    </div>
                </div>
            </div>
        );
    }
}
