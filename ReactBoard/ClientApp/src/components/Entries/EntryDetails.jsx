import React, { Component } from 'react';

export class EntryDetails extends Component {
    constructor(props) {
        super(props);

        //component state data
        this.state = {
            id: 0,
            name: '',
            title: "",
            content: "",
            created: null
        };

        this.navigateToIndex = this.navigateToIndex.bind(this);
    }

    //page load, OnInitialized()
    componentDidMount() {

    }

    render() {
        return (
            <h1>Details</h1>
        );
    }

    navigateToIndex() {
        const { history } = this.props;
        history.push('/Entries')
    }
}