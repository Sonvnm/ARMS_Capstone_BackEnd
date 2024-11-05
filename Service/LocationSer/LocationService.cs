using Org.BouncyCastle.Bcpg.Sig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service.LocationSer
{
    public class LocationService: ILocationService
    {

        public async Task<string> GetFullAddress(string provinceCode, string districtCode, string wardCode, string specificAddress)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Lấy tên tỉnh/thành
                    var provinceResponse = await client.GetStringAsync($"https://provinces.open-api.vn/api/p/{provinceCode}");
                    var provinceData = JsonSerializer.Deserialize<LocationData>(provinceResponse);
                    var provinceName = provinceData.name;

                    // Lấy tên quận/huyện
                    var districtResponse = await client.GetStringAsync($"https://provinces.open-api.vn/api/d/{districtCode}");
                    var districtData = JsonSerializer.Deserialize<LocationData>(districtResponse);
                    var districtName = districtData.name;

                    // Lấy tên xã/phường
                    var wardResponse = await client.GetStringAsync($"https://provinces.open-api.vn/api/w/{wardCode}");
                    var wardData = JsonSerializer.Deserialize<LocationData>(wardResponse);
                    var wardName = wardData.name;

                    // Ghép địa chỉ hoàn chỉnh
                    var fullAddress = $"{specificAddress}, {wardName}, {districtName}, {provinceName}";
                    return fullAddress;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return "Lỗi khi lấy địa chỉ";
                }
            }
        }
        public class LocationData
        {
            public string name { get; set; }
        }
    }
}
