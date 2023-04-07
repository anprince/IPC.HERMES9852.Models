using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class BoardAvailableMessage
    {
        [DataMember]
        [XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [DataMember]
        [XmlElement(ElementName = "BoardAvailable")]
        public BoardAvailable BoardAvailable { get; set; }
    }
}
