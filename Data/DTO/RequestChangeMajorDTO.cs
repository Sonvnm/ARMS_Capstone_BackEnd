using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class RequestChangeMajorDTO
    {
        public int RequestID { get; set; }
        public string MajorNew { get; set; }
        public string MajorOld { get; set; }
        public DateTime DateRequest { get; set; }
        public string? Reply { get; set; }
        public string Description { get; set; }
        public string FileReasonRequestChangeMajor { get; set; }
        public TypeofRequestChangeMajor Status { get; set; }
        public virtual Major_RequestChange_DTO? MajorN { get; set; }
        public virtual Major_RequestChange_DTO? MajorO { get; set; }
    }
    public class RequestWithDrawalDTO
    {
        public int RequestID { get; set; }
        public DateTime DateRequest { get; set; }
        public string Description { get; set; }
        public string? Reply { get; set; }
        public string FileReasonRequestChangeMajor { get; set; }
        public TypeofRequestChangeMajor Status { get; set; }
    }
    public class RequestWithDrawal_Student_DTO
    {
        public string Description { get; set; }
        public string FileReasonRequestChangeMajor { get; set; }
    }
    public class RequestChangeMajor_Student_DTO
    {
        public string MajorNew { get; set; }
        public string Description { get; set; }
        public string FileReasonRequestChangeMajor { get; set; }
    }
    public class Reply_Request_DTO
    {
        public string? Reply { get; set; }
        public TypeofRequestChangeMajor Status { get; set; }
    }
    public class RequestChangeMajor_SS_DTO
    {
        public int RequestID { get; set; }
        public string MajorNew { get; set; }
        public string MajorOld { get; set; }
        public DateTime DateRequest { get; set; }
        public string Description { get; set; }
        public string FileReasonRequestChangeMajor { get; set; }
        public string? Reply { get; set; }
        public TypeofRequestChangeMajor Status { get; set; }
        public virtual Major_RequestChange_DTO? MajorN { get; set; }
        public virtual Major_RequestChange_DTO? MajorO { get; set; }
        public virtual Account_RequestChangeMajor_DTO? Account { get; set; }
    }
    public class RequestWithDrawal_SS_DTO
    {
        public int RequestID { get; set; }
        public DateTime DateRequest { get; set; }
        public string Description { get; set; }
        public string FileReasonRequestChangeMajor { get; set; }
        public string? Reply { get; set; }
        public TypeofRequestChangeMajor Status { get; set; }
        public virtual Account_RequestChangeMajor_DTO? Account { get; set; }
    }
}
