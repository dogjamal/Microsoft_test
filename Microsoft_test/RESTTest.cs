﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;



namespace Microsoft_test
{
    internal sealed partial class RESTTest
    {

        public bool TranslateText()
        {
         
            bool check = true;

            for (int i = 0; i < 2; i++)
            {

                WebRequest request = WebRequest.Create(TestSettings.REST_GET_url[i]);
                WebResponse response = request.GetResponse();

                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    string line;


                    if ((line = stream.ReadLine()) != null)
                    {

                        var translation = JsonConvert.DeserializeObject<Rootobject>(line);
                        for (int j = 0; j < 25; j++)
                        {
                            string c_line = translation.results[j].title;
                            check = Preference.Contains(c_line, "LINQ", StringComparison.OrdinalIgnoreCase);

                            if (check == false)
                                return false;
                        }


                    }
                    else
                        return false;
                }
            }

                return true;
        }
        
        [Test]
        public void Test_for_search_rest()
        {
            Assert.IsTrue(TranslateText());
        }
    }
}
