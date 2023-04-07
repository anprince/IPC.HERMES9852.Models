using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "SupportedFeatures")]
    public class SupvervisoryFeatures
    {
        [DataMember]
        [XmlElement(ElementName = "FeatureConfiguration")]
        public FeatureConfiguration FeatureConfiguration { get; set; }

        [DataMember]
        [XmlElement(ElementName = "FeatureCheckAliveResponse")]
        public FeatureCheckAliveResponse FeatureCheckAliveResponse { get; set; }

        [DataMember]
        [XmlElement(ElementName = "FeatureBoardTracking")]
        public FeatureBoardTracking FeatureBoardTracking { get; set; }

        [DataMember]
        [XmlElement(ElementName = "FeatureQueryWorkOrderInfo")]
        public FeatureQueryWorkOrderInfo FeatureQueryWorkOrderInfo { get; set; }

        [DataMember]
        [XmlElement(ElementName = "FeatureSendWorkOrderInfo")]
        public FeatureSendWorkOrderInfo FeatureSendWorkOrderInfo { get; set; }

        [DataMember]
        [XmlElement(ElementName = "FeatureReplyWorkOrderInfo")]
        public FeatureReplyWorkOrderInfo FeatureReplyWorkOrderInfo { get; set; }
    }
}
