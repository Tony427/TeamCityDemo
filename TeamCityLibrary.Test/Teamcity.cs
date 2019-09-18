using System;

namespace TeamCityLibrary.Test
{
    public static class TeamCity
    {
        static string Test(string input)
        {
            return string.IsNullOrEmpty(input) ? "no inupt" : $"Echo : {input}";
        }
    }
}
