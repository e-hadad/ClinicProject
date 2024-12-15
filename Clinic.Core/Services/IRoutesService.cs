using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Services
{
    public interface IRoutesService
    {
        public IEnumerable<RoutesClass> GetRoutes();
        public RoutesClass AddRoutes(RoutesClass routes);

    }
}
