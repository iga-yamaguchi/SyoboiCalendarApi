using System;
using System.Collections.Generic;
using System.Text;

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
        public string UserId { get; set; }

        /// <summary>
        /// trueならクッキーのチャンネルフィルタを使用。
        /// </summary>
        public bool UseCookie { get; set; }

        /// <summary>
        /// 取得開始する日付。
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// 取得する日数。
        /// </summary>
        public int Days { get; set; }

        public string ToQuery()
        {
            return string.Empty;
        }
    }
}
