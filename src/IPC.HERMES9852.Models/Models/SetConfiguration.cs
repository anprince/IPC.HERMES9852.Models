using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "SetConfiguration")]
    public class SetConfiguration
    {
        /// <summary>
        /// ID / name of this machine for identifying it in a Hermes enabled production line.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "MachineId")]
        public string MachineId { get; set; }

        /// <summary>
        /// Port number on which connections from supervisory systems shall be established
        /// </summary>
        [XmlIgnore]
        public int? SupervisorySystemPort { get; set; }

        [XmlIgnore]
        public bool XMLSupervisorySystemPortSpecified { get { return SupervisorySystemPort.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "SupervisorySystemPort")]
        public int XMLSupervisorySystemPort
        {
            get { return (SupervisorySystemPort.HasValue) ? SupervisorySystemPort.Value : 0; }
            set { SupervisorySystemPort = value; }
        }

        /// <summary>
        /// Configuration for upstream lanes.
        /// </summary>
        [DataMember]
        [XmlArray("UpstreamConfigurations")]
        [XmlArrayItem("UpstreamConfiguration")]
        public UpstreamConfiguration[] UpstreamConfigurations { get; set; }

        /// <summary>
        /// Configuration for downstream lanes.
        /// </summary>
        [DataMember]
        [XmlArray("DownstreamConfigurations")]
        [XmlArrayItem("DownstreamConfiguration")]
        public DownstreamConfiguration[] DownstreamConfigurations { get; set; }

    }
}
