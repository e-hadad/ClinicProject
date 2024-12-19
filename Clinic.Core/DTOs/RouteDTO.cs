using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.DTOs
{
    public class RouteDTO
    {
        public int IdRoutes { get; set; }
        public DateTime Date;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DoctorClass Doctor { get; set; }
        public PatientClass Patient { get; set; }
    }
}
