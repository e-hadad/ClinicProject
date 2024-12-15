using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Services
{
    public interface IPatientService
    {
        public IEnumerable<PatientClass> GetPatient();
        public PatientClass AddPtient(PatientClass patient);

    }
}
