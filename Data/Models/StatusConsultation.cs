using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public enum StatusConsultation
    {
        Reception, // tiếp nhận chưa xử lý
        Interested, // quan tâm 
        Uninterested,// không quan tâm
        Uncontact1, // không liên lạc được lần 1
        Uncontact2,// không liên lạc được lần 2
        Uncontact3,// không liên lạc được lần 3
        CallBack// gọi lại sau
    }
}
