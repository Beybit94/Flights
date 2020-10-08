import React, { Component } from 'react';

export class FetchData extends Component {
    static displayName = FetchData.name;

    constructor(props) {
        super(props);
        this.state = { data: [], loading: true };
    }

    componentDidMount() {
        this.populateData();
    }

    renderContent(data) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>DepartureTime</th>
                        <th>ArrivalTime</th>
                        <th>DepartureCity</th>
                        <th>ArrivalCity</th>
                        <th>Customer</th>
                        <th>Delay</th>
                    </tr>
                </thead>
                <tbody>
                    {data.map(m =>
                        <tr key={m.strID}>
                            <td>{m.departureTimeStr}</td>
                            <td>{m.arrivalTimeStr}</td>
                            <td>{m.departureCity}</td>
                            <td>{m.arrivalCity}</td>
                            <td>{m.customer.fullName}</td>
                            <td>{m.delay}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderContent(this.state.data);

        return (
            <div>
                {contents}
            </div>
        );
    }

    async populateData() {
        const requestOptions = {
            method: 'GET',
            headers: {
                "Accept": "application/json",
                "Access-Control-Allow-Origin": "*",
                "Content-Type": "application/json"
            },
        };
        const response = await fetch('https://localhost:44399/api/Admin/List', requestOptions);
        const data = await response.json();
        this.setState({ data: data.data, loading: false });
    }
}
