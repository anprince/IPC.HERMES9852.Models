using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "BoardDeparted")]
    public class BoardDeparted
    {
        /// <summary>
        /// ID / name of this machine for identifying it in a Hermes enabled production line.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "MachineId")]
        public string MachineId { get; set; }

        /// <summary>
        /// The lane on the downstream side. Lanes are enumerated looking downstream from
        /// right to left beginning with 1
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "DownstreamLaneId")]
        public int DownstreamLaneId { get; set; }

        /// <summary>
        /// The ID of the transportation interface on the downstream side.    
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "DownstreamInterfaceId")]
        public string DownstreamInterfaceId { get; set; }

        /// <summary>
        /// Barcode of a magazine, required to identify the magazine to which the Board was transferred.    
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "MagazineId")]
        public string MagazineId { get; set; }

        /// <summary>
        /// Indicates the slot in the magazine, enumerated from bottom to top, beginning with 1.
        /// </summary>
        [XmlIgnore]
        public int? SlotId { get; set; }

        [XmlIgnore]
        public bool XMLSlotIdSpecified { get { return SlotId.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "SlotId")]
        public int XMLSlotId
        {
            get { return (SlotId.HasValue) ? SlotId.Value : 0; }
            set { SlotId = value; }
        }

        /// <summary>
        /// BoardTransfer may be one of the following values:
        /// 1 Transferred: Board moved to downstream machine via Hermes or SMEMA.
        /// 2 Unloaded: Board was unloaded into a magazine.
        /// 3 Removed: Board was manually taken out of the machine.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "BoardTransfer")]
        public int BoardTransfer { get; set; }

        /// <summary>
        /// Indicating the ID of the available board.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "BoardId")]
        public string BoardId { get; set; }

        /// <summary>
        /// MachineId of the machine which created the BoardId(the first machine in a 
        /// consecutive row of machines implementing this protocol). The MachineId is
        /// part of the Hermes configuration.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "BoardIdCreatedBy")]
        public string BoardIdCreatedBy { get; set; }

        /// <summary>
        /// 0 Board of unknown quality available
        /// 1 Good board available
        /// 2 Failed board available
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "FailedBoard")]
        public int FailedBoard { get; set; }

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
        [DataMember]
        [XmlAttribute(AttributeName = "FlippedBoard")]
        public int FlippedBoard { get; set; }

        /// <summary>
        /// The barcode of the top side of the PCB.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "TopBarcode")]
        public string TopBarcode { get; set; }

        /// <summary>
        /// The barcode of the bottom side of the PCB.    
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

        [System.Xml.Serialization.XmlIgnore]
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
        /// An action instruction to downstream machine.
        /// 0 Action undefined
        /// 1 Process the board(e.g., Flipping, Marking, …)
        /// 2 Pass through the board without processing
        /// (≤ 999 Reserved for future definition)
        /// ≥1000 For individual definition within a production line
        /// </summary>
        [XmlIgnore]
        public int? Action { get; set; }

        [XmlIgnore]
        public bool XMLActionSpecified { get { return Action.HasValue; } }

        [DataMember]
        [XmlAttribute(AttributeName = "Action")]
        public int XMLAction
        {
            get { return (Action.HasValue) ? Action.Value : 0; }
            set { Action = value; }
        }

        /// <summary>
        /// A list of SubBoards
        /// Note: Due to limited retain memory in PLCs this attribute might
        /// only be supported for a limited number of subboards
        /// </summary>
        [DataMember]
        [XmlArray("SubBoards")]
        [XmlArrayItem("SubBoard")]
        public SubBoard[] SubBoards { get; set; }
    }
}
