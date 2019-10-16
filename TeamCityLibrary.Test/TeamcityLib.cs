using System;

namespace TeamCityLibrary.Test
{
    public  class TeamCityLib
    {
        public string Echo(string input)
        {
            return string.IsNullOrEmpty(input) ? "no inupt" : $"Echo : {input}";
        }
        // update

        public string A()
        {
            return "A";
        }

        public string B()
        {
            return "B";
        }

        public string C()
        {
            return "C";
        }
    }
}
