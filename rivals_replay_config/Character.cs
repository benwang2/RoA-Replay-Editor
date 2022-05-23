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
            Characters.Add(002, "Zetterburn");
            Characters.Add(003, "Orcane");
            Characters.Add(004, "Wrastor");
            Characters.Add(005, "Kragg");
            Characters.Add(006, "Forsburn");
            Characters.Add(007, "Maypul");
            Characters.Add(008, "Absa");
            Characters.Add(009, "Etalus");
            Characters.Add(010, "Ori");
            Characters.Add(011, "Ranno");
            Characters.Add(012, "Clairen");
            Characters.Add(013, "Sylvanos");
            Characters.Add(014, "Elliana");
            Characters.Add(015, "Shovel Knight");
            Characters.Add(016, "Mollo");
            Characters.Add(017, "Hodan");
            Characters.Add(018, "Pomme");
            Characters.Add(019, "Olympia");
            Characters.Add(020, "Sandbert");
        }

        public Character(string characterId, string skin, string taunt, string customColor)
       { 
            try { this.characterId = Int32.Parse(characterId); }
            catch { System.Diagnostics.Debug.WriteLine("Failed to get character id."); };
            Characters.TryGetValue(this.characterId, out name);

            this.skin = new Skin(this, skin);
            this.taunt = new Skin(this, taunt);
            this.customColor = customColor;

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
