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
        [QueryParam("cookie")]
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
    }
}
