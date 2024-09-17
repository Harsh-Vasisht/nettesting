using System;

namespace OM.QSightApi.Inventory.Core.Entities
{
    public class CycleCount
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int DepartmentId { get; set; }
        public int Quantity { get; set; }
        public DateTime CountDate { get; set; }
        public int DiscrepancyTypeId { get; set; }
        public string Comments { get; set; }
    }
}