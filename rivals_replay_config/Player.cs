using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rivals_replay_config
{
    class Player
    {
        private Character character;
        private string[] content;
        private int port;

        public Player(string[] content, int port)
        {
            this.content = content;
            this.port = port;
            character = new Character(content, port);
        }

        public string getUsername()         => content[port].Substring(1, 32).TrimEnd();
        public bool setUsername(string value)
        {
            if (value.Length > 32) return false;
            content[port] = content[port].Substring(0, 1) + value.PadRight(32) + content[port].Substring(33);
            return true;
        }

        public string getProfile()      => content[port].Substring(33, 6).TrimEnd();
        public bool setProfile(string value)
        {
            if (value.Length > 6) return false;
            content[port] = content[port].Substring(0, 33) + value.PadRight(6) + content[port].Substring(39);
            return true;
        }

        public bool isCPU()             => content[port].Substring(0,1) != "H";
        public Character getCharacter() => character;
    }
}
