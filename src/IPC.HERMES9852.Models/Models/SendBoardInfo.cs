﻿namespace IPC.HERMES9852.Models
{
    [System.Xml.Serialization.XmlRoot(ElementName = "SendBoardInfo")]
    public class SendBoardInfo
    {
        /// <summary>
        /// The ID of the board which data has been requested.This attribute will
        /// not be sent if the board information has not been found.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }

        /// <summary>
        /// MachineId of the machine which created the BoardId.This attribute will
        /// not be sent if the board information has not been found. 
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BoardIdCreatedBy")]
        public string BoardIdCreatedBy { get; set; }

        /// <summary>
        /// FailedBoard may be one of the following values:
        /// 0 Ready to accept any board
        /// 1 Ready to accept good boards.
        /// 2 Ready to accept failed boards
        /// This attribute will not be sent if the board information has not been found.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public int? FailedBoard { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLFailedBoardSpecified { get { return FailedBoard.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FailedBoard")]
        public int XMLFailedBoard
        {
            get { return (FailedBoard.HasValue) ? FailedBoard.Value : 0; }
            set { FailedBoard = value; }
        }

        /// <summary>
        /// Identifies a collection of PCBs sharing common properties.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProductTypeId")]
        public string ProductTypeId { get; set; }

        /// <summary>
        /// 0 Side up is unknown
        /// 1 Board top side is up
        /// 2 Board bottom side is up
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public int? FlippedBoard { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLFlippedBoardSpecified { get { return FlippedBoard.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FlippedBoard")]
        public int XMLFlippedBoard
        {
            get { return (FlippedBoard.HasValue) ? FlippedBoard.Value : 0; }
            set { FlippedBoard = value; }
        }

        /// <summary>
        /// The barcode of the top side of the next PCB.This attribute is mandatory
        /// if it has been in the QueryBoardInfo message
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopBarcode")]
        public string TopBarcode { get; set; }

        /// <summary>
        /// The barcode of the bottom side of the next PCB.This attribute is mandatory 
        /// if it has been in the QueryBoardInfo message.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BottomBarcode")]
        public string BottomBarcode { get; set; }

        /// <summary>
        /// The length of the PCB in millimeter.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? Length { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLLengthSpecified { get { return Length.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Length")]
        public float XMLLength
        {
            get { return (Length.HasValue) ? Length.Value : 0; }
            set { Length = value; }
        }

        /// <summary>
        /// The width of the PCB in millimeter.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? Width { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLWidthSpecified { get { return Width.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Width")]
        public float XMLWidth
        {
            get { return (Width.HasValue) ? Width.Value : 0; }
            set { Width = value; }
        }

        /// <summary>
        /// The thickness of the PCB in millimeter.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? Thickness { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLThicknessSpecified { get { return Thickness.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Thickness")]
        public float XMLThickness
        {
            get { return (Thickness.HasValue) ? Thickness.Value : 0; }
            set { Thickness = value; }
        }

        /// <summary>
        /// The clearance height for the top side of the PCB in millimeter.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? TopClearanceHeight { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLTopClearanceHeightSpecified { get { return TopClearanceHeight.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopClearanceHeight")]
        public float XMLTopClearanceHeight
        {
            get { return (TopClearanceHeight.HasValue) ? TopClearanceHeight.Value : 0; }
            set { TopClearanceHeight = value; }
        }

        /// <summary>
        /// The clearance height for the bottom side of the PCB in millimeter
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public float? BottomClearanceHeight { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool XMLBottomClearanceHeightSpecified { get { return BottomClearanceHeight.HasValue; } }

        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BottomClearanceHeight")]
        public float XMLBottomClearanceHeight
        {
            get { return (BottomClearanceHeight.HasValue) ? BottomClearanceHeight.Value : 0; }
            set { BottomClearanceHeight = value; }
        }

        /// <summary>
        /// Identifies the work order for production of the PCB.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "WorkOrderId")]
        public string WorkOrderId { get; set; }

        /// <summary>
        /// Identifies the Batch for production of the PCB within a splitted work order
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BatchId")]
        public string BatchId { get; set; }
    }
}
