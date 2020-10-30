using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft_test
{
    class TestSettings
    {
        public static string Host_prefix = "https://docs.microsoft.com/ru-ru/";
        public static string[] REST_GET_url = new string[2]{ "https://docs.microsoft.com/api/search?search=LINQ&locale=ru-ru&scoringprofile=search_for_en_us_a_b_test&facet=category&%24top=25&%24skip=0&expandScope=true",
            "https://docs.microsoft.com/api/search?search=LINQ&locale=ru-ru&scoringprofile=search_for_en_us_a_b_test&facet=category&%24top=25&%24skip=25&expandScope=true"};
            
    }
}