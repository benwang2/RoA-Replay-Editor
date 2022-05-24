using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace rivals_replay_config
{
    class Character
    {
        public static Regex COLOR_INVALID = new Regex(@"[^A-F0-9]");
        public static Skins skins = new Skins();
        public static Dictionary<string, string> Characters = new Dictionary<string, string>();
        private string name;
        private Skin skin;
        private Skin taunt;
        private List<Skin> alts = new List<Skin>();
        private string[] content;
        private int port;

        static Character()
        {
            Characters.Add("002", "Zetterburn");
            Characters.Add("003", "Orcane");
            Characters.Add("004", "Wrastor");
            Characters.Add("005", "Kragg");
            Characters.Add("006", "Forsburn");
            Characters.Add("007", "Maypul");
            Characters.Add("008", "Absa");
            Characters.Add("009", "Etalus");
            Characters.Add("010", "Ori");
            Characters.Add("011", "Ranno");
            Characters.Add("012", "Clairen");
            Characters.Add("013", "Sylvanos");
            Characters.Add("014", "Elliana");
            Characters.Add("015", "Shovel Knight");
            Characters.Add("016", "Mollo");
            Characters.Add("017", "Hodan");
            Characters.Add("018", "Pomme");
            Characters.Add("019", "Olympia");
            Characters.Add("020", "Sandbert");
        }


        public Character(string characterId, string skin, string taunt, string customColor)
       { 
            Characters.TryGetValue(characterId, out name);

            this.skin = new Skin(this, skin);
            this.taunt = new Skin(this, taunt);
        }

        public Character(string[] content, int port)
        {
            this.content = content;
            this.port = port;

            Characters.TryGetValue(getCharacterId(), out name);
            skin = new Skin(this, content[port].Substring(42, 2));
            taunt = new Skin(this, content[port].Substring(44, 2));

            var charSpecific = skins.getSpecificSkins(name);
            foreach (string id in Skin.defaultSkins.Keys)
                alts.Add(new Skin(this, id));

            foreach (string id in charSpecific.Keys)
                alts.Add(new Skin(this, id));
        }

        public string getPort() => port.ToString();
        public string getName() => name;
        public string getCharacterId() => content[port].Substring(39, 3);
        public string getCustomColor() => content[port].Substring(54, 50);
        public bool setCustomColor(string color)
        {
            color = color.Replace("-", string.Empty);

            if (color.TrimEnd().Length != getCustomColor().TrimEnd().Length) return false;
            if (COLOR_INVALID.Match(color) != Match.Empty) return false;

            content[port] = content[port].Substring(0, 54) + color.PadRight(50) + content[port].Substring(104);
            return true;
        }
        public Skin getSkin() => skin;
        public Skin getTaunt() => taunt;

        public void setSkinId(string id) => content[port] = content[port].Substring(0, 42) + id + content[port].Substring(44);
        public bool setSkin(string name)
        {
            string id = (from skin in alts where skin.getName() == name select skin.getId()).First();
            if (id == null) return false;

            skin = new Skin(this, id);
            setSkinId(id);
            return true;
        }


        public void setTauntId(string id) => content[port] = content[port].Substring(0, 44) + id + content[port].Substring(46);
        public bool setTaunt(string name)
        {
            string id = (from skin in alts where skin.getName() == name select skin.getId()).First();
            if (id == null) return false;

            taunt = new Skin(this, id);
            setTauntId(id);
            return true;
        }

        public string[] getAlts() => (from item in alts select item.getName()).ToArray();
    }
}
