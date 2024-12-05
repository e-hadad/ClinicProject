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
        public IEnumerable<PatientClass> Get()
        {
            return _dataContext.ListPatient;
        }
        public PatientClass Add(PatientClass patient)
        {
            _dataContext.ListPatient.Add(patient);
            _dataContext.SaveChanges();
            return patient;
        }
    }
}
