using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VottModel
{
    public class Project
    {

        public bool useSecurityToken { get; set; } = false;

        public string id { get; set; }
        public string name { get; set; }
        public string securityToken { get; set; } = null;
        public string version { get; set; }
        public Connection sourceConnection { get; set; }
        public Connection targetConnection { get; set; }
        public VideoOptions videoSettings { get; set; }
        public Tag[] tags { get; set; }
        public Dictionary<string, Asset> assets { get; set; } = new Dictionary<string, Asset>();

    }
}
