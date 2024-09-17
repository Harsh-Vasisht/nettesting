using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.QSightApi.Inventory.Core.Entities
{
    public class ZeroOutSchedule
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public DateTime ScheduledDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}