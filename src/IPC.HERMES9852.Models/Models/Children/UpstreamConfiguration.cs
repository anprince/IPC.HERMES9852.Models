using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "UpstreamConfiguration")]
    public class UpstreamConfiguration
    {
        [DataMember]
        [XmlAttribute(AttributeName = "UpstreamLaneId")]
        public int UpstreamLaneId { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "UpstreamInterfaceId")]
        public string UpstreamInterfaceId { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "HostAddress")]
        public string HostAddress { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "Port")]
        public int Port { get; set; }
    }
}
