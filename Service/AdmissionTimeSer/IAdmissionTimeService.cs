using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Service.AdmissionTimeSer
{
    public interface IAdmissionTimeService
    {
        Task AddAdmissionTime(AdmissionTime AdmissionTime);
    }
}
