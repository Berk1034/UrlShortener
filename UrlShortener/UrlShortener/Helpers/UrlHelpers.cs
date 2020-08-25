using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UrlShortener.Helpers
{
    public static class UrlHelpers
    {
        public static string AppendProtocol(string url)
        {
            if (!Regex.IsMatch(url, @"^http(s)?:\/\/", RegexOptions.IgnoreCase))
            {
                return "https://" + url;
            }

            return url;
        }

        public static string ShortenUrl(string url)
        {
            int shiftedLength = url.Length >> 1;
            byte[] data = Encoding.Unicode.GetBytes(url);
            string base64EncodedUrl = Convert.ToBase64String(data);

            StringBuilder shortenedUrl = new StringBuilder();
            shortenedUrl.Append(base64EncodedUrl[^1]);

            for (int i = 0; i < base64EncodedUrl.Length; i += shiftedLength)
            {
                shortenedUrl.Append(base64EncodedUrl[(i + 1)..(i + 2)]);
            }

            return "https://short.ly/" + shortenedUrl.ToString();
        }
    }
}
