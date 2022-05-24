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

        //private Dictionary<String, Control> getFieldsForPort(int port)
        //{

        //}

        private void loadPortData(Replay replay, int port)
        {
            Player player = replay.getPlayer(port);

            if (player != null)
            {
                Character character = player.getCharacter();

                Controls.Find($"p{port+1}Username",true).FirstOrDefault().Text = player.getUsername().TrimEnd();
                //Controls[$"p{port+1}Profile"].Text = player.getProfile().TrimEnd();
                //Controls[$"p{port+1}Character"].Text = character.getName();
                //Controls[$"p{port+1}Color"].Text = character.getCustomColor().TrimEnd();

                //ComboBox playerSkins = (ComboBox)Controls[$"p{port+1}Skin"];
                //ComboBox playerTaunts = (ComboBox)Controls[$"p{port+1}Taunt"];

                //playerSkins.Items.Clear();
                //playerTaunts.Items.Clear();
                //foreach (string skin in character.getAlts())
                //{
                //    playerSkins.Items.Add(skin);
                //    playerTaunts.Items.Add(skin);
                //}

                //playerSkins.SelectedItem = character.getSkin().getName();
                //playerTaunts.SelectedItem = character.getTaunt().getName();
            }
        }

        private void loadPlayer1Data(Player player1)
        {
            Character character = player1.getCharacter();
            p1Username.Text = player1.getUsername().TrimEnd();
            p1Profile.Text = player1.getProfile().TrimEnd();
            p1Character.Text = character.getName();
            p1Color.Text = character.getCustomColor().TrimEnd();

            p1Skin.Items.Clear();
            p1Taunt.Items.Clear();
            foreach (string skin in player1.getCharacter().getAlts())
            {
                p1Skin.Items.Add(skin);
                p1Taunt.Items.Add(skin);
            }

            p1Skin.SelectedItem = character.getSkin().getName();
            p1Taunt.SelectedItem = character.getTaunt().getName();
        }

        private void loadPlayer2Data(Player player2)
        {

            //p2UsernameInput.Text = player2.getUsername().TrimEnd();
            //p2ProfileInput.Text = player2.getProfile().TrimEnd();
            //p2Character.Text = player2.getCharacter().getName();
            //p2ColorInput.Text = player2.getCustomColor().TrimEnd();
            //p2CharacterSkinCombo.Enabled = true;

            //p2CharacterSkinCombo.Items.Clear();
            //foreach (string skin in player2.getCharacter().getAlts())
            //    p2CharacterSkinCombo.Items.Add(skin);
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

            //loadPlayer1Data(replay.getPlayer(0));
            //loadPlayer2Data(replay.getPlayer(1));
            loadPortData(replay, 0);
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
