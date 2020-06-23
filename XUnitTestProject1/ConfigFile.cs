using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _UnitTests
{
    /// <summary>
    ///  You need a config.json file contianing the following fields/vales
    /// </summary>
    public class ConfigFile
    {
        public string username { get; set; }
        public string password { get; set; }
        public string clientid { get; set; }
        public string secret { get; set; }
        public string dbConn { get; set; }
    }
}
