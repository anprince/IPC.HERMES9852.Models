using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "Hermes")]
    public class AllHermesMessages
    {
        [DataMember]
        [XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [DataMember]
        [XmlElement(ElementName = "CheckAlive")]
        public CheckAlive CheckAlive { get; set; }

        [DataMember]
        [XmlElement(ElementName = "ServiceDescription")]
        public ServiceDescription ServiceDescription { get; set; }

        [DataMember]
        [XmlElement(ElementName = "Notification")]
        public Notification Notification { get; set; }

        [DataMember]
        [XmlElement(ElementName = "BoardAvailable")]
        public BoardAvailable BoardAvailable { get; set; }

        [DataMember]
        [XmlElement(ElementName = "RevokeBoardAvailable")]
        public RevokeBoardAvailable RevokeBoardAvailable { get; set; }

        [DataMember]
        [XmlElement(ElementName = "MachineReady")]
        public MachineReady MachineReady { get; set; }

        [DataMember]
        [XmlElement(ElementName = "RevokeMachineReady")]
        public RevokeMachineReady RevokeMachineReady { get; set; }

        [DataMember]
        [XmlElement(ElementName = "StartTransport")]
        public StartTransport StartTransport { get; set; }

        [DataMember]
        [XmlElement(ElementName = "StopTransport")]
        public StopTransport StopTransport { get; set; }

        [DataMember]
        [XmlElement(ElementName = "TransportFinished")]
        public TransportFinished TransportFinished { get; set; }

        [DataMember]
        [XmlElement(ElementName = "BoardForecast")]
        public BoardForecast BoardForecast { get; set; }

        [DataMember]
        [XmlElement(ElementName = "QueryBoardInfo")]
        public QueryBoardInfo QueryBoardInfo { get; set; }

        [DataMember]
        [XmlElement(ElementName = "SendBoardInfo")]
        public SendBoardInfo SendBoardInfo { get; set; }

        [DataMember]
        [XmlElement(ElementName = "SetConfiguration")]
        public SetConfiguration SetConfiguration { get; set; }

        [DataMember]
        [XmlElement(ElementName = "GetConfiguration")]
        public GetConfiguration GetConfiguration { get; set; }

        [DataMember]
        [XmlElement(ElementName = "CurrentConfiguration")]
        public CurrentConfiguration CurrentConfiguration { get; set; }

        [DataMember]
        [XmlElement(ElementName = "SupervisoryServiceDescription")]
        public SupervisoryServiceDescription SupervisoryServiceDescription { get; set; }

        [DataMember]
        [XmlElement(ElementName = "BoardArrived")]
        public BoardArrived BoardArrived { get; set; }

        [DataMember]
        [XmlElement(ElementName = "BoardDeparted")]
        public BoardDeparted BoardDeparted { get; set; }

        [DataMember]
        [XmlElement(ElementName = "QueryWorkOrderInfo")]
        public QueryWorkOrderInfo QueryWorkOrderInfo { get; set; }

        [DataMember]
        [XmlElement(ElementName = "SendWorkOrderInfo")]
        public SendWorkOrderInfo SendWorkOrderInfo { get; set; }

        [DataMember]
        [XmlElement(ElementName = "ReplyWorkOrderInfo")]
        public ReplyWorkOrderInfo ReplyWorkOrderInfo { get; set; }

        [DataMember]
        [XmlElement(ElementName = "Command")]
        public ACommand Command { get; set; }
    }
}

