using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Assignment3.Models.Extensions
{
    public static class Extension
    {
        public static int ToAge(this DateTime birthDay)
        {
            int years = DateTime.Now.Year - birthDay.Year;

            if ((birthDay.Month > DateTime.Now.Month) || (birthDay.Month == DateTime.Now.Month && birthDay.Day > DateTime.Now.Day))
                years--;

            return years;
        }

        public static string ToDigitsOnly(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return value;
            }
            var Digits = new string(value.Where(char.IsDigit).ToArray());
            return Digits;
        }
    }
}