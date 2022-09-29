using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class JsonParseModel
    {
        public bool CouldParse { get; }
        public dynamic Body { get; }
        public string BodyString { get; }

        public JsonParseModel(bool correctContentType, bool couldParse, dynamic body, string bodyString)
        {
            CouldParse = couldParse;
            Body = body;
            BodyString = bodyString;
        }
    }
}
