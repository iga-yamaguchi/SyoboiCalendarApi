using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SyoboiCalendarApi
{
    /// <summary>
    /// cal_chk.php
    /// </summary>
    public class CalendarRequest
    {
        /// <summary>
        /// ユーザーID
        /// </summary>
        [QueryParam]
        public string UserId { get; set; }

        /// <summary>
        /// trueならクッキーのチャンネルフィルタを使用。
        /// </summary>
        [QueryParam]
        public bool UseCookie { get; set; }

        /// <summary>
        /// 取得開始する日付。
        /// </summary>
        [QueryParam]
        public DateTime Start { get; set; }

        /// <summary>
        /// 取得する日数。
        /// </summary>
        [QueryParam]
        public int Days { get; set; }

        /// <summary>
        /// https://stackoverflow.com/questions/737151/how-to-get-the-list-of-properties-of-a-class
        /// https://stackoverflow.com/questions/1402239/typedescriptor-getproperties-vs-type-getproperties
        /// </summary>
        /// <returns></returns>
        public string ToQuery()
        {
            var props = TypeDescriptor.GetProperties(this, new Attribute[] { new QueryParam() });
            var queries = new List<string>();

            foreach (PropertyDescriptor prop in props)
            {
                queries.Add($"{prop.Name.ToKebabCase()}={prop.GetValue(this).ToString()}");
            }

            return string.Join('&', queries);
        }
    }
}
