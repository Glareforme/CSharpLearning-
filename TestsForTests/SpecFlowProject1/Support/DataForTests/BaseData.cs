using Baseline.ImTools;
using DryIoc.ImTools;
using System.Text.RegularExpressions;

namespace SpecFlowProject1.Support.DataForTests
{
    internal static class BaseData
    {
        static Regex regex = new Regex("Printed Summer Dress");
        internal const string baseUrl = "http://automationpractice.com/";
        public static string RemoveNonWords(string key)
        { 
            return Regex.Replace(key, @"\W", ""); 
        }
        public static string RemoveNonNumbers(string key)
        {
            return Regex.Replace(key, @"\D*", "");
        }
        public static string ExtractColorOnCartPage(string key)
        {
            string temp = Regex.Replace(key, @"(\S+[\s][:]\s)*[,]\s.*", "");
            return Regex.Replace(temp, @"(\S+[\s][:]\s)", "");
        }
        public static string ExtractSizeOnCartPage(string key)
        {
            return Regex.Replace(key, @".*\s", "");
        }
        public static string RemoveRedundantChars(string key)
        {
            return Regex.Match(key, @"[A-Z].*s|e").Value;
        }
        //.*[A-Z][a-z]*
        //[A-Z][a-z]*\s.*\s..[a-z]..
        //[A-Z].*s|e //[A-Z].*s|e
    }
}
