using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.LocationSer
{
    public interface ILocationService
    {
        Task<string> GetFullAddress(string provinceCode, string districtCode, string wardCode, string specificAddress);
    }
}
