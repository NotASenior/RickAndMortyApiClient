using System.Text.RegularExpressions;

namespace DataAccess.CrossCutting.Utils
{
    public static class GetPageHelper
    {
        private static readonly Regex pattern = new("page=(?<pageNumber>[0-9]+)");

        public static int ToPageNumber(this string? url)
        {
            if (string.IsNullOrEmpty(url?.Trim()))
            {
                return 0;
            }

            string pageAsString = pattern.Match(url).Groups["pageNumber"].Value;
            if (string.IsNullOrEmpty(pageAsString))
            {
                throw new ArgumentException("url");
            }

            return Convert.ToInt32(pageAsString);
        }
    }
}
