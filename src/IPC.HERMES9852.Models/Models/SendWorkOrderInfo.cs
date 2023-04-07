using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "SendWorkOrderInfo")]
    public class SendWorkOrderInfo
    {
        /// <summary>
        /// ID of QueryWorkOrderInfo this message refers to. This attribute is mandatory if it has been in the QueryWorkOrderInfo message.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "QueryId")]
        public string QueryId { get; set; }

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

        /// <summary>
        /// Indicating the ID of the available board
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }

        /// <summary>
        /// MachineId of the machine which created the BoardId (the first machine in a
        /// consecutive row of machines implementing this protocol). The MachineId is
        /// part of the Hermes configuration
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "BoardIdCreatedBy")]
        public string BoardIdCreatedBy { get; set; }

        /// <summary>
        /// This attribute will not be sent if the board information hasnot been found.
        /// 0 Board of unknown quality available
        /// 1 Good board available
        /// 2 Failed board available
        /// </summary>
        [XmlIgnore]
        public int? FailedBoard { get; set; }

        [XmlIgnore]
        public bool XMLFailedBoardSpecified { get { return FailedBoard.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "FailedBoard")]
        public int XMLFailedBoard
        {
            get { return (FailedBoard.HasValue) ? FailedBoard.Value : 0; }
            set { FailedBoard = value; }
        }

        /// <summary>
        /// Identifies a collection of PCBs sharing common properties.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "ProductTypeId")]
        public string ProductTypeId { get; set; }

        /// <summary>
        /// This attribute will not be sent if the board information has not been found.
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
        /// The barcode of the top side of the PCB. This attribute is mandatory
        /// if it has been the barcode in the QueryWorkOrderInfo message.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "TopBarcode")]
        public string TopBarcode { get; set; }

        /// <summary>
        /// The barcode of the bottom side of the PCB.This attribute is mandatory if
        /// it has been the barcode in the QueryWorkOrderInfo message.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "BottomBarcode")]
        public string BottomBarcode { get; set; }

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
        /// A routing instruction to downstream machines.
        /// 0 Route undefined
        /// 1..99 Transfer the board at route[no.] /defined by line configuration
        /// 900 Return the board
        /// (≤ 998 Reserved for future definition)
        /// 999 Manual removal of the board
        /// ≥1000 For individual definition within a production line
        /// </summary>
        [XmlIgnore]
        public int? Route { get; set; }

        [XmlIgnore]
        public bool XMLRouteSpecified { get { return Route.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "Route")]
        public int XMLRoute
        {
            get { return (Route.HasValue) ? Route.Value : 0; }
            set { Route = value; }
        }

        /// <summary>
        /// A list of SubBoards 
        /// Note: Due to limited retain memory in PLCs this attribute might only be
        /// supported for a limited number of subboards.
        /// </summary>
        [DataMember]
        [XmlArray("SubBoards")]
        [XmlArrayItem("SubBoard")]
        public SubBoard[] SubBoards { get; set; }
    }
}
