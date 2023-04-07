using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "ReplyWorkOrderInfo")]
    public class ReplyWorkOrderInfo
    {
        [DataMember]
        [XmlAttribute(AttributeName = "WorkOrderId")]
        public string WorkOrderId { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "BatchId")]
        public string BatchId { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "Status")]
        public int Status { get; set; }
    }
}
