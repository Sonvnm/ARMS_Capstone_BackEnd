using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class MajorAdmissionSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public MajorAdmissionSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<MajorAdmission>().HasData(
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HME",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HGE",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HWE",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HTE", // Ensure no duplicates
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HEA",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HJA",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HKA",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HSM",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HHM",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HRM",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HBT",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HBS",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HAO",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HSO",
                    Status = true,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                },
                new MajorAdmission()
                {
                    AdmissionTimeId = 31,
                    MajorID = "HFO",
                    Status = false,
                    Target = 200,
                    TotalScore = 24,
                    TotalScoreAcademic = 24,
                    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                }
                ////Danang
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DTE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DHM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 2,
                //    MajorID = "DFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                ////CT
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CTE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CHM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 3,
                //    MajorID = "CFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                ////HCM
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "STE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SHM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 4,
                //    MajorID = "SFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                ////Thanhhoa
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TTE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "THM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 5,
                //    MajorID = "TFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},

                ////HN - 2
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HTE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HHM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 6,
                //    MajorID = "HFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                ////Danang
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DTE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DHM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 7,
                //    MajorID = "DFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                ////CT
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CTE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CHM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 8,
                //    MajorID = "CFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                ////HCM
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "STE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SHM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 9,
                //    MajorID = "SFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                ////Thanhhoa
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TTE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "THM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 10,
                //    MajorID = "TFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},

                ////HN - 3
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HTE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HHM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 11,
                //    MajorID = "HFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                ////Danang
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DTE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DHM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 12,
                //    MajorID = "DFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                ////CT
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CTE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CHM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 13,
                //    MajorID = "CFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                ////HCM
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "STE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SHM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 14,
                //    MajorID = "SFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                ////Thanhhoa
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TME",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TGE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TWE",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TTE", // Ensure no duplicates
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TEA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TJA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TKA",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TSM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "THM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TRM",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TBT",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TBS",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TAO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TSO",
                //    Status = true,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //},
                //new MajorAdmission()
                //{
                //    AdmissionInformationID = 15,
                //    MajorID = "TFO",
                //    Status = false,
                //    Target = 200,
                //    TotalScore = 24,
                //    TotalScoreAcademic = 24,
                //    SubjectGroups = new List<SubjectGroup> { SubjectGroup.A00, SubjectGroup.A01 }
                //}
            );
        }

    }
}
