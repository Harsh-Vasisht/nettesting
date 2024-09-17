using System;

namespace OM.QSightApi.Inventory.API.Models
{
    public class ZeroOutScheduleInvalid
    {
        public int Id { get; set; }
        public int ZeroOutScheduleId { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}