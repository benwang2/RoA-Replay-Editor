using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace rivals_replay_config { 

    class Skin
    {
        public static Regex onlineCustomPatt = new Regex(@"[2-4][1-4]");
        public static Dictionary<string, string> defaultSkins = new Dictionary<string, string>(){
            {"00", "Default 1"},{"01", "Default 2 (Blue)"},{"02", "Default 3 (Red)"},
            {"03", "Default 4 (Green)"},{"04", "Default 5"},{"05", "Default 6"},
            {"06", "Seasonal"},{"08", "Local Custom 1"},{"09", "Local Custom 2"},
            {"41", "Online Custom P1"},{"42", "Online Custom P2"},{"43", "Online Custom P3"},
            {"44", "Online Custom P4"}
        };

        public static Skins skins = new Skins();
        private string name;
        private string id;

        public Skin(Character character, string id)
        {
            this.id = id;
            Dictionary<string, string> characterSpecific = skins.getSpecificSkins(character.getName());
            if (!characterSpecific.TryGetValue(id, out name))
                defaultSkins.TryGetValue(id, out name);
        }

        public string getName() { return name; }
        public string getId() { return id;  }
    }
}
