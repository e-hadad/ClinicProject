using Clinic.Core.Entities;
using clinic;
using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public class PatientRepository: IPatientRepository
    {
        private DataContext _dataContext;
        public PatientRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<PatientClass> Get()
        {
            return _dataContext.ListPatient.ToList();
        }
        public PatientClass Add(PatientClass patient)
        {
            _dataContext.ListPatient.Add(patient);
            return patient;
        }
    }
}
