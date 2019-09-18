using System;

namespace TeamCityLibrary.Test
{
    public static class TeamCity
    {
        static string Echo(string input)
        {
            return string.IsNullOrEmpty(input) ? "no inupt" : $"Echo : {input}";
        }
    }
}
