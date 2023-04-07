using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "MachineReady")]
    public class MachineReady
    {
        /// <summary>
        /// 0 Ready to accept any board
        /// 1 Ready to accept good boards.
        /// 2 Ready to accept failed boards
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "FailedBoard")]
        public int FailedBoard { get; set; }

        /// <summary>
        /// If responding to a BoardForecast message mandatory. It indicates 
        /// the ID of the original BoardForecast message.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "ForecastId")]
        public string ForecastId { get; set; }

        /// <summary>
        /// Indicates the ID of the board that will be handed over as next. 
        /// In case of product change this attribute will not be sent
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }

        /// <summary>
        /// Identifies a collection of PCBs sharing common properties.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "ProductTypeId")]
        public string ProductTypeId { get; set; }

        /// <summary>
        /// 0 Side up is unknown
        /// 1 Board top side is up
        /// 2 Board bottom side is up
        /// </summary>
        [XmlIgnore]
        public int? FlippedBoard { get; set; }

        [XmlIgnore]
        public bool XMLFlippedBoardSpecified { get { return FlippedBoard.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "FlippedBoard")]
        public int XMLFlippedBoard
        {
            get { return (FlippedBoard.HasValue) ? FlippedBoard.Value : 0; }
            set { FlippedBoard = value; }
        }

        /// <summary>
        /// The length of the PCB in millimeter.
        /// </summary>
        [XmlIgnore]
        public float? Length { get; set; }

        [XmlIgnore]
        public bool XMLLengthSpecified { get { return Length.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "Length")]
        public float XMLLength
        {
            get { return (Length.HasValue) ? Length.Value : 0; }
            set { Length = value; }
        }

        /// <summary>
        /// The width of the PCB in millimeter.
        /// </summary>
        [XmlIgnore]
        public float? Width { get; set; }

        [XmlIgnore]
        public bool XMLWidthSpecified { get { return Width.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "Width")]
        public float XMLWidth
        {
            get { return (Width.HasValue) ? Width.Value : 0; }
            set { Width = value; }
        }

        /// <summary>
        /// The thickness of the PCB in millimeter.
        /// </summary>
        [XmlIgnore]
        public float? Thickness { get; set; }

        [XmlIgnore]
        public bool XMLThicknessSpecified { get { return Thickness.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "Thickness")]
        public float XMLThickness
        {
            get { return (Thickness.HasValue) ? Thickness.Value : 0; }
            set { Thickness = value; }
        }

        /// <summary>
        /// The conveyor speed preferred by the upstream machine in millimeter per second.
        /// </summary>
        [XmlIgnore]
        public float? ConveyorSpeed { get; set; }

        [XmlIgnore]
        public bool XMLConveyorSpeedSpecified { get { return ConveyorSpeed.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "ConveyorSpeed")]
        public float XMLConveyorSpeed
        {
            get { return (ConveyorSpeed.HasValue) ? ConveyorSpeed.Value : 0; }
            set { ConveyorSpeed = value; }
        }

        /// <summary>
        /// The clearance height for the top side of the PCB in millimeter.
        /// </summary>
        [XmlIgnore]
        public float? TopClearanceHeight { get; set; }

        [XmlIgnore]
        public bool XMLTopClearanceHeightSpecified { get { return TopClearanceHeight.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "TopClearanceHeight")]
        public float XMLTopClearanceHeight
        {
            get { return (TopClearanceHeight.HasValue) ? TopClearanceHeight.Value : 0; }
            set { TopClearanceHeight = value; }
        }

        /// <summary>
        /// The clearance height for the bottom side of the PCB in millimeter
        /// </summary>
        [XmlIgnore]
        public float? BottomClearanceHeight { get; set; }

        [XmlIgnore]
        public bool XMLBottomClearanceHeightSpecified { get { return BottomClearanceHeight.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "BottomClearanceHeight")]
        public float XMLBottomClearanceHeight
        {
            get { return (BottomClearanceHeight.HasValue) ? BottomClearanceHeight.Value : 0; }
            set { BottomClearanceHeight = value; }
        }

        /// <summary>
        /// The weight of the PCB in grams
        /// </summary>
        [XmlIgnore]
        public float? Weight { get; set; }

        [XmlIgnore]
        public bool XMLWeightSpecified { get { return Weight.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "Weight")]
        public float XMLWeight
        {
            get { return (Weight.HasValue) ? Weight.Value : 0; }
            set { Weight = value; }
        }

        /// <summary>
        /// Identifies the work order for production of the PCB.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "WorkOrderId")]
        public string WorkOrderId { get; set; }

        /// <summary>
        /// Identifies the Batch for production of the PCB within a splitted work order
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "BatchId")]
        public string BatchId { get; set; }
    }
}
