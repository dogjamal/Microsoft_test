using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Microsoft_test
{
    internal sealed partial class  RESTTest
    {
        public class Rootobject
        {
            public Facets facets { get; set; }
            public Result[] results { get; set; }
            public object[] spellingCorrection { get; set; }
            public bool scopeRemoved { get; set; }
            public int count { get; set; }
            public string nextLink { get; set; }
        }

        public class Facets
        {
            public Category[] category { get; set; }
        }

        public class Category
        {
            public int type { get; set; }
            public object from { get; set; }
            public object to { get; set; }
            public string value { get; set; }
            public int count { get; set; }
        }

        public class Result
        {
            public string title { get; set; }
            public string url { get; set; }
            public Displayurl displayUrl { get; set; }
            public string description { get; set; }
            public Description[] descriptions { get; set; }
            public DateTime lastUpdatedDate { get; set; }
            public object[] breadcrumbs { get; set; }
        }

        public class Displayurl
        {
            public string content { get; set; }
            public Hithighlight[] hitHighlights { get; set; }
        }

        public class Hithighlight
        {
            public int start { get; set; }
            public int length { get; set; }
        }

        public class Description
        {
            public string content { get; set; }
            public Hithighlight1[] hitHighlights { get; set; }
        }

        public class Hithighlight1
        {
            public int start { get; set; }
            public int length { get; set; }
        }


    }
}
