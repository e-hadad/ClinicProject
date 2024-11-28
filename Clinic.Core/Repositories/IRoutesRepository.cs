﻿using Clinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Repositories
{
    public interface IRoutesRepository
    {
        public List<RoutesClass> Get();
        public RoutesClass Add(RoutesClass doctor);
    }
}
