using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rivals_replay_config
{   
    public partial class Form1 : Form
    {
        private Replay replay;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadPortData(Replay replay, int port)
        {
            Player player = replay.getPlayer(port);
            Character character = player.getCharacter();

            TextBox username = Controls.Find($"p{port + 1}Username", true).FirstOrDefault() as TextBox;
            TextBox profile = Controls.Find($"p{port + 1}Profile", true).FirstOrDefault() as TextBox;
            TextBox customColor = Controls.Find($"p{port + 1}Color", true).FirstOrDefault() as TextBox;

            ComboBox skins = Controls.Find($"p{port + 1}Skin", true).FirstOrDefault() as ComboBox;
            ComboBox taunts = Controls.Find($"p{port + 1}Taunt", true).FirstOrDefault() as ComboBox;

            username.Text = player.getUsername().TrimEnd();
            profile.Text = player.getProfile().TrimEnd();
            customColor.Text = character.getCustomColor().TrimEnd();

            skins.Items.Clear();
            taunts.Items.Clear();

            string[] alts = character.getAlts();
            for (int i = 0; i < alts.Length; i++)
            {
                skins.Items.Add(alts[i]);
                taunts.Items.Add(alts[i]);
            }

            skins.SelectedItem = character.getSkin().getName();
            taunts.SelectedItem = character.getTaunt().getName();
        }

        private void loadReplayData(Replay replay)
        {
            titleInput.Text = replay.getTitle();
            descriptionInput.Text = replay.getDescription();
            versionInput.Text = replay.getVersion();
            stageName.Text = replay.getStage().getName();
            stageSkinCombo.Items.Clear();

            String[] alternates = replay.getStage().getAlternates();
            stageSkinCombo.Enabled = alternates != null;

            if (alternates != null)
            {
                foreach (string skin in replay.getStage().getAlternates())
                    stageSkinCombo.Items.Add(skin);
                stageSkinCombo.SelectedItem = replay.getStage().getName();
            }

            for (int i = 0;
                i < 4 && replay.getPlayer(i) != null;
                loadPortData(replay, i), i++
            );
        }

        private void openFileClick(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            String path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString(),"RivalsOfAether","replays");
            fileDialog.InitialDirectory = path;
            fileDialog.Filter = "ROA Files|*.roa";
            
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try { replay = new Replay(fileDialog); }
                catch { }
                if (replay != null)
                    loadReplayData(replay);
            }
        }

        private void saveFileClick(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            String path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString(), "RivalsOfAether", "replays");
            fileDialog.InitialDirectory = path;
            fileDialog.Filter = "ROA Files|*.roa";

            replay.setTitle(titleInput.Text);
            replay.setDescription(descriptionInput.Text);
            replay.setStage(stageSkinCombo.Text);
            replay.getPlayer(0).setUsername(p1Username.Text);
            replay.getPlayer(0).setProfile(p1Profile.Text);
            replay.getPlayer(0).getCharacter().setSkin(p1Skin.SelectedItem.ToString());
            replay.getPlayer(0).getCharacter().setTaunt(p1Taunt.SelectedItem.ToString());
            replay.getPlayer(0).getCharacter().setCustomColor(p1Color.Text);

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter writer = new StreamWriter(fileDialog.OpenFile());
                    writer.Write(replay.exportReplay());
                    writer.Dispose();
                    writer.Close();
                } catch
                {
                    MessageBox.Show("File is currently being used by another process, please save to a different file.","RoA Replay Editor");
                }
            }

        }

    }
}
