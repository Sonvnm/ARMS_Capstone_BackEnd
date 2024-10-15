using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public enum SubjectGroup
    {
        [Description("Toán – Vật lí – Hóa học")]
        A00,

        [Description("Toán – Vật lí – Tiếng Anh")]
        A01,

        [Description("Toán – Vật lí – Sinh học")]
        A02,

        [Description("Toán – Vật lí – Lịch sử")]
        A03,

        [Description("Toán – Vật lí – Địa lí")]
        A04,

        [Description("Toán – Hóa học – Lịch sử")]
        A05,

        [Description("Toán – Hóa học – Địa lí")]
        A06,

        [Description("Toán – Lịch sử – Địa lí")]
        A07,

        [Description("Toán – Lịch sử – Giáo dục công dân")]
        A08,

        [Description("Toán – Địa lý – Giáo dục công dân")]
        A09,

        [Description("Toán – Lý – Giáo dục công dân")]
        A10,

        [Description("Toán – Hóa – Giáo dục công dân")]
        A11,

        [Description("Toán – Khoa học tự nhiên – KH xã hội")]
        A12,

        [Description("Toán – Khoa học tự nhiên – Địa lí")]
        A14,

        [Description("Toán – KH tự nhiên – Giáo dục công dân")]
        A15,

        [Description("Toán – Khoa học tự nhiên – Ngữ văn")]
        A16,

        [Description("Toán – Vật lý – Khoa học xã hội")]
        A17,

        [Description("Toán – Hóa học – Khoa học xã hội")]
        A18,
        [Description("Toán – Hóa học – Sinh học")]
        B00,
        [Description("Toán – Sinh học – Lịch sử")]
        B01,
        [Description("Toán – Sinh học – Địa lí")]
        B02,
        [Description("Toán – Sinh học – Ngữ văn")]
        B03,
        [Description("Toán – Sinh học – Giáo dục công dân")]
        B04,
        [Description("Toán – Sinh học – Khoa học xã hội")]
        B05,
        [Description("Toán – Sinh học – Tiếng Anh")]
        B06,
        [Description("Ngữ văn – Lịch sử – Địa lí")]
        C00,

        [Description("Ngữ văn – Toán – Vật lí")]
        C01,

        [Description("Ngữ văn – Toán – Hóa học")]
        C02,

        [Description("Ngữ văn – Toán – Lịch sử")]
        C03,

        [Description("Ngữ văn – Toán – Địa lí")]
        C04,

        [Description("Ngữ văn – Vật lí – Hóa học")]
        C05,

        [Description("Ngữ văn – Vật lí – Sinh học")]
        C06,

        [Description("Ngữ văn – Vật lí – Lịch sử")]
        C07,

        [Description("Ngữ văn – Hóa học – Sinh học")]
        C08,

        [Description("Ngữ văn – Vật lí – Địa lí")]
        C09,

        [Description("Ngữ văn – Hóa học – Lịch sử")]
        C10,

        [Description("Ngữ văn – Sinh học – Lịch sử")]
        C12,

        [Description("Ngữ văn – Sinh học – Địa lí")]
        C13,

        [Description("Ngữ văn – Toán – Giáo dục công dân")]
        C14,

        [Description("Ngữ văn – Toán – Khoa học xã hội")]
        C15,

        [Description("Ngữ văn – Vật lí – Giáo dục công dân")]
        C16,

        [Description("Ngữ văn – Hóa học – Giáo dục công dân")]
        C17,

        [Description("Ngữ văn – Lịch sử – Giáo dục công dân")]
        C19,

        [Description("Ngữ văn – Địa lí – Giáo dục công dân")]
        C20,
        [Description("Ngữ văn – Toán – Tiếng Anh")]
        D01,

        [Description("Ngữ văn – Toán – Tiếng Nga")]
        D02,

        [Description("Ngữ văn – Toán – Tiếng Pháp")]
        D03,

        [Description("Ngữ văn – Toán – Tiếng Trung")]
        D04,

        [Description("Ngữ văn – Toán – Tiếng Đức")]
        D05,

        [Description("Ngữ văn – Toán – Tiếng Nhật")]
        D06,

        [Description("Toán – Hóa học – Tiếng Anh")]
        D07,

        [Description("Toán – Sinh học – Tiếng Anh")]
        D08,

        [Description("Toán – Lịch sử – Tiếng Anh")]
        D09,

        [Description("Toán – Địa lí – Tiếng Anh")]
        D10,

        [Description("Ngữ văn – Vật lí – Tiếng Anh")]
        D11,

        [Description("Ngữ văn – Hóa học – Tiếng Anh")]
        D12,

        [Description("Ngữ văn – Sinh học – Tiếng Anh")]
        D13,

        [Description("Ngữ văn – Lịch sử – Tiếng Anh")]
        D14,

        [Description("Ngữ văn – Địa lí – Tiếng Anh")]
        D15,

        [Description("Toán – Địa lí – Tiếng Đức")]
        D16,

        [Description("Toán – Địa lí – Tiếng Nga")]
        D17,

        [Description("Toán – Địa lí – Tiếng Nhật")]
        D18,

        [Description("Toán – Địa lí – Tiếng Pháp")]
        D19,

        [Description("Toán – Địa lí – Tiếng Trung")]
        D20,

        [Description("Toán – Hóa học – Tiếng Đức")]
        D21,

        [Description("Toán – Hóa học – Tiếng Nga")]
        D22,

        [Description("Toán – Hóa học – Tiếng Nhật")]
        D23,

        [Description("Toán – Hóa học – Tiếng Pháp")]
        D24,

        [Description("Toán – Hóa học – Tiếng Trung")]
        D25,

        [Description("Toán – Vật lí – Tiếng Đức")]
        D26,

        [Description("Toán – Vật lí – Tiếng Nga")]
        D27,

        [Description("Toán – Vật lí – Tiếng Nhật")]
        D28,

        [Description("Toán – Vật lí – Tiếng Pháp")]
        D29,

        [Description("Toán – Vật lí – Tiếng Trung")]
        D30,

        [Description("Toán – Sinh học – Tiếng Đức")]
        D31,

        [Description("Toán – Sinh học – Tiếng Nga")]
        D32,

        [Description("Toán – Sinh học – Tiếng Nhật")]
        D33,

        [Description("Toán – Sinh học – Tiếng Pháp")]
        D34,

        [Description("Toán – Sinh học – Tiếng Trung")]
        D35,

        [Description("Ngữ văn – Địa lí – Tiếng Đức")]
        D41,

        [Description("Ngữ văn – Địa lí – Tiếng Nga")]
        D42,

        [Description("Ngữ văn – Địa lí – Tiếng Nhật")]
        D43,

        [Description("Ngữ văn – Địa lí – Tiếng Pháp")]
        D44,

        [Description("Ngữ văn – Địa lí – Tiếng Trung")]
        D45,

        [Description("Ngữ văn – Vật lí – Tiếng Nga")]
        D52,

        [Description("Ngữ văn – Vật lí – Tiếng Pháp")]
        D54,

        [Description("Ngữ văn – Vật lí – Tiếng Trung")]
        D55,

        [Description("Ngữ văn – Lịch sử – Tiếng Đức")]
        D61,

        [Description("Ngữ văn – Lịch sử – Tiếng Nga")]
        D62,

        [Description("Ngữ văn – Lịch sử – Tiếng Nhật")]
        D63,

        [Description("Ngữ văn – Lịch sử – Tiếng Pháp")]
        D64,

        [Description("Ngữ văn – Lịch sử – Tiếng Trung")]
        D65,

        [Description("Ngữ văn – Giáo dục công dân – Tiếng Anh")]
        D66,

        [Description("Ngữ văn – Giáo dục công dân – Tiếng Nga")]
        D68,

        [Description("Ngữ Văn – Giáo dục công dân – Tiếng Nhật")]
        D69,

        [Description("Ngữ Văn – Giáo dục công dân – Tiếng Pháp")]
        D70,

        [Description("Ngữ văn – Khoa học tự nhiên – Tiếng Anh")]
        D72,

        [Description("Ngữ văn – Khoa học tự nhiên – Tiếng Đức")]
        D73,

        [Description("Ngữ văn – Khoa học tự nhiên – Tiếng Nga")]
        D74,

        [Description("Ngữ văn – Khoa học tự nhiên – Tiếng Nhật")]
        D75,

        [Description("Ngữ văn – Khoa học tự nhiên – Tiếng Pháp")]
        D76,

        [Description("Ngữ văn – Khoa học tự nhiên – Tiếng Trung")]
        D77,

        [Description("Ngữ văn – Khoa học xã hội – Tiếng Anh")]
        D78,

        [Description("Ngữ văn – Khoa học xã hội – Tiếng Đức")]
        D79,

        [Description("Ngữ văn – Khoa học xã hội – Tiếng Nga")]
        D80,

        [Description("Ngữ văn – Khoa học xã hội – Tiếng Nhật")]
        D81,

        [Description("Ngữ văn – Khoa học xã hội – Tiếng Pháp")]
        D82,

        [Description("Ngữ văn – Khoa học xã hội – Tiếng Trung")]
        D83,

        [Description("Toán – Giáo dục công dân – Tiếng Anh")]
        D84,

        [Description("Toán – Giáo dục công dân – Tiếng Đức")]
        D85,

        [Description("Toán – Giáo dục công dân – Tiếng Nga")]
        D86,

        [Description("Toán – Giáo dục công dân – Tiếng Pháp")]
        D87,

        [Description("Toán – Giáo dục công dân – Tiếng Nhật")]
        D88,

        [Description("Toán – Khoa học tự nhiên – Tiếng Anh")]
        D90,

        [Description("Toán – Khoa học tự nhiên – Tiếng Pháp")]
        D91,

        [Description("Toán – Khoa học tự nhiên – Tiếng Đức")]
        D92,

        [Description("Toán – Khoa học tự nhiên – Tiếng Nga")]
        D93,

        [Description("Toán – Khoa học tự nhiên – Tiếng Nhật")]
        D94,

        [Description("Toán – Khoa học tự nhiên – Tiếng Trung")]
        D95,

        [Description("Toán – Khoa học xã hội – Tiếng Anh")]
        D96,

        [Description("Toán – Khoa học xã hội – Tiếng Pháp")]
        D97,

        [Description("Toán – Khoa học xã hội – Tiếng Đức")]
        D98,

        [Description("Toán – Khoa học xã hội – Tiếng Nga")]
        D99,
        [Description("Ngữ văn – Năng khiếu vẽ Nghệ thuật 1 – Năng khiếu vẽ Nghệ thuật 2")]
        H00,

        [Description("Toán – Ngữ văn – Vẽ")]
        H01,

        [Description("Toán – Vẽ Hình họa mỹ thuật – Vẽ trang trí màu")]
        H02,

        [Description("Toán – Khoa học tự nhiên – Vẽ Năng khiếu")]
        H03,

        [Description("Toán – Tiếng Anh – Vẽ Năng khiếu")]
        H04,

        [Description("Ngữ văn – Khoa học xã hội – Vẽ Năng khiếu")]
        H05,

        [Description("Ngữ văn – Tiếng Anh – Vẽ mỹ thuật")]
        H06,

        [Description("Toán – Hình họa – Trang trí")]
        H07,

        [Description("Ngữ văn – Lịch sử – Vẽ mỹ thuật")]
        H08,
        [Description("Toán – Tiếng Anh – Tin học")]
        K01,
        [Description("Ngữ văn – Toán – Đọc diễn cảm – Hát")]
        M00,

        [Description("Ngữ văn – Lịch sử – Năng khiếu")]
        M01,

        [Description("Toán – Năng khiếu 1 – Năng khiếu 2")]
        M02,

        [Description("Văn – Năng khiếu 1 – Năng khiếu 2")]
        M03,

        [Description("Toán – Đọc kể diễn cảm – Hát Múa")]
        M04,

        [Description("Toán – NK Mầm non 1 (kể chuyện, đọc, diễn cảm) – NK Mầm non 2 (Hát)")]
        M09,

        [Description("Toán – Tiếng Anh – NK1")]
        M10,

        [Description("Ngữ văn – Năng khiếu báo chí – Tiếng Anh")]
        M11,

        [Description("Toán – Sinh học – Năng khiếu")]
        M13,

        [Description("Ngữ văn – Năng khiếu báo chí – Toán")]
        M14,

        [Description("Ngữ văn – Năng khiếu báo chí – Tiếng Anh")]
        M15,

        [Description("Ngữ văn – Năng khiếu báo chí – Vật lí")]
        M16,

        [Description("Ngữ văn – Năng khiếu báo chí – Lịch sử")]
        M17,

        [Description("Ngữ văn – Năng khiếu Ảnh báo chí – Toán")]
        M18,

        [Description("Ngữ văn – Năng khiếu Ảnh báo chí – Tiếng Anh")]
        M19,

        [Description("Ngữ văn – Năng khiếu Ảnh báo chí – Vật lí")]
        M20,

        [Description("Ngữ văn – Năng khiếu Ảnh báo chí – Lịch sử")]
        M21,

        [Description("Ngữ văn – Năng khiếu quay phim truyền hình – Toán")]
        M22,

        [Description("Ngữ văn – Năng khiếu quay phim truyền hình – Tiếng Anh")]
        M23,

        [Description("Ngữ văn – Năng khiếu quay phim truyền hình – Vật lí")]
        M24,

        [Description("Ngữ văn – Năng khiếu quay phim truyền hình – Lịch sử")]
        M25,
        [Description("Ngữ văn – Năng khiếu Âm nhạc 1 – Năng khiếu Âm nhạc 2")]
        N00,

        [Description("Ngữ văn – xướng âm, biểu diễn nghệ thuật")]
        N01,

        [Description("Ngữ văn – Ký xướng âm – Hát hoặc biểu diễn nhạc cụ")]
        N02,

        [Description("Ngữ văn – Ghi âm-xướng âm, chuyên môn")]
        N03,

        [Description("Ngữ Văn – Năng khiếu thuyết trình – Năng khiếu")]
        N04,

        [Description("Ngữ Văn – Xây dựng kịch bản sự kiện – Năng khiếu")]
        N05,

        [Description("Ngữ văn – Ghi âm, xướng âm – Chuyên môn")]
        N06,

        [Description("Ngữ văn – Ghi âm, xướng âm – Chuyên môn")]
        N07,

        [Description("Ngữ văn – Hòa thanh – Phát triển chủ đề và phổ thơ")]
        N08,

        [Description("Ngữ văn – Hòa thanh – Bốc thăm đề, chỉ huy tại chỗ")]
        N09,
        [Description("Ngữ văn – Lịch sử – Năng khiếu báo chí")]
        R00,

        [Description("Ngữ văn – Địa lý – Năng khiếu Biểu diễn nghệ thuật")]
        R01,

        [Description("Ngữ văn – Toán – Năng khiếu Biểu diễn nghệ thuật")]
        R02,

        [Description("Ngữ văn – Tiếng Anh – Năng khiếu Biểu diễn nghệ thuật")]
        R03,

        [Description("Ngữ văn – Năng khiếu Biểu diễn nghệ thuật – Năng khiếu Kiến thức văn hóa – xã hội – nghệ thuật")]
        R04,

        [Description("Ngữ văn – Tiếng Anh – Năng khiếu kiến thức truyền thông")]
        R05,
        [Description("Ngữ văn – Năng khiếu SKĐA 1 – Năng khiếu SKĐA 2")]
        S00,

        [Description("Toán – Năng khiếu 1 – Năng khiếu 2")]
        S01,
        [Description("Toán – Sinh học – Năng khiếu TDTT")]
        T00,

        [Description("Toán – Ngữ văn – Năng khiếu TDTT")]
        T01,

        [Description("Ngữ văn – Sinh – Năng khiếu TDTT")]
        T02,

        [Description("Ngữ văn – Địa – Năng khiếu TDTT")]
        T03,

        [Description("Toán – Lý – Năng khiếu TDTT")]
        T04,

        [Description("Ngữ văn – Giáo dục công dân – Năng khiếu")]
        T05,
        [Description("Toán – Vật lí – Vẽ Hình họa mỹ thuật")]
        V00,

        [Description("Toán – Ngữ văn – Vẽ Hình họa mỹ thuật")]
        V01,

        [Description("Vẽ mỹ thuật – Toán – Tiếng Anh")]
        V02,

        [Description("Vẽ mỹ thuật – Toán – Hóa")]
        V03,

        [Description("Ngữ văn – Vật lí – Vẽ mỹ thuật")]
        V05,

        [Description("Toán – Địa lí – Vẽ mỹ thuật")]
        V06,

        [Description("Toán – tiếng Đức – Vẽ mỹ thuật")]
        V07,

        [Description("Toán – tiếng Nga – Vẽ mỹ thuật")]
        V08,

        [Description("Toán – tiếng Nhật – Vẽ mỹ thuật")]
        V09,

        [Description("Toán – tiếng Pháp – Vẽ mỹ thuật")]
        V10,

        [Description("Toán – tiếng Trung – Vẽ mỹ thuật")]
        V11
    }
}
