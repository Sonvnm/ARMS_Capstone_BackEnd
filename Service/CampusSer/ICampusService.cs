using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.CampusSer
{
    public interface ICampusService
    {
        Task<List<Campus>> GetCampuses();
        Task<int> CountCampus();
        Task<Campus> GetCampus(string campusId);
        Task<List<Slider>> GetSliders(string campusId);
    }
}
