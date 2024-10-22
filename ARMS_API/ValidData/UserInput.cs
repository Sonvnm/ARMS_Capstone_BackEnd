using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ARMS_API.ValidData
{
    public class UserInput
    {
        // valid email
        public bool IsValidEmail(string email)
        {
            //example@gmail.com
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
        // valid phone number
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            //+84972276578
            var phonePattern = @"^\+?\d{10,15}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }
        // valid dob
        public bool IsValidDateOfBirth(DateTime? parsedDate)
        {
            if (parsedDate < DateTime.Now && parsedDate > DateTime.Now.AddYears(-150))
            {
                return true;
            }
            return false;
        }
        // valid number CI
        public bool IsValidCCCD(string cccd)
        {
            var cccdPattern = @"^\d{12}$";
            return Regex.IsMatch(cccd, cccdPattern);
        }
        // search by keyword vn
        public string RemoveDiacritics(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            var normalizedText = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedText)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        public string NormalizeText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            return RemoveDiacritics(text).ToLower();
        }
        public bool IsValidCIDate(DateTime? CIDate)
        {
            if (!CIDate.HasValue)
            {
                return false;
            }

            DateTime minDate = new DateTime(1900, 1, 1);
            DateTime maxDate = DateTime.Now;

            return CIDate.Value >= minDate && CIDate.Value <= maxDate;
        }
    }
}
