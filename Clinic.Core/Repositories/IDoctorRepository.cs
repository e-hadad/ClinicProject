using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Repositories
{
    public interface IDoctorRepository
    {
        public List<DoctorClass> Get();
        public DoctorClass Add(DoctorClass doctor);
    }
}
