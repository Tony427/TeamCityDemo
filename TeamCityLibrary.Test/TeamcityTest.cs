using System;

namespace TeamCityLibrary.Test
{
    public  class TeamCityTest
    {
        public string Echo(string input)
        {
            return string.IsNullOrEmpty(input) ? "no inupt" : $"Echo : {input}";
        }
        // update
    }
}
