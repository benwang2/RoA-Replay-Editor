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
            Label characterLabel = Controls.Find($"p{port + 1}Character", true).FirstOrDefault() as Label;

            ComboBox skins = Controls.Find($"p{port + 1}Skin", true).FirstOrDefault() as ComboBox;
            ComboBox taunts = Controls.Find($"p{port + 1}Taunt", true).FirstOrDefault() as ComboBox;

            username.Text = player.getUsername().TrimEnd();
            profile.Text = player.getProfile().TrimEnd();
            customColor.Text = character.getCustomColor().TrimEnd();
            characterLabel.Text = character.getName();
            

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
            titleInput.Text = replay.getTitle().TrimEnd();
            descriptionInput.Text = replay.getDescription().TrimEnd();
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

            for (int i = 0; i < 4; i++)
                if (replay.getPlayer(i) != null)
                    loadPortData(replay, i);
        }

        private bool savePlayerData(int port)
        {
            Player player = replay.getPlayer(port);
            Character character = player.getCharacter();

            TextBox username = Controls.Find($"p{port + 1}Username", true).FirstOrDefault() as TextBox;
            TextBox profile = Controls.Find($"p{port + 1}Profile", true).FirstOrDefault() as TextBox;
            TextBox customColor = Controls.Find($"p{port + 1}Color", true).FirstOrDefault() as TextBox;

            ComboBox skins = Controls.Find($"p{port + 1}Skin", true).FirstOrDefault() as ComboBox;
            ComboBox taunts = Controls.Find($"p{port + 1}Taunt", true).FirstOrDefault() as ComboBox;

            player.setUsername(username.Text);
            player.setProfile(profile.Text);
            character.setSkin(skins.SelectedItem.ToString());
            character.setTaunt(taunts.SelectedItem.ToString());

            if (!character.setCustomColor(customColor.Text))
            {
                if (character.getCustomColor().TrimEnd().Length != customColor.Text.TrimEnd().Length)
                    MessageBox.Show($"Length of custom color must be identical to original length. (Player {port + 1})", "Error - Invalid custom color");
                else
                    MessageBox.Show($"Custom color contains invalid characters. (Player {port + 1})", "Error - Invalid custom color");
                return false;
            }

            return true;
        }

        private bool saveReplayData()
        {
            if (replay == null)
            {
                MessageBox.Show("There is no replay to save.", "Error - No replay to save");
                return false;
            }

            replay.setTitle(titleInput.Text);
            replay.setDescription(descriptionInput.Text);
            replay.setStage(stageSkinCombo.Text);
            if (!replay.setVersion(versionInput.Text.Replace("_", string.Empty)))
            {
                if (versionInput.Text.Length != 5)
                    MessageBox.Show("Version contains invalid characters.", "Error - Invalid version.");
                else
                    MessageBox.Show("Version must be exactly 5 characters long.", "Error - Invalid version.");
                return false;
            }

            for (int i = 0; i < 4 && replay.getPlayer(i) != null; i++)
                if (!savePlayerData(i))
                    return false;

            return true;
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
                else
                    MessageBox.Show("Failed to open replay file.", "Error - Invalid file");
            }
        }

        private void saveFileClick(object sender, EventArgs e)
        {
            if (!saveReplayData()) return;

            SaveFileDialog fileDialog = new SaveFileDialog();
            String path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString(), "RivalsOfAether", "replays");
            fileDialog.InitialDirectory = path;
            fileDialog.Filter = "ROA Files|*.roa";

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/benwang2/RoA-Replay-Editor");
        }
    }
}
