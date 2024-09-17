using System;

namespace OM.QSightApi.Inventory.API.Models
{
    public class CycleCountItemInfo
    {
        public int Id { get; set; }
        public int CycleCountId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int DiscrepancyTypeId { get; set; }
        public string Comments { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}