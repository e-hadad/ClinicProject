using clinic;
using Clinic.Core.Entities;
using Clinic.Core.Repositories;
using Microsoft.EntityFrameworkCore;
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
        public IEnumerable<DoctorClass> Get()
        {
            return _dataContext.ListDoctors.Include(p=>p.Patients);
        }
        public DoctorClass Add(DoctorClass doctor)
        {
            _dataContext.ListDoctors.Add(doctor);
            _dataContext.SaveChanges();
            return doctor;
        }

    }
}
