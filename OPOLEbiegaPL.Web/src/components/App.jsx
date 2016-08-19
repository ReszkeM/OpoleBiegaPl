﻿import React from 'react';
import {connect} from 'react-redux';
import * as actionCreators from '../action_creators';
import Menu from './Menu';
import Header from './Header';
import Content from './Content';

export const App = React.createClass({
    render: function() {
        return  <div>
                    <Menu
                        changeCurrentContent = {this.props.changeCurrentContent}
                        menuItems = {['Persons', 'Friends', 'Events', 'Announcement', 'Contact']} />
                    <Header />
                    <Content {...this.props} />
                </div>
    }
});

function mapStateToProps(state, props) {
    return {
        currentView: state.get('currentView'),
        persons: state.get('persons').valueSeq(),
        events: state.get('events').valueSeq(),
        friends: state.get('friends').valueSeq(),
        contact: state.get('contact'),
        announcements: state.get('announcements').valueSeq()
    };
}

export default connect(mapStateToProps, actionCreators)(App);