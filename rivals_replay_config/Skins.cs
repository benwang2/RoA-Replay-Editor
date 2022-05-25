using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rivals_replay_config
{
    public class Skins
    {
        public static Dictionary<string, string> Zetterburn = new Dictionary<string, string>(){
            {"11","Champion"}, {"12","Excalibur"}, {"13","Abyss"},
            {"14","Alpha"}, {"15","Shine"}, {"16","Gold (plush)"},
            {"17","Lover's"}, {"18","Gold (rank)"}, {"19","Steampunk"}
        };

        public static Dictionary<string, string> Orcane = new Dictionary<string, string>(){
            {"11","Gold (plush)"}, {"12","Genesis"}, {"13","Abyss"},
            {"14","Alpha"}, {"15","Pool Party"}, {"16","Champion"},
            {"17","Steampunk"}, {"18","Gold (rank)"}
        };

        public static Dictionary<string, string> Wrastor = new Dictionary<string, string>(){
            {"11","Spangled"}, {"12","Champion"}, {"13","Abyss"},
            {"14","Alpha"}, {"15","Bradshaw"}, {"16","Collegiate"},
            {"17","Gold(Plush)"}, {"18","Gold (rank)"}
        };

        public static Dictionary<string, string> Kragg = new Dictionary<string, string>(){
            {"11","Summit"},{"12","Champion"},{"13","Abyss"},
            {"14","Alpha"},{"15","Burrito"},{"16","Gold (plush)"},
            {"18","Gold (rank)"},
        };

        public static Dictionary<string, string> Forsburn = new Dictionary<string, string>(){
            {"11","Genesis"},{"12","Heatwave"},{"13","Abyss"},
            {"14","Alpha"},{"15","Champion"},{"16","Dreamscape"},
            {"17","Lover's"},{"18","Gold (rank)"},{"19","Gold(plush)"}
        };

        public static Dictionary<string, string> Maypul = new Dictionary<string, string>(){
            {"11","Panda"},{"12","Arcade"},{"13","Abyss"},
            {"14","Alpha"},{"15","Ragnir"},{"16","Gold (plush)"},
            {"17","Champion"},{"18","Gold (rank)"},{"19","GoTE"}
        };

        public static Dictionary<string, string> Absa = new Dictionary<string, string>(){
            {"11","Twitch"},{"12","Champion"},{"13","Abyss"},
            {"14","Alpha"},{"15","Penguin"},{"16","Lover's"},
            {"17","Gold (Plush)"},{"18","Gold (rank)"}
        };

        public static Dictionary<string, string> Etalus = new Dictionary<string, string>(){
            {"11","Champion"},{"12","Gold (plush)"},{"13","Abyss"},
            {"14","Alpha"},{"15","Panda"},{"16","Genesis"},
            {"17","Pool Party"},{"18","Gold (rank)"}
        };

        public static Dictionary<string, string> Ori = new Dictionary<string, string>(){
            {"11","Infamous"},{"12","Champion Ori"},{"13","Abyss"},
            {"14","Alpha"},{"18","Gold (rank)"}
        };

        public static Dictionary<string, string> Ranno = new Dictionary<string, string>(){
            {"11","Pool Party"},{"12","Champion"},{"13","Abyss"},
            {"14","Alpha"},{"15","Tuxedo"},{"16","Gold (plush)"},
            {"17","Infamous"},{"18","Gold (rank)"}
        };

        public static Dictionary<string, string> Clairen = new Dictionary<string, string>(){
            {"11","Genesis"},{"12","Hero"},{"13","Abyss"},
            {"14","Alpha"},{"15","Arcade"},{"16","Infamous"},
            {"17","Champion"},{"18","Gold (rank)"},{"19","Gold (plush)"},
            {"20","Arizona"}
        };

        public static Dictionary<string, string> Sylvanos = new Dictionary<string, string>(){
            {"11","Genesis"},{"12","Infamous"},{"13","Abyss"},
            {"14","Alpha"},{"15","Gold (plush)"},{"16","Champion"},
            {"18","Gold (rank)"},{"19","Steampunk"}
        };

        public static Dictionary<string, string> Elliana = new Dictionary<string, string>(){
            {"11","Arcade"},{"12","Ayala"},{"13","Abyss"},
            {"14","Alpha"},{"15","Infamous"},{"16","GotE"},
            {"17","Champion"},{"18","Gold (rank)"},{"19","Gold (plush)"}
        };

        public static Dictionary<string, string> Shovel_Knight = new Dictionary<string, string>(){
            {"11","Gold (plush)"},{"12","Infamous"},{"13","Abyss"},
            {"14","Alpha"},{"15","Champion Skin"},{"18","Gold (rank)"}
        };

        public static Dictionary<string, string> Mollo = new Dictionary<string, string>();
        public static Dictionary<string, string> Hodan = new Dictionary<string, string>();
        public static Dictionary<string, string> Pomme = new Dictionary<string, string>();
        public static Dictionary<string, string> Olympia = new Dictionary<string, string>();
        public static Dictionary<string, string> Sandbert = new Dictionary<string, string>();

        public Dictionary<string, string> getSpecificSkins(String name) => name switch
        {
            "Zetterburn" => Zetterburn, "Orcane" => Orcane,
            "Wrastor" => Wrastor, 
            "Kragg" => Kragg,
            "Forsburn" => Forsburn,
            "Maypul" => Maypul,
            "Absa" => Absa,
            "Etalus" => Etalus,
            "Ori" => Ori,
            "Ranno" => Ranno,
            "Clairen" => Clairen,
            "Sylvanos" => Sylvanos,
            "Elliana" => Elliana,
            "Shovel Knight" => Shovel_Knight,
            "Mollo" => Mollo,
            "Hodan" => Hodan,
            "Pomme" => Pomme,
            "Olympia" => Olympia,
            _ => null
        };
    }
}
