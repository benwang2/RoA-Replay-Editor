using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rivals_replay_config { 

    class Skin
    {
        public static Dictionary<string, string> defaultSkins = new Dictionary<string, string>();
        private Skins skins;
        private Dictionary<string, string> characterSpecific;
        private string name;
        private string id;

        static Skin()
        {
            defaultSkins.Add("00", "Default 1");
            defaultSkins.Add("01", "Default 2 (Blue)");
            defaultSkins.Add("02", "Default 3 (Red)");
            defaultSkins.Add("03", "Default 4 (Green)");
            defaultSkins.Add("04", "Default 5");
            defaultSkins.Add("05", "Default 6");
            defaultSkins.Add("06", "Seasonal");
            defaultSkins.Add("21", "Custom 1");
            defaultSkins.Add("22", "Custom 2");
        }

        //"Default 1", "Default 2", "Default 3", "Default 4", "Default 5", "Default 6", "Seasonal", "Custom 1", "Custom 2"

        public Skin(Character character, string skinId)
        {
            skins = new Skins();
            characterSpecific = skins.getSpecificSkins(character.getName());

            if (!characterSpecific.TryGetValue(skinId, out name))
            {
                defaultSkins.TryGetValue(skinId, out name);
            }
            id = skinId;
        }

        public string getName() { return name; }
        public string getId() { return id;  }
    }
}
