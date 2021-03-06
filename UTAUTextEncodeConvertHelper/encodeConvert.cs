﻿using System.Text;

namespace UTAUTextEncodeConvertHelper
{
    static class EncodeConvert
    {
        public static string Converter(string str,Encoding encode)
        {
            if (Equals(encode, Encoding.GetEncoding("Shift_JIS")))
            {
                string strAfterConvert = Encoding.GetEncoding("gb2312").GetString(Encoding.GetEncoding("Shift_JIS").GetBytes(str));
                return strAfterConvert;
            }

            if (Equals(encode, Encoding.GetEncoding("gb2312")))
            {
                string strAfterConvert = Encoding.GetEncoding("Shift_JIS").GetString(Encoding.GetEncoding("gb2312").GetBytes(str));
                return strAfterConvert;
            }

            if (Equals(encode, Encoding.UTF8))
            {
                string strAfterConvert = Encoding.UTF8.GetString(Encoding.GetEncoding("gb2312").GetBytes(str));
                return strAfterConvert;
            }

            return "Error Unsupported Encode";
        }
    }
}
