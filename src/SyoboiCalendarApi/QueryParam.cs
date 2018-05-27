using System;
using System.Collections.Generic;
using System.Text;

namespace SyoboiCalendarApi
{
    [AttributeUsage(AttributeTargets.Property)]
    public class QueryParam : Attribute
    {
        private string key = string.Empty;

        public QueryParam() { }

        public QueryParam(string key)
        {
            this.key = key;
        }
    }
}
