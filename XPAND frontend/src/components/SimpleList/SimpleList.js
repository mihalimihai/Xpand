import React, { useCallback } from "react";
import "./SimpleList.css";
import UpdateForm from "../UpdateForm/UpdateForm";
import ReactDOM from 'react-dom';

const SimpleList = ({ list }) => {
  const renderStatus = useCallback(
    status =>
      status ? (
        <text data-status={status}>{status}</text>
      ) : (
        <text className="no_status">{"En route"}</text>
      ),
    []
  );

  const renderDescription = useCallback(
    item =>
      item.description ? (
        <div className="description_container">
          <text>{`"${item.description}"`}</text>
          <text className="bold_title">
            {"by captain: "}
            <text className="captain_name">"Mihai"</text>
          </text>
          <text className="bold_title">
            {"Robots: "}
            <text className="robot_name">
              {item.robots.map(robot => robot.name).join()}
            </text>
          </text>
        </div>
      ) : (
        <text className="no_description">No description yet :/</text>
      ),
    []
  );

  return list.map(item => (
    <button className="container" onClick={_ =>{
        ReactDOM.render(<UpdateForm planet={item}/>, document.getElementById('root'));
      }}>
      <div className="left_container">
        <div className="planet_image_container">
          <img src={item.image} width="100" height="100" />
          <text className="planet_name">{item.name}</text>
        </div>
        {renderDescription(item)}
      </div>
      {renderStatus(item.status)}
    </button>
  ));
};
export default SimpleList;
