using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VottModel
{
    public class Region
    {
        /*
         "id": "9sezp5fIq",
            "type": "RECTANGLE",
            "tags": [
                "Ship.InBattle"
            ],
            "boundingBox": {
                "height": 128.9200652528548,
                "width": 104.31343629188143,
                "left": 771.4144501047035,
                "top": 645.0732581681567
            },
            "points*/
        public string id { get; set; }
        public string type { get; set; } = "RECTANGLE";
        public string version { get; set; } = "2.2.0";
        public string[] tags { get; set; } = new string[0];
        public BoundingBox boundingBox { get; set; }
        public Point[] points { get; set; }
    }
}
