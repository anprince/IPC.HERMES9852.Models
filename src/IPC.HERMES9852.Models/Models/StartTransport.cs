using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "StartTransport")]
    public class StartTransport
    {
        /// <summary>
        /// The ID of the board for which the transport shall be started. 
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }

        /// <summary>
        /// Optional parameter indicating the selected conveyor speed for the handover in millimeter per second.
        /// </summary>
        [XmlIgnore]
        public float? ConveyorSpeed { get; set; }

        [XmlIgnore]
        public bool XMLConveyorSpeedSpecified { get { return ConveyorSpeed.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "ConveyorSpeed")]
        public float XMLConveyorSpeed
        {
            get { return (ConveyorSpeed.HasValue) ? ConveyorSpeed.Value : 0; }
            set { ConveyorSpeed = value; }
        }
    }
}
