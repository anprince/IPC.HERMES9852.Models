using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class QueryBoardInfoMessage
    {
        [DataMember]
        [XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "QueryBoardInfo")]
        public QueryBoardInfo QueryBoardInfo { get; set; }
    }
}
