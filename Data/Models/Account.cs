using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Account : IdentityUser<Guid>
    {
        public string? Fullname { get; set; }
        public bool? Gender { get; set; }
        public string? AvatarURL { get; set; }
        public string? Phone { get; set; }
        public DateTime? Dob { get; set; }
        public bool isAccountActive { get; set; }
        public string CampusId { get; set; }
        public virtual Campus Campus { get; set; }
        public string? StudentCode { get; set; }
        public string? MajorId { get; set; }
        public TypeAccount TypeAccount { get; set; }

        public Guid? SPId { get; set; }
        public virtual Major? Major { get; set; }
        public virtual StudentProfile? StudentProfile { get; set; }
        public virtual ICollection<Request>? RequestChangeMajors { get; set; }
        public virtual ICollection<RequestNotification>? RequestNotifications { get; set; }
        public virtual ICollection<StudentConsultation>? StudentConsultations { get; set; }

    }
    public enum TypeAccount
    {
        Account,
        RequestAccountInProcess,
        RequestAccountAccept,
        RequestAccountRejected
    }
}
