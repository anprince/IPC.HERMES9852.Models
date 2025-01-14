﻿using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace IPC.HERMES9852.Models
{
    [XmlRoot(ElementName = "QueryWorkOrderInfo")]
    public class QueryWorkOrderInfo
    {
        /// <summary>
        /// Indicates the ID of QueryWorkOrder message.The ID must be unambiguous and e.g., can be a timestamp or a GUID.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "QueryId")]
        public string QueryId { get; set; }

        /// <summary>
        /// ID / name of this machine for identifying it in a Hermes enabled production line
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "MachineId")]
        public string MachineId { get; set; }

        /// <summary>
        /// Barcode of a magazine, required to identify the magazine
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
        /// The barcode of the PCB.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "Barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Identifies the work order for production of the PCB.
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "WorkOrderId")]
        public string WorkOrderId { get; set; }

        /// <summary>
        /// Identifies the Batch for production of the PCB within a splitted work order.  
        /// </summary>
        [DataMember]
        [XmlAttribute(AttributeName = "BatchId")]
        public string BatchId { get; set; }
    }
}
