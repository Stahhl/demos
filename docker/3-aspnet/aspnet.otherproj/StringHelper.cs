using System;

namespace aspnet.otherproj
{
    public static class StringHelper
    {
        public static string GetDateTimeString()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}