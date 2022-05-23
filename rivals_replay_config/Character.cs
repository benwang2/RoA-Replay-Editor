using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rivals_replay_config
{
    class Character
    {
        public static Skins skins = new Skins();
        public static Dictionary<int, String> Characters = new Dictionary<int, string>();
        private int characterId;
        private string name;
        private Skin skin;
        private List<Skin> alts = new List<Skin>();
        private Skin taunt;
        private string customColor;

        static Character()
        {
            Characters.Add(2, "Zetterburn");
            Characters.Add(3, "Orcane");
            Characters.Add(4, "Wrastor");
            Characters.Add(5, "Kragg");
            Characters.Add(6, "Forsburn");
            Characters.Add(7, "Maypul");
            Characters.Add(8, "Absa");
            Characters.Add(9, "Etalus");
            Characters.Add(10, "Ori");
            Characters.Add(11, "Ranno");
            Characters.Add(12, "Clairen");
            Characters.Add(13, "Sylvanos");
            Characters.Add(14, "Elliana");
            Characters.Add(15, "Shovel Knight");
            Characters.Add(16, "Mollo");
            Characters.Add(17, "Hodan");
            Characters.Add(18, "Pomme");
            Characters.Add(19, "Olympia");
            Characters.Add(20, "Sandbert");
        }

        public Character(string characterId, string skin, string taunt, string customColor)
       { 
            try { this.characterId = Int32.Parse(characterId); }
            catch { System.Diagnostics.Debug.WriteLine("Failed to get character id."); };
            this.skin = new Skin(this, skin);
            this.taunt = new Skin(this, taunt);
            this.customColor = customColor;

            Characters.TryGetValue(this.characterId, out name);
            var charSpecific = skins.getSpecificSkins(name);

            foreach (string id in Skin.defaultSkins.Keys)
                alts.Add(new Skin(this, id));

            foreach (string id in charSpecific.Keys)
                alts.Add(new Skin(this, id));
           
        }

        public string getName()
        {
            return name;
        }

        public string getCustomColor()
        {
            return customColor;
        }

        public string getSkin()
        {
            return skin.getId();
        }

        public bool setSkin(string id)
        {
            if (id.Length < 1 || id.Length > 2) return false;
            skin = new Skin(this, id);
            return true;
        }

        public string getTaunt()
        {
            return taunt.getId();
        }

        public bool setTaunt(string id)
        {
            if (id.Length < 1 || id.Length > 2) return false;
            taunt = new Skin(this, id);
            return true;
        }

        public string[] getAlts()
        {
            return (from item in alts select item.getName()).ToArray();
        }
    }
}
