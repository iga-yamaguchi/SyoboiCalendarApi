using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SyoboiCalendarApi
{
    public static class UrlExtensions
    {
        /// <summary>
        /// https://stackoverflow.com/questions/737151/how-to-get-the-list-of-properties-of-a-class
        /// https://stackoverflow.com/questions/1402239/typedescriptor-getproperties-vs-type-getproperties
        /// </summary>
        /// <returns></returns>
        public static string ToQuery(this object obj)
        {
            var props = TypeDescriptor.GetProperties(obj, new Attribute[] { new QueryParam() });
            var queries = new List<string>();

            foreach (PropertyDescriptor prop in props)
            {
                //var key = prop.Name.ToKebabCase();
                var key = prop.Name.ToKebabCase();
                var value = ConvertToQuery(prop.GetValue(obj));
                queries.Add($"{key}={value}");
            }

            return string.Join('&', queries);
        }

        private static string GetQueryKey(object obj, string name)
        {
            var key = Attribute.GetCustomAttributes(
                          obj.GetType().GetProperty(name),
                          typeof(QueryParam));
            return key.ToString();
        }

        static Type boolType = typeof(bool);
        static Type intType = typeof(int);
        static Type strType = typeof(string);
        static Type dateTimeType = typeof(DateTime);

        /// <summary>
        /// クエリパラメータ用に型によって値を変換します。
        /// </summary>
        /// <param name="obj">変換対象</param>
        /// <returns>クエリパラメータ用文字列</returns>
        private static string ConvertToQuery(object obj)
        {

            var type = obj.GetType();

            if (type == boolType)
            {
                return (bool)obj ? "1" : "0";
            }

            if (type == dateTimeType)
            {
                var dateTime = (DateTime)obj;
                return dateTime.ToString("yyyy-MM-dd");
            }

            return obj.ToString();
        }
    }
}
