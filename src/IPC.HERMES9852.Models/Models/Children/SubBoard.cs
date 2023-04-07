using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "SubBoard")]
    public class SubBoard
    {
        [DataMember]
        [XmlAttribute(AttributeName = "Pos")]
        public int Pos { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "Bc")]
        public string Bc { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "St")]
        public int St { get; set; }
    }
}
