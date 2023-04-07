using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Notification")]
    public class Notification
    {
        [DataMember]
        [XmlAttribute(AttributeName = "NotificationCode")]
        public int NotificationCode { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "Severity")]
        public int Severity { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }
    }
}
