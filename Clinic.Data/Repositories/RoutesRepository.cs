using Clinic.Core.Entities;
using clinic;
using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Data.Repositories
{
    public class RoutesRepository:IRoutesRepository

    {
        private DataContext _dataContext;
        public RoutesRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IEnumerable<RoutesClass> Get()
        {
            return _dataContext.ListRoutes.Include(r=>r.Doctor);
        }
        public RoutesClass Add(RoutesClass doctor)
        {
            _dataContext.ListRoutes.Add(doctor);
            _dataContext.SaveChanges();
            return doctor;
        }
    }
}
