using System;

namespace OM.QSightApi.Inventory.API.Models
{
    public class BaseProductRequest
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Barcode { get; set; }
        public string SerialNumber { get; set; }
        public string DeviceType { get; set; }
        public string DepartmentLocation { get; set; }
    }
}