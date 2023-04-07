using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "DownstreamConfiguration")]
    public class DownstreamConfiguration
    {
        [DataMember]
        [XmlAttribute(AttributeName = "DownstreamLaneId")]
        public int DownstreamLaneId { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "DownstreamInterfaceId")]
        public string DownstreamInterfaceId { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "ClientAddress")]
        public string ClientAddress { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "Port")]
        public int Port { get; set; }
    }
}
