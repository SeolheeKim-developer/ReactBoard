import React, { Component } from 'react';

export class EntryIndex extends Component {
    constructor(props) {
        super(props);

        this.state = {
            entries: [],
            loading: true
        };

        this.navigateToCreate = this.navigateToCreate.bind(this);
    }

    //page load, OnInitialized()
    componentDidMount() {

    }

    render() {
        return (
            <h1>List</h1>
        );
    }

    navigateToCreate() {
        const { history } = this.props;
        history.push('/Entries/Create')
    }
}