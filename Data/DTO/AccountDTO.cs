using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class Account_RequestChangeMajor_DTO
    {
        public string? Fullname { get; set; }
        public string? StudentCode { get; set; }
    }
public class Account_DTO
    {
        public Guid Id { get; set; }
        public string? Fullname { get; set; }
        public bool? Gender { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string? StudentCode { get; set; }
        public bool isAccountActive { get; set; }
        public string? MajorCode { get; set; }
        public string MajorID { get; set; }
        public string? MajorName { get; set; }
        public string RoleName { get; set; }
        public string CampusId { get; set; }
        public string UserName { get; set; }
        public TypeAccount TypeAccount { get; set; }

    }
    public class Account_Major_DTO
    {
        public Guid Id { get; set; }
        public string? MajorCode { get; set; }
        public string? MajorName { get; set; }
    }
    public class CreateAccountDTO
    {
        public string UserName { get; set; }
        public string? Fullname { get; set; }
        public bool? Gender { get; set; }
        public string? Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string CampusId { get; set; }
        public string? StudentCode { get; set; }
        public string? MajorId { get; set; }
        public TypeAccount TypeAccount { get; set; }
        public string RoleName { get; set; }
        public int? SPId { get; set; }
        public string? Email { get; set; }
    }
    public class UpdateAccountDTO
    {
        public string? UserName { get; set; }
        public string? Fullname { get; set; }
        public bool? Gender { get; set; }
        public string? Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string? MajorId { get; set; }
        public TypeAccount TypeAccount { get; set; }
        public string? RoleName { get; set; }
        public bool isAccountActive { get; set; }
        public string? Email { get; set; }
    }

}
