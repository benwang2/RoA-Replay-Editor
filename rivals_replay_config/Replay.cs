using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rivals_replay_config
{
    class Replay
    {
        public static Regex playerPatt = new Regex(@"H(.{32})(.{6})(0\d\d)", RegexOptions.Compiled);
        public static Regex botPatt = new Regex(@"[1-9](Player [1-4].{24})(.{6})(0\d\d)", RegexOptions.Compiled);
        public static Regex VERSION_INVALID = new Regex(@"[^0-9]");

        private readonly OpenFileDialog replay;
        private String[] content;

        private Stage stage;
        private Player[] players = new Player[4];

        public Replay(OpenFileDialog replay)
        {
            this.replay = replay;
            try
            {
                StreamReader reader = new StreamReader(replay.OpenFile());
                content = reader.ReadToEnd().Split('\n');
                reader.Dispose();
                reader.Close();
            } catch (FileNotFoundException e)
            {
                throw e;
            }

            if (content != null) {
                stage = new Stage(getStageId());

                for (var (i,j)=(2,0); i < content.Length; i++)
                    if (playerPatt.IsMatch(content[i]) || botPatt.IsMatch(content[i]))
                        players[j++] = new Player(content, i);

            }
        }

        public string getTitle()
        {
            return content[0].Substring(21, 32);
        }

        public bool setTitle(string newTitle)
        {
            if (newTitle.Length > 32) return false;
            content[0] = content[0].Substring(0, 21) + newTitle.PadRight(32) + content[0].Substring(53);
            return true;
        }

        public string getDescription()
        {
            return content[0].Substring(53, 140);
        }

        public bool setDescription(string newDescription)
        {
            if (newDescription.Length > 140) return false;
            content[0] = content[0].Substring(0, 53) + newDescription.PadRight(140) + content[0].Substring(193);
            return true;
        }

        private string getStageId()
        {
            return content[1].Substring(1, 2);
        }

        public Stage getStage()
        {
            return stage;
        }

        public bool setStage(string name)
        {
            if (!stage.isAlternateOf(name)) return false;
            var id = Stage.stages.FirstOrDefault(x => x.Value == name.PadLeft(2, '0')).Key;
            content[1] = content[1].Substring(0, 1) + id.ToString() + content[1].Substring(3);
            return true;
        }

        public string getVersion()
        {
            return content[0].Substring(1, 5);
        }

        public bool setVersion(string version)
        {
            if (version.Length != 5) return false;
            if (VERSION_INVALID.Match(version) != Match.Empty) return false;
            content[0] = content[0].Substring(0, 1) + version + content[0].Substring(6);
            return true;
        }

        public Player getPlayer(int port)
        {
            return players[port];
        }

        public string exportReplay()
        {
            return String.Join("\n",content);
        }
    }
}
