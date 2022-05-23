
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
            this.descriptionInput = new System.Windows.Forms.MaskedTextBox();
            this.titleInput = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.stageName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stageSkinCombo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.p1Taunt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p1Skin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.p1ColorInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.p1ProfileInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p1UsernameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p1Character = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.p2Character = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.p2Taunt = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.p2CharacterSkinCombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.p2ColorInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.p2ProfileInput = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.p2UsernameInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openFile.Location = new System.Drawing.Point(12, 411);
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
            this.saveFile.Location = new System.Drawing.Point(93, 411);
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
            this.label1.Location = new System.Drawing.Point(44, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
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
            this.label3.Location = new System.Drawing.Point(0, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
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
            this.tableLayoutPanel2.Controls.Add(this.versionInput, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.descriptionInput, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.titleInput, 1, 0);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 161);
            this.tableLayoutPanel2.TabIndex = 17
            // 
            // versionInput
            // 
            this.versionInput.Location = new System.Drawing.Point(79, 128);
            this.versionInput.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.versionInput.Name = "versionInput";
            this.versionInput.Size = new System.Drawing.Size(121, 20);
            this.versionInput.TabIndex = 21;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(79, 40);
            this.descriptionInput.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(121, 20);
            this.descriptionInput.TabIndex = 21;
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(79, 10);
            this.titleInput.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(121, 20);
            this.titleInput.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(23, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Version";
            // 
            // stageName
            // 
            this.stageName.AutoSize = true;
            this.stageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stageName.Location = new System.Drawing.Point(79, 70);
            this.stageName.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
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
            this.label10.Location = new System.Drawing.Point(5, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
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
            this.label8.Location = new System.Drawing.Point(34, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
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
            this.stageSkinCombo.Location = new System.Drawing.Point(79, 97);
            this.stageSkinCombo.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.stageSkinCombo.Name = "stageSkinCombo";
            this.stageSkinCombo.Size = new System.Drawing.Size(121, 21);
            this.stageSkinCombo.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.p1Taunt, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.p1Skin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.p1ColorInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.p1ProfileInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.p1UsernameInput, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 162);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // p1Taunt
            // 
            this.p1Taunt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p1Taunt.FormattingEnabled = true;
            this.p1Taunt.Location = new System.Drawing.Point(90, 131);
            this.p1Taunt.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.p1Taunt.Name = "p1Taunt";
            this.p1Taunt.Size = new System.Drawing.Size(121, 21);
            this.p1Taunt.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(45, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Taunt";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(17, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Username";
            // 
            // p1Skin
            // 
            this.p1Skin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p1Skin.FormattingEnabled = true;
            this.p1Skin.Location = new System.Drawing.Point(90, 100);
            this.p1Skin.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.p1Skin.Name = "p1Skin";
            this.p1Skin.Size = new System.Drawing.Size(121, 21);
            this.p1Skin.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Profile name";
            // 
            // p1ColorInput
            // 
            this.p1ColorInput.Location = new System.Drawing.Point(90, 70);
            this.p1ColorInput.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.p1ColorInput.Name = "p1ColorInput";
            this.p1ColorInput.Size = new System.Drawing.Size(121, 20);
            this.p1ColorInput.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(55, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Skin";
            // 
            // p1ProfileInput
            // 
            this.p1ProfileInput.Location = new System.Drawing.Point(90, 40);
            this.p1ProfileInput.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.p1ProfileInput.Name = "p1ProfileInput";
            this.p1ProfileInput.Size = new System.Drawing.Size(121, 20);
            this.p1ProfileInput.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(0, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Custom color";
            // 
            // p1UsernameInput
            // 
            this.p1UsernameInput.Location = new System.Drawing.Point(90, 10);
            this.p1UsernameInput.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.p1UsernameInput.Name = "p1UsernameInput";
            this.p1UsernameInput.Size = new System.Drawing.Size(121, 20);
            this.p1UsernameInput.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.p1Character);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(26, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 184);
            this.panel1.TabIndex = 18;
            // 
            // p1Character
            // 
            this.p1Character.AutoSize = true;
            this.p1Character.Location = new System.Drawing.Point(77, 4);
            this.p1Character.Name = "p1Character";
            this.p1Character.Size = new System.Drawing.Size(0, 13);
            this.p1Character.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.p2Character);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Location = new System.Drawing.Point(294, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 184);
            this.panel2.TabIndex = 19;
            // 
            // p2Character
            // 
            this.p2Character.AutoSize = true;
            this.p2Character.Location = new System.Drawing.Point(77, 4);
            this.p2Character.Name = "p2Character";
            this.p2Character.Size = new System.Drawing.Size(0, 13);
            this.p2Character.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Player 2";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.p2Taunt, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.p2CharacterSkinCombo, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.p2ColorInput, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.p2ProfileInput, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.p2UsernameInput, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(244, 162);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // p2Taunt
            // 
            this.p2Taunt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p2Taunt.FormattingEnabled = true;
            this.p2Taunt.Location = new System.Drawing.Point(90, 131);
            this.p2Taunt.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.p2Taunt.Name = "p2Taunt";
            this.p2Taunt.Size = new System.Drawing.Size(121, 21);
            this.p2Taunt.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(45, 131);
            this.label17.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 17);
            this.label17.TabIndex = 21;
            this.label17.Text = "Taunt";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(17, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Username";
            // 
            // p2CharacterSkinCombo
            // 
            this.p2CharacterSkinCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p2CharacterSkinCombo.FormattingEnabled = true;
            this.p2CharacterSkinCombo.Location = new System.Drawing.Point(90, 100);
            this.p2CharacterSkinCombo.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.p2CharacterSkinCombo.Name = "p2CharacterSkinCombo";
            this.p2CharacterSkinCombo.Size = new System.Drawing.Size(121, 21);
            this.p2CharacterSkinCombo.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(3, 40);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Profile name";
            // 
            // p2ColorInput
            // 
            this.p2ColorInput.Location = new System.Drawing.Point(90, 70);
            this.p2ColorInput.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.p2ColorInput.Name = "p2ColorInput";
            this.p2ColorInput.Size = new System.Drawing.Size(121, 20);
            this.p2ColorInput.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(55, 100);
            this.label15.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Skin";
            // 
            // p2ProfileInput
            // 
            this.p2ProfileInput.Location = new System.Drawing.Point(90, 40);
            this.p2ProfileInput.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.p2ProfileInput.Name = "p2ProfileInput";
            this.p2ProfileInput.Size = new System.Drawing.Size(121, 20);
            this.p2ProfileInput.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(0, 70);
            this.label16.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 17);
            this.label16.TabIndex = 12;
            this.label16.Text = "Custom color";
            // 
            // p2UsernameInput
            // 
            this.p2UsernameInput.Location = new System.Drawing.Point(90, 10);
            this.p2UsernameInput.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.p2UsernameInput.Name = "p2UsernameInput";
            this.p2UsernameInput.Size = new System.Drawing.Size(121, 20);
            this.p2UsernameInput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.openFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox p1ColorInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox p1ProfileInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p1UsernameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox p2CharacterSkinCombo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox p2ColorInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox p2ProfileInput;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox p2UsernameInput;
        private System.Windows.Forms.MaskedTextBox versionInput;
        private System.Windows.Forms.MaskedTextBox descriptionInput;
        private System.Windows.Forms.MaskedTextBox titleInput;
        private System.Windows.Forms.Label p1Character;
        private System.Windows.Forms.Label p2Character;
        private System.Windows.Forms.ComboBox p1Taunt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox p2Taunt;
        private System.Windows.Forms.Label label17;
    }
}

