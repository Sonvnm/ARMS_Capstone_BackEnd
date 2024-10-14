using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeding
{
    public class SubjectSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public SubjectSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            // seed Subject
            modelBuilder.Entity<Subject>().HasData(
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HME" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HGE" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HWE" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HTE" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HEA" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HJA" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HKA" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HSM" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HHM" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HRM" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HBT" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HBS" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HAO" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HSO" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "HFO" },

                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HME" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HGE" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HWE" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HTE" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HEA" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HJA" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HKA" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HSM" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HHM" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HRM" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HBT" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HBS" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HAO" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HSO" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HFO" },

                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HGE" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HWE" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HTE" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HEA" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HME" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HJA" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HKA" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HSM" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HHM" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HRM" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HBT" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HBS" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HAO" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HSO" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HFO" },

                        new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HME" },
                        new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HEA" },
                        new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HSM" },
                        new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HHM" },
                        new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HRM" },
                        new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "HAO" },

                        new Subject() { SubjectCode = "MAE101", SubjectName = "Toán rời rạc", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "HME" },
                        new Subject() { SubjectCode = "MAE101", SubjectName = "Toán rời rạc", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "HGE" },
                        new Subject() { SubjectCode = "MAE101", SubjectName = "Toán rời rạc", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "HWE" },
                        new Subject() { SubjectCode = "MAE101", SubjectName = "Toán rời rạc", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "HTE" },

                        new Subject() { SubjectCode = "PRF101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "HME" },
                        new Subject() { SubjectCode = "PRF101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "HGE" },
                        new Subject() { SubjectCode = "PRF101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "HWE" },
                        new Subject() { SubjectCode = "PRF101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "HTE" },

                        new Subject() { SubjectCode = "MAD101", SubjectName = "Toán cho ngành kỹ thuật", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 2, MajorID = "HME" },
                        new Subject() { SubjectCode = "MAD101", SubjectName = "Toán cho ngành kỹ thuật", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 2, MajorID = "HGE" },
                        new Subject() { SubjectCode = "MAD101", SubjectName = "Toán cho ngành kỹ thuật", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 2, MajorID = "HWE" },
                        new Subject() { SubjectCode = "MAD101", SubjectName = "Toán cho ngành kỹ thuật", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 2, MajorID = "HTE" },

                        new Subject() { SubjectCode = "DBI101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 3, MajorID = "HME" },
                        new Subject() { SubjectCode = "DBI101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 3, MajorID = "HGE" },
                        new Subject() { SubjectCode = "DBI101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 3, MajorID = "HWE" },
                        new Subject() { SubjectCode = "DBI101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 3, MajorID = "HTE" },

                        // HCM
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SME" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SGE" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SWE" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "STE" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SEA" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SJA" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SKA" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SSM" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SHM" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SRM" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SBT" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SBS" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SAO" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SSO" },
                        new Subject() { SubjectCode = "GDQP", SubjectName = "Giáo dục quốc phòng", StudyTime = "1 tháng", NumberOfCredits = 0, SemesterNumber = 0, MajorID = "SFO" },

                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SME" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SGE" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SWE" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "STE" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SEA" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SJA" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SKA" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SSM" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SHM" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SRM" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SBT" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SBS" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SAO" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SSO" },
                        new Subject() { SubjectCode = "ENG101", SubjectName = "Tiếng anh 1", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SFO" },

                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SGE" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SWE" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "STE" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SEA" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SME" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SJA" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SKA" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SSM" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SHM" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SRM" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SBT" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SBS" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SAO" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SSO" },
                        new Subject() { SubjectCode = "ENG102", SubjectName = "Tiếng anh 2", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SFO" },

                        new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SME" },
                        new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SEA" },
                        new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SSM" },
                        new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SHM" },
                        new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SRM" },
                        new Subject() { SubjectCode = "ENG103", SubjectName = "Tiếng anh 3", StudyTime = "2 tháng", NumberOfCredits = 3, SemesterNumber = 0, MajorID = "SAO" },

                        new Subject() { SubjectCode = "MAE101", SubjectName = "Toán rời rạc", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "SME" },
                        new Subject() { SubjectCode = "MAE101", SubjectName = "Toán rời rạc", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "SGE" },
                        new Subject() { SubjectCode = "MAE101", SubjectName = "Toán rời rạc", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "SWE" },
                        new Subject() { SubjectCode = "MAE101", SubjectName = "Toán rời rạc", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "STE" },

                        new Subject() { SubjectCode = "PRF101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "SME" },
                        new Subject() { SubjectCode = "PRF101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "SGE" },
                        new Subject() { SubjectCode = "PRF101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "SWE" },
                        new Subject() { SubjectCode = "PRF101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 1, MajorID = "STE" },

                        new Subject() { SubjectCode = "MAD101", SubjectName = "Toán cho ngành kỹ thuật", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 2, MajorID = "SME" },
                        new Subject() { SubjectCode = "MAD101", SubjectName = "Toán cho ngành kỹ thuật", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 2, MajorID = "SGE" },
                        new Subject() { SubjectCode = "MAD101", SubjectName = "Toán cho ngành kỹ thuật", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 2, MajorID = "SWE" },
                        new Subject() { SubjectCode = "MAD101", SubjectName = "Toán cho ngành kỹ thuật", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 2, MajorID = "STE" },

                        new Subject() { SubjectCode = "DBI101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 3, MajorID = "SME" },
                        new Subject() { SubjectCode = "DBI101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 3, MajorID = "SGE" },
                        new Subject() { SubjectCode = "DBI101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 3, MajorID = "SWE" },
                        new Subject() { SubjectCode = "DBI101", SubjectName = "Cơ sở lập trình", StudyTime = "4 tháng", NumberOfCredits = 3, SemesterNumber = 3, MajorID = "STE" }
                        );
        }
    }
}
