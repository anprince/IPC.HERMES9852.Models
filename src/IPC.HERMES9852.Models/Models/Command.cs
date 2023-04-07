using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Command")]
    public class ACommand
    {
        [DataMember]
        [XmlAttribute(AttributeName = "Command")]
        public int Command { get; set; }
    }
}
