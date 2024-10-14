using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public enum TypeofStatus
    {
        SuccessProfileRegister,//0
        ConfirmSuccessProfileRegister,//1
        SuccessProfileAdmission,//2
        ConfirmSuccessProfileAdmission,//3
        WaitingPaymentAdmission,//4
        InProcessAdmission,//5
        Done,//6
        WaitingPaymentRegisterAdmission,//7
    }
    public enum TypeofStatusForMajor
    {
        Fail,
        Pass,
        Inprocess,
        Pending
    }
    public enum TypeofRequestChangeMajor
    {
        Accept,
        Reject,
        Inprocess
    }
}
