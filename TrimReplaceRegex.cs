using System;
using System.Text.RegularExpressions;

class program 
{    
//TrimReplaceRegex
    static void Main()
    {        
		// for .cs --  
		
		// Response.Write(Regex.Replace("....''' jitendra singh sengar  9589391358 ****'".Trim('*', '.', '\'', ' ').Replace("\'", ""), @"\d", ""));  
		
		Console.WriteLine(Regex.Replace("....''' jitendra singh sengar  9589391358 ****'".Trim('*', '.', '\'', ' ').Replace("\'", ""), @"\d", ""));
		
    }
}

//Output
//jitendra singh sengar