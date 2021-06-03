using System;
using System.Configuration;

namespace NET5ClassLibrary
{
    public class Class1
    {
        public static void GetConfiguration()
        {
            var tmp = ConfigurationManager.OpenMappedExeConfiguration(null, ConfigurationUserLevel.None);
        }
    }
}
