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

        private void loadPlayer1Data(Player player1)
        {
            Character character = player1.getCharacter();
            p1UsernameInput.Text = player1.getUsername().TrimEnd();
            p1ProfileInput.Text = player1.getProfile().TrimEnd();
            p1Character.Text = character.getName();
            p1ColorInput.Text = character.getCustomColor().TrimEnd();

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

            loadPlayer1Data(replay.getPlayer(0));
            loadPlayer2Data(replay.getPlayer(1));
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
            replay.getPlayer(0).setUsername(p1UsernameInput.Text);
            replay.getPlayer(0).setProfile(p1ProfileInput.Text);
            replay.getPlayer(0).getCharacter().setSkin(p1Skin.SelectedItem.ToString());
            replay.getPlayer(0).getCharacter().setTaunt(p1Taunt.SelectedItem.ToString());
            //replay.getPlayer(0).getCharacter().setCustomColor(p1ColorInput.Text);

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(fileDialog.OpenFile());
                writer.Write(replay.exportReplay());
                writer.Dispose();
                writer.Close();
            }

        }
    }
}
