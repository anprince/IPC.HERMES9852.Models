using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "SupervisoryServiceDescription")]
    public class SupervisoryServiceDescription
    {
        [DataMember]
        [XmlAttribute(AttributeName = "SystemId")]
        public string SystemId { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "Version")]
        public string Version { get; set; }

        [DataMember]
        [XmlElement(ElementName = "SupportedFeatures")]
        public SupvervisoryFeatures SupportedFeatures { get; set; }
    }
}
