import React, { Component } from "react";
import Toolbar from "./components/Toolbar/Toolbar";
import axios from "axios";
import SimpleList from "./components/SimpleList/SimpleList";

class App extends Component {
  state = {
    sideDrawerOpen: false,
    error: null,
    isLoaded: false,
    planets: []
  };

  getPlanets() {
    return axios.get(`https://localhost:44325/api/planet/GetAll`);
  }

  componentDidMount() {
    this.getPlanets()
    .then(
      (result)=>{
        this.setState({
          isLoaded: true,
          planets: result.data
        });
      },
      (error)=>{
        this.setState({
          isLoaded: true,
          error
        });
      }
    )
  }

  render() {
    const { planets } = this.state;
    return (
      <div style={{ height: "100%" }}>
        <Toolbar/>
        <main style={{ marginTop: "230px" }}>
          <SimpleList list={planets}/>
        </main>
      </div>
    );
  }
}

export default App;
