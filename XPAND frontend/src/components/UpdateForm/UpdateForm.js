import React from 'react';
import Toolbar from "../Toolbar/Toolbar";
import axios from "axios";
import "./UpdateForm.css";

function UpdateForm(props){
    
    return (
            <div style={{ height: "100%" }}>
              <Toolbar/>
              <main style={{ marginTop: "230px" }}>
                <h2 id="planet_name_label">Planet {props.planet.name} update:</h2>
                <label id="description_label">Description:</label>
                <input type="text" id="description" name="description" contentEditable="true"></input>
                <h4></h4>                
                <form>
                <label id="status_label">Status:</label>
                <input type="radio" id="ok" name="status" value="OK"/>
                <label for="ok">OK</label>
                <input type="radio" id="!ok" name="status" value="!OK"/>
                <label for="!ok">!OK</label>
                </form>
              </main>
              <h4></h4>
              <button  className="update_button" onClick={_=>{
                    var newStatus;
                    var newDescription = document.getElementById('description');
                    var radios = document.getElementsByName('status');       
                    for(var i = 0; i<radios.length; i++){
                      if (radios[i].checked) {
                          newStatus = radios[i].value;
                          break;
                      }
                    }
                    let newPlanet = {
                      "planetId": props.planet.planetId,
                      "name": props.planet.name,
                      "status": newStatus,
                      "captainName": props.planet.captainName,
                      "image": props.planet.image,
                      "description": newDescription.value
                  }
                    axios.put("https://localhost:44325/api/planet/Update/"+ props.planet.planetId, newPlanet)
                          .then(response=>alert("The planet was updated! Click the logo to go back to the planet list!"));                    
                }}>
                    <h3>Update planet</h3>
                </button>
            </div>
    );
}
export default UpdateForm;