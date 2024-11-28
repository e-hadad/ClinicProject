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
    public class RoutesRepository:IRoutesRepository

    {
        private DataContext _dataContext;
        public RoutesRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<RoutesClass> Get()
        {
            return _dataContext.ListRoutes.ToList();
        }
        public RoutesClass Add(RoutesClass doctor)
        {
            _dataContext.ListRoutes.Add(doctor);
            return doctor;
        }
    }
}
