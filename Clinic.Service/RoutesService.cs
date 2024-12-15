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
    public class RoutesService: IRoutesService
    {
        private IRoutesRepository _repository;
        public RoutesService(IRoutesRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<RoutesClass> GetRoutes()
        {
            return _repository.Get();
        }
        public RoutesClass AddRoutes(RoutesClass routes)
        {

            return _repository.Add(routes);
        }
    }
}
