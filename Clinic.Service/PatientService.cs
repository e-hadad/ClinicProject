using Clinic.Core.Services;
using Clinic.Core.Repositories;
using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Service
{
    public class PatientService : IPatientService
    {
        private IPatientRepository _repository;
        public PatientService(IPatientRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<PatientClass> GetPatient()
        {
            return _repository.Get();
        }
        public PatientClass AddPtient(PatientClass patient)
        {

            return _repository.Add(patient);
        }

    }
}
