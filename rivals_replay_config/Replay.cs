﻿using System;
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

        private readonly OpenFileDialog replay;
        private string content;

        private Stage stage;
        private Player[] players = new Player[4];

        public Replay(OpenFileDialog replay)
        {
            this.replay = replay;
            try
            {
                StreamReader reader = new StreamReader(replay.OpenFile());
                content = reader.ReadToEnd();
            } catch (FileNotFoundException e)
            {
                throw e;
            }

            if (content != null) {
                stage = new Stage(getStageId());

                string[] lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Skip(2).ToArray();
                for (var (i,j)=(0,0); i < lines.Length; i++)
                    if (playerPatt.IsMatch(lines[i]) || botPatt.IsMatch(lines[i]))
                        players[j++] = new Player(lines[i]);
            }
        }

        public string getTitle()
        {
            return content.Substring(21, 32);
        }

        public bool setTitle(string newTitle)
        {
            if (newTitle.Length > 32) return false;
            content = content.Substring(0, 21) + newTitle.PadRight(32) + content.Substring(53);
            return true;
        }

        public string getDescription()
        {
            return content.Substring(53, 140);
        }

        public bool setDescription(string newDescription)
        {
            if (newDescription.Length > 140) return false;
            content = content.Substring(0, 53) + newDescription.PadRight(140) + content.Substring(193);
            return true;
        }

        private string getStageId()
        {
            return content.Substring(216, 2);
        }

        private void setStageId(string id)
        {
            content = content.Substring(0, 216) + id + content.Substring(218);
        }

        public Stage getStage()
        {
            return stage;
        }

        public bool setStage(string name)
        {
            if (!stage.isAlternateOf(name)) return false;
            var id = Stage.stages.FirstOrDefault(x => x.Value == name.PadLeft(2, '0')).Key
            setStageId(id.ToString());
            return true;
        }

        public string getVersion()
        {
            return content.Substring(1, 5);
        }

        public bool setVersion(string version)
        {
            if (version.Length != 5) return false;
            content = content.Substring(0, 1) + version + content.Substring(6);
            return true;
        }

        public Player getPlayer(int port)
        {
            return players[port];
        }

        public string exportReplay()
        {
            string[] lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            
            return content;
        }
    }
}