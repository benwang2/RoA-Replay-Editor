using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rivals_replay_config
{
    class Stage
    {
        public static Dictionary<string, string> stages = new Dictionary<string, string>();
        public static string[][] alts = new string[][]{
            new string[]{"Fire Capital", "Neo Fire Capital" },
            new string[]{"Air Armada", "Diamond Grove" },
            new string[]{"The Rock Wall", "The CEO Ring", "The ROA Ring"},
            new string[]{"Merchant Port", "The Swampy Estuary" },
            new string[]{"Treetop Lodge", "Highdive Hideaway" },
            new string[]{"Blazing Hideout", "Neo Blazing Rail" },
            new string[]{"Tower of Heaven", "Aether High", "The Tutorial Grid X" },
            new string[]{"Aethereal Gates", "Frozen Gates" },
            new string[]{"The Endless Abyss", "The Tutorial Grid"},
            new string[]{"The Forest Floor B", "Crystal Oasis" },
            new string[]{"Julesvale B", "Neo Julesvale" },
            new string[]{"Troupple Pond B", "Pridemoor Keep"}
        };

        static Stage()
        {
            stages.Add("00", "Menu");
            stages.Add("01", "Treetop Lodge");
            stages.Add("02", "Fire Capital");
            stages.Add("03", "Air Armada");
            stages.Add("04", "The Rock Wall");
            stages.Add("05", "Merchant Port");
            stages.Add("06", "Treetop Lodge B");
            stages.Add("07", "Blazing Hideout");
            stages.Add("08", "Tower of Heaven");
            stages.Add("09", "Tempest Peak");
            stages.Add("10", "Frozen Fortress");
            stages.Add("11", "Aethereal Gates");
            stages.Add("12", "The Endless Abyss");
            stages.Add("14", "The CEO Ring");
            stages.Add("15", "The Spirit Tree");
            stages.Add("16", "The Tutorial Grid X");
            stages.Add("17", "Neo Fire Capital");
            stages.Add("18", "The Swampy Estuary");
            stages.Add("19", "The Forest Floor B");
            stages.Add("20", "Julesvale B");
            stages.Add("21", "Troupple Pond B");
            stages.Add("22", "Practice Room");
            stages.Add("23", "Aether High");
            stages.Add("24", "Pridemoor Keep");
            stages.Add("25", "Frozen Gates");
            stages.Add("26", "The Tutorial Grid");
            stages.Add("27", "The ROA Ring");
            stages.Add("29", "Tetherball Court");
            stages.Add("32", "Neo Blazing Rail");
            stages.Add("33", "Highdive Hideaway");
            stages.Add("34", "Neo Julesvale");
            stages.Add("35", "Crystal Oasis");
            stages.Add("36", "Diamond Grove");
        }

        private string stageId;
        public Stage(string stageId)
        {
            this.stageId = stageId;
        }

        public string[] getAlternates()
        {
            String name = getName();
            for (int i = 0; i < alts.Length; i++)
                if (alts[i].Contains(name))
                    return alts[i];

            return null;
        }

        public bool isAlternateOf(string other)
        {
            string[] alternates = getAlternates();
            if (alternates == null) return false;
            return (alternates.Contains(other));
        }

        public string getName()
        {
            string name;
            return stages.TryGetValue(this.stageId, out name) ? name : null;
        }
    }
}
