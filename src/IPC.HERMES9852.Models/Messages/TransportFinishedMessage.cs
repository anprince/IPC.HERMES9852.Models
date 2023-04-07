
using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class TransportFinishedMessage
    {
        [DataMember]
        [XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [XmlElement(ElementName = "TransportFinished")]
        public TransportFinished TransportFinished { get; set; }
    }
}
