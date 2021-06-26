using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VottModel
{
    public class AssetFile
    {
        /*
         {
    "asset": {
        "format": "png",
        "id": "0c2b697e26a98d6fbfc7aebbf52f88fc",
        "name": "637592014824033447.png",
        "path": "file:C:/Users/Ian/Documents/Projects/Output/StfcBot/Tagging/637592014824033447.png",
        "size": {
            "width": 1496,
            "height": 859
        },
        "state": 2,
        "type": 1
    },
    "regions": [*/
        public Asset asset { get; set; }
        public List<Region> regions { get; set; } = new List<Region>();
    }
}
