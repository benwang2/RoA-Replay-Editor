using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rivals_replay_config
{
    class Player
    {
        private string username;
        private string profile;
        private Character character;
        private bool cpu;
        private string customColor;
        private string skin;
        private string taunt;
        private string content;
        public Player(string content)
        {
            this.content = content;
            username = content.Substring(1, 32).TrimEnd();
            profile = content.Substring(33, 6).TrimEnd();
            character = new Character(content.Substring(39, 3), content.Substring(42,2), content.Substring(44,2), content.Substring(54, 50));
            cpu = content.Substring(0, 1).CompareTo("H") != 0;
        }

        public string getUsername()
        {
            return username;
        }

        public bool setUsername(string value)
        {
            if (value.Length > 32) return false;
            content = content.Substring(0, 1) + value.PadRight(32) + content.Substring(33);
            return true;
        }

        public string getProfile()
        {
            return profile;
        }

        public bool setProfile(string value)
        {
            if (value.Length > 6) return false;
            content = content.Substring(0, 32) + value.PadRight(6) + content.Substring(39);
            return true;
        }

        public bool isCPU()
        {
            return cpu;
        }

        public Character getCharacter()
        {
            return character;
        }

        public string export()
        {
            return content.Substring(0, 42)
                +character.getSkin()
                +character.getTaunt()
                +content.Substring(46, 5)
                +character.getCustomColor()
                +content.Substring(104);
        }
    }
}
