﻿namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "Hermes")]
    public class SendBoardInfoMessage
    {
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Timestamp")]
        public string Timestamp { get; set; }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlElement(ElementName = "SendBoardInfo")]
        public SendBoardInfo SendBoardInfo { get; set; }
    }
}
