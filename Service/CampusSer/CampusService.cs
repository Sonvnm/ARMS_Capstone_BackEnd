using Data.ArmsContext;
using Data.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.CampusSer
{
    public class CampusService : ICampusService
    {
        private readonly CampusRepository _campusRepository;
        public CampusService(ArmsDbContext context)
        {
            _campusRepository = new CampusRepository(context);
        }

        public async Task<int> CountCampus()=> await _campusRepository.CountCampus();

        public async Task<Campus> GetCampus(string campusId)=> await _campusRepository.GetCampus(campusId);

        public async Task<List<Campus>> GetCampuses() => await _campusRepository.GetCampusesAsync();

        public async Task<List<Slider>> GetSliders(string campusId)=> await _campusRepository.GetSliders(campusId);
    }
}
