using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class QueryWorkOrderInfoMessage
    {
        [DataMember]
        [XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [DataMember]
        [XmlElement(ElementName = "QueryWorkOrderInfo")]
        public QueryWorkOrderInfo QueryWorkOrderInfo { get; set; }
    }
}

