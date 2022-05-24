
using System.Windows;

namespace rivals_replay_config
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.versionInput = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.stageName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stageSkinCombo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.p1Taunt = new System.Windows.Forms.ComboBox();
            this.p1Skin = new System.Windows.Forms.ComboBox();
            this.p1Color = new System.Windows.Forms.TextBox();
            this.p1Profile = new System.Windows.Forms.TextBox();
            this.p1Character = new System.Windows.Forms.Label();
            this.p1Username = new System.Windows.Forms.TextBox();
            this.playerTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.p2Taunt = new System.Windows.Forms.ComboBox();
            this.p2Skin = new System.Windows.Forms.ComboBox();
            this.p2Color = new System.Windows.Forms.TextBox();
            this.p2Profile = new System.Windows.Forms.TextBox();
            this.p2Character = new System.Windows.Forms.Label();
            this.p2Username = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.playerTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openFile.Location = new System.Drawing.Point(12, 369);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFileClick);
            // 
            // saveFile
            // 
            this.saveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveFile.Location = new System.Drawing.Point(93, 369);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 23);
            this.saveFile.TabIndex = 1;
            this.saveFile.Text = "Save File";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFileClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(44, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(0, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.descriptionInput, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.titleInput, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.versionInput, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.stageName, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.stageSkinCombo, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(26, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 122);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // versionInput
            // 
            this.versionInput.Location = new System.Drawing.Point(79, 96);
            this.versionInput.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.versionInput.Mask = "000000";
            this.versionInput.Name = "versionInput";
            this.versionInput.Size = new System.Drawing.Size(121, 20);
            this.versionInput.TabIndex = 21;
            this.versionInput.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(23, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Version";
            // 
            // stageName
            // 
            this.stageName.AutoSize = true;
            this.stageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stageName.Location = new System.Drawing.Point(79, 50);
            this.stageName.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.stageName.Name = "stageName";
            this.stageName.Size = new System.Drawing.Size(42, 17);
            this.stageName.TabIndex = 19;
            this.stageName.Text = "None";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(5, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Stage skin";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(34, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Stage";
            // 
            // stageSkinCombo
            // 
            this.stageSkinCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stageSkinCombo.Enabled = false;
            this.stageSkinCombo.FormattingEnabled = true;
            this.stageSkinCombo.Location = new System.Drawing.Point(79, 71);
            this.stageSkinCombo.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.stageSkinCombo.Name = "stageSkinCombo";
            this.stageSkinCombo.Size = new System.Drawing.Size(121, 21);
            this.stageSkinCombo.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.p1Taunt, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.p1Skin, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.p1Color, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.p1Profile, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.p1Character, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.p1Username, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 155);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(20, 2);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Character";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(17, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(3, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Profile name";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(0, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Custom color";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(45, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Taunt";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(55, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Skin";
            // 
            // p1Taunt
            // 
            this.p1Taunt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p1Taunt.FormattingEnabled = true;
            this.p1Taunt.Location = new System.Drawing.Point(90, 120);
            this.p1Taunt.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.p1Taunt.Name = "p1Taunt";
            this.p1Taunt.Size = new System.Drawing.Size(121, 21);
            this.p1Taunt.TabIndex = 21;
            // 
            // p1Skin
            // 
            this.p1Skin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p1Skin.FormattingEnabled = true;
            this.p1Skin.Location = new System.Drawing.Point(90, 95);
            this.p1Skin.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.p1Skin.Name = "p1Skin";
            this.p1Skin.Size = new System.Drawing.Size(121, 21);
            this.p1Skin.TabIndex = 15;
            // 
            // p1Color
            // 
            this.p1Color.Location = new System.Drawing.Point(90, 71);
            this.p1Color.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.p1Color.MaxLength = 50;
            this.p1Color.Name = "p1Color";
            this.p1Color.Size = new System.Drawing.Size(121, 20);
            this.p1Color.TabIndex = 13;
            // 
            // p1Profile
            // 
            this.p1Profile.Location = new System.Drawing.Point(90, 47);
            this.p1Profile.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.p1Profile.MaxLength = 6;
            this.p1Profile.Name = "p1Profile";
            this.p1Profile.Size = new System.Drawing.Size(121, 20);
            this.p1Profile.TabIndex = 10;
            // 
            // p1Character
            // 
            this.p1Character.AutoSize = true;
            this.p1Character.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.p1Character.Location = new System.Drawing.Point(90, 2);
            this.p1Character.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.p1Character.Name = "p1Character";
            this.p1Character.Size = new System.Drawing.Size(42, 17);
            this.p1Character.TabIndex = 22;
            this.p1Character.Text = "None";
            // 
            // p1Username
            // 
            this.p1Username.Location = new System.Drawing.Point(90, 23);
            this.p1Username.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.p1Username.MaxLength = 32;
            this.p1Username.Name = "p1Username";
            this.p1Username.Size = new System.Drawing.Size(121, 20);
            this.p1Username.TabIndex = 9;
            // 
            // playerTabs
            // 
            this.playerTabs.Controls.Add(this.tabPage1);
            this.playerTabs.Controls.Add(this.tabPage2);
            this.playerTabs.Controls.Add(this.tabPage3);
            this.playerTabs.Controls.Add(this.tabPage4);
            this.playerTabs.Location = new System.Drawing.Point(276, 12);
            this.playerTabs.Name = "playerTabs";
            this.playerTabs.SelectedIndex = 0;
            this.playerTabs.Size = new System.Drawing.Size(244, 171);
            this.playerTabs.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(236, 145);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(236, 145);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Player 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.p2Taunt, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.p2Skin, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.p2Color, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.p2Profile, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.p2Character, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.p2Username, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(236, 155);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Character";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(17, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Username";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(3, 47);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Profile name";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(0, 71);
            this.label15.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Custom color";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(45, 120);
            this.label16.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 17);
            this.label16.TabIndex = 20;
            this.label16.Text = "Taunt";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(55, 95);
            this.label17.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "Skin";
            // 
            // p2Taunt
            // 
            this.p2Taunt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p2Taunt.FormattingEnabled = true;
            this.p2Taunt.Location = new System.Drawing.Point(90, 120);
            this.p2Taunt.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.p2Taunt.Name = "p2Taunt";
            this.p2Taunt.Size = new System.Drawing.Size(121, 21);
            this.p2Taunt.TabIndex = 21;
            // 
            // p2Skin
            // 
            this.p2Skin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p2Skin.FormattingEnabled = true;
            this.p2Skin.Location = new System.Drawing.Point(90, 95);
            this.p2Skin.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.p2Skin.Name = "p2Skin";
            this.p2Skin.Size = new System.Drawing.Size(121, 21);
            this.p2Skin.TabIndex = 15;
            // 
            // p2Color
            // 
            this.p2Color.Location = new System.Drawing.Point(90, 71);
            this.p2Color.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.p2Color.Name = "p2Color";
            this.p2Color.Size = new System.Drawing.Size(121, 20);
            this.p2Color.TabIndex = 13;
            // 
            // p2Profile
            // 
            this.p2Profile.Location = new System.Drawing.Point(90, 47);
            this.p2Profile.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.p2Profile.Name = "p2Profile";
            this.p2Profile.Size = new System.Drawing.Size(121, 20);
            this.p2Profile.TabIndex = 10;
            // 
            // p2Character
            // 
            this.p2Character.AutoSize = true;
            this.p2Character.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.p2Character.Location = new System.Drawing.Point(90, 2);
            this.p2Character.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.p2Character.Name = "p2Character";
            this.p2Character.Size = new System.Drawing.Size(42, 17);
            this.p2Character.TabIndex = 22;
            this.p2Character.Text = "None";
            // 
            // p2Username
            // 
            this.p2Username.Location = new System.Drawing.Point(90, 23);
            this.p2Username.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.p2Username.MaxLength = 32;
            this.p2Username.Name = "p2Username";
            this.p2Username.Size = new System.Drawing.Size(121, 20);
            this.p2Username.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(236, 145);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Player 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(236, 145);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Player 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(79, 2);
            this.titleInput.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.titleInput.MaxLength = 32;
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(121, 20);
            this.titleInput.TabIndex = 21;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(79, 26);
            this.descriptionInput.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.descriptionInput.MaxLength = 140;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(121, 20);
            this.descriptionInput.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 404);
            this.Controls.Add(this.playerTabs);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.openFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Rivals Replay Editor";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.playerTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox stageSkinCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label stageName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox p1Skin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox p1Color;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox p1Profile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p1Username;
        private System.Windows.Forms.MaskedTextBox versionInput;
        private System.Windows.Forms.ComboBox p1Taunt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl playerTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label p1Character;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox p2Taunt;
        private System.Windows.Forms.ComboBox p2Skin;
        private System.Windows.Forms.TextBox p2Color;
        private System.Windows.Forms.TextBox p2Profile;
        private System.Windows.Forms.Label p2Character;
        private System.Windows.Forms.TextBox p2Username;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox descriptionInput;
    }
}

