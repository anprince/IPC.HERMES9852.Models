using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "QueryBoardInfo")]
    public class QueryBoardInfo
    {
        [DataMember]
        [XmlAttribute(AttributeName = "TopBarcode")]
        public string TopBarcode { get; set; }

        [DataMember]
        [XmlAttribute(AttributeName = "BottomBarcode")]
        public string BottomBarcode { get; set; }
    }
}
