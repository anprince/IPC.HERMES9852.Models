using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class BoardArrivedMessage
    {
        [DataMember]
        [XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [DataMember]
        [XmlElement(ElementName = "BoardArrived")]
        public BoardArrived BoardArrived { get; set; }
    }
}

