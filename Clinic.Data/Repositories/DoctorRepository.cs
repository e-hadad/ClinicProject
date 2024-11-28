using clinic;
using Clinic.Core.Entities;
using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private DataContext _dataContext;
        public DoctorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<DoctorClass> Get()
        {
            return _dataContext.ListDoctors.ToList();
        }
        public DoctorClass Add(DoctorClass doctor)
        {
            _dataContext.ListDoctors.Add(doctor);
            return doctor;
        }

    }
}
