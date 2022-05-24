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
        public static Dictionary<string, string> defaultSkins = new Dictionary<string, string>();
        public static Skins skins = new Skins();
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
            defaultSkins.Add("08", "Local Custom 1");
            defaultSkins.Add("09", "Local Custom 2");
            defaultSkins.Add("41", "Online Custom P1");
            defaultSkins.Add("42", "Online Custom P2");
            defaultSkins.Add("43", "Online Custom P3");
            defaultSkins.Add("44", "Online Custom P4");
        }

        //"Default 1", "Default 2", "Default 3", "Default 4", "Default 5", "Default 6", "Seasonal", "Custom 1", "Custom 2"

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
