﻿import React from 'react';
import Styles from '../../helpers/styles'

export default React.createClass({
  render: function () {
      return <div>
                  <div className="form-group row">
                      <label className="col-md-3" style={Styles.label}>Nazwa: </label>
                      <div className="col-md-9">
                          <input className="form-control" id="name" type="text" defaultValue={this.props.name} onChange={this.props.handleChange} />
                      </div>
                  </div>
                  <div className="form-group row">
                      <label className="col-md-3" style={Styles.label}>Obrazek: </label>
                      <div className="col-md-9">
                          <input className="form-control" id="imageURL" type="text" defaultValue={this.props.imageURL} onChange={this.props.handleChange} />
                      </div>
                  </div>
              </div>
  }
});
