using System;

namespace OM.QSightApi.Inventory.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}