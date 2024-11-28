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
    public class DoctorService: IDoctorService
    {
        private IDoctorRepository _repository;
        public DoctorService(IDoctorRepository doctorRepository)
        {
            _repository = doctorRepository;
        } 
        public List<DoctorClass> GetDoctor()
        {
            return _repository.Get();
        }
        public DoctorClass AddDoctor(DoctorClass doctor)
        {

            return _repository.Add(doctor);
        }
    }
}
