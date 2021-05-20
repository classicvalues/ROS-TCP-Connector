using RosMessageTypes.Sensor;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Robotics.MessageVisualizers;
using Unity.Robotics.ROSTCPConnector.ROSGeometry;
using UnityEngine;

public class DefaultVisualizerPointField : BasicVisualizer<MPointField>
{
    public override Action CreateGUI(MPointField message, MessageMetadata meta, BasicDrawing drawing) => () =>
    {
        message.GUI();
    };
}
