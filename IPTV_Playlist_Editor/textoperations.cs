using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kodi_M3U_IPTV_Editor
{
    class textoperations
    {
        public static string Between(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
    }
}
