using Data.ArmsContext;
using Data.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AdmissionInformationSer
{
    public class AdmissionInformationService : IAdmissionInformationService
    {
        private readonly AdmissionInfomationRepository _admissionInfomationRepository;
        public AdmissionInformationService(ArmsDbContext context)
        {
            _admissionInfomationRepository = new AdmissionInfomationRepository(context);
        }

        public Task Add(AdmissionInformation AdmissionInformation)
        => _admissionInfomationRepository.Add(AdmissionInformation);

        public async Task<List<AdmissionInformation>> GetAdmissionInformation(string campus)
        {
            try
            {
            var data = await _admissionInfomationRepository.GetAdmissionInformation(campus);
            return data;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<AdmissionInformation> GetAdmissionInformationById(int AdmissionInformationID)
        => _admissionInfomationRepository.GetAdmissionInformationById(AdmissionInformationID);

        public async Task<AdmissionInformation> GetAdmissionInformationByStatus(string campus)
        {
            try
            {
            var data = await _admissionInfomationRepository.GetAdmissionInformationStatusTrue(campus);
            return data;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<AdmissionInformation> GetAdmissionInformationProcess(string campus)
        {
            try
            {
                var data = await _admissionInfomationRepository.GetAdmissionInformationProcess(campus);
                return data;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateAdmissionInformation(AdmissionInformation AdmissionInformation)
        {
            try
            {
                var ValidadmissionInformation = await _admissionInfomationRepository.GetAdmissionInformationById(AdmissionInformation.AdmissionInformationID);
                ValidadmissionInformation.FeeRegister = AdmissionInformation.FeeRegister;
                ValidadmissionInformation.FeeAdmission = AdmissionInformation.FeeAdmission;
                ValidadmissionInformation.Year = AdmissionInformation.Year;
                ValidadmissionInformation.Admissions = AdmissionInformation.Admissions;
                ValidadmissionInformation.StartAdmission = AdmissionInformation.StartAdmission;
                ValidadmissionInformation.EndAdmission = AdmissionInformation.EndAdmission;
                ValidadmissionInformation.AdmissionProfileDescription = AdmissionInformation.AdmissionProfileDescription;
                await _admissionInfomationRepository.UpdateAdmissionInformation(ValidadmissionInformation);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
