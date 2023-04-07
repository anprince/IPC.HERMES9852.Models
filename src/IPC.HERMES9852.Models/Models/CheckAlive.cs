using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "CheckAlive")]
    public class CheckAlive
    {
        /// <summary>
        /// Ping / Pong message type. 
        /// Type may be one of the following values:
        /// 1 Ping: CheckAlive request.
        /// 2 Pong:CheckAlive response.
        /// </summary>
        [XmlIgnore]
        public int? Type { get; set; }

        [XmlIgnore]
        public bool XMLTypeSpecified { get { return Type.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "Type")]
        public int XMLType
        {
            get { return (Type.HasValue) ? Type.Value : 0; }
            set { Type = value; }
        }

        /// <summary>
        /// Identifier of the message
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }
    }
}
