#r "Newtonsoft.Json"

using System;
using System.Net;
using Newtonsoft.Json;

public static class Utilities
{
    public static string ConvertToDateTime(string inputstring)
    {
        DateTime inputdatetime;
        DateTime.TryParse(inputstring, out inputdatetime);
        if (inputdatetime == null || inputdatetime == DateTime.MinValue)
        {
            return null;
        }
        else
        {
            return inputdatetime.ToString("yyyy-MM-ddTHH:mm:ss");
        }
    }
}