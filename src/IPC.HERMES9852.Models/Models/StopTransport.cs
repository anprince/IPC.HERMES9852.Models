using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "StopTransport")]
    public class StopTransport
    {
        [DataMember]
        [XmlAttribute(AttributeName = "TransferState")]
        public int TransferState { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }
    }
}
