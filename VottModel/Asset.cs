using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VottModel
{
    public class Asset
    {
        /*
                 "84169554c4e1a7e4655077a1209bc0a7": {
            "format": "png",
            "id": "84169554c4e1a7e4655077a1209bc0a7",
            "name": "637591970475059304.png",
            "path": "file:C:/Users/Ian/Documents/Projects/Output/StfcBot/Tagging/637591970475059304.png",
            "size": {
                "width": 1820,
                "height": 859
            },
            "state": 2,
            "type": 1
        }
        */

        public string id { get; set; } = Guid.NewGuid().ToString().Replace("-", "");
        public string name { get; set; }
        public string format { get; set; }
        public string path { get; set; }
        public States state { get; set; } = States.NotVisited;
        public int type { get; set; } = 1;
        public Size size { get; set; }
    }
}
