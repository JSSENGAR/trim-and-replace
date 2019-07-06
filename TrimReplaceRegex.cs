using System;
using System.Text.RegularExpressions;


namespace TrimReplaceRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Regex.Replace("....''' jitendra singh sengar  9589391358 ****'".Trim('*', '.', '\'', ' ').Replace("\'", ""), @"\d", ""));
        }
    }    
}

