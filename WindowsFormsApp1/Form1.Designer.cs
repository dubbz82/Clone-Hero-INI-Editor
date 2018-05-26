namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSongLength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCharter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboguitarDifficulty = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFrets = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboBandDifficulty = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboKeysDifficulty = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboDrumsDifficulty = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboBassDifficulty = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboBassGHLDifficulty = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboGuitarGHLDifficulty = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPreviewStartTime = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaylistTrack = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAlbumTrack = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.timeCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.timeCalcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.newToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.openToolStripMenuItem.Text = "File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 99999;
            this.label1.Text = "Song Name";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(94, 57);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(332, 20);
            this.txtSongName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 100000;
            this.label2.Text = "Artist";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(94, 95);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(332, 20);
            this.txtArtist.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1000002;
            this.label4.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(94, 182);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(223, 20);
            this.txtGenre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1000003;
            this.label5.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(362, 182);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(64, 20);
            this.txtYear.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10000005;
            this.label6.Text = "Song Length";
            // 
            // txtSongLength
            // 
            this.txtSongLength.Location = new System.Drawing.Point(326, 224);
            this.txtSongLength.Name = "txtSongLength";
            this.txtSongLength.Size = new System.Drawing.Size(100, 20);
            this.txtSongLength.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 1000001;
            this.label7.Text = "Album";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(94, 137);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(332, 20);
            this.txtAlbum.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 10000006;
            this.label8.Text = "Charter";
            // 
            // txtCharter
            // 
            this.txtCharter.Location = new System.Drawing.Point(94, 268);
            this.txtCharter.Name = "txtCharter";
            this.txtCharter.Size = new System.Drawing.Size(332, 20);
            this.txtCharter.TabIndex = 15;
            this.txtCharter.TextChanged += new System.EventHandler(this.txtCharter_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 99999999;
            this.label9.Text = "Guitar";
            // 
            // cboguitarDifficulty
            // 
            this.cboguitarDifficulty.FormattingEnabled = true;
            this.cboguitarDifficulty.Location = new System.Drawing.Point(171, 19);
            this.cboguitarDifficulty.Name = "cboguitarDifficulty";
            this.cboguitarDifficulty.Size = new System.Drawing.Size(62, 21);
            this.cboguitarDifficulty.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 10000008;
            this.label10.Text = "Frets";
            // 
            // txtFrets
            // 
            this.txtFrets.Location = new System.Drawing.Point(94, 308);
            this.txtFrets.Name = "txtFrets";
            this.txtFrets.Size = new System.Drawing.Size(332, 20);
            this.txtFrets.TabIndex = 19;
            this.txtFrets.TextChanged += new System.EventHandler(this.txtFrets_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 999999999;
            this.label11.Text = "Band";
            // 
            // cboBandDifficulty
            // 
            this.cboBandDifficulty.FormattingEnabled = true;
            this.cboBandDifficulty.Location = new System.Drawing.Point(45, 19);
            this.cboBandDifficulty.Name = "cboBandDifficulty";
            this.cboBandDifficulty.Size = new System.Drawing.Size(62, 21);
            this.cboBandDifficulty.TabIndex = 21;
            this.cboBandDifficulty.SelectedIndexChanged += new System.EventHandler(this.cboBandDifficulty_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboKeysDifficulty);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cboDrumsDifficulty);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cboBassDifficulty);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cboBandDifficulty);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboguitarDifficulty);
            this.groupBox1.Location = new System.Drawing.Point(464, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 119);
            this.groupBox1.TabIndex = 9999999;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty Settings";
            // 
            // cboKeysDifficulty
            // 
            this.cboKeysDifficulty.FormattingEnabled = true;
            this.cboKeysDifficulty.Location = new System.Drawing.Point(103, 80);
            this.cboKeysDifficulty.Name = "cboKeysDifficulty";
            this.cboKeysDifficulty.Size = new System.Drawing.Size(62, 21);
            this.cboKeysDifficulty.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(67, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 99999999;
            this.label14.Text = "Keys";
            // 
            // cboDrumsDifficulty
            // 
            this.cboDrumsDifficulty.FormattingEnabled = true;
            this.cboDrumsDifficulty.Location = new System.Drawing.Point(172, 46);
            this.cboDrumsDifficulty.Name = "cboDrumsDifficulty";
            this.cboDrumsDifficulty.Size = new System.Drawing.Size(61, 21);
            this.cboDrumsDifficulty.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(128, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 9999999;
            this.label13.Text = "Drums";
            // 
            // cboBassDifficulty
            // 
            this.cboBassDifficulty.FormattingEnabled = true;
            this.cboBassDifficulty.Location = new System.Drawing.Point(45, 47);
            this.cboBassDifficulty.Name = "cboBassDifficulty";
            this.cboBassDifficulty.Size = new System.Drawing.Size(62, 21);
            this.cboBassDifficulty.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 999999999;
            this.label12.Text = "Bass";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboBassGHLDifficulty);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cboGuitarGHLDifficulty);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(464, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 55);
            this.groupBox2.TabIndex = 999999999;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Difficulty - GHL";
            // 
            // cboBassGHLDifficulty
            // 
            this.cboBassGHLDifficulty.FormattingEnabled = true;
            this.cboBassGHLDifficulty.Location = new System.Drawing.Point(172, 16);
            this.cboBassGHLDifficulty.Name = "cboBassGHLDifficulty";
            this.cboBassGHLDifficulty.Size = new System.Drawing.Size(62, 21);
            this.cboBassGHLDifficulty.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(130, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 99999999;
            this.label16.Text = "Bass";
            // 
            // cboGuitarGHLDifficulty
            // 
            this.cboGuitarGHLDifficulty.FormattingEnabled = true;
            this.cboGuitarGHLDifficulty.Location = new System.Drawing.Point(50, 17);
            this.cboGuitarGHLDifficulty.Name = "cboGuitarGHLDifficulty";
            this.cboGuitarGHLDifficulty.Size = new System.Drawing.Size(62, 21);
            this.cboGuitarGHLDifficulty.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 9999999;
            this.label15.Text = "Guitar";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 227);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 13);
            this.label17.TabIndex = 1000004;
            this.label17.Text = "Preview Start Time (in ms)";
            // 
            // txtPreviewStartTime
            // 
            this.txtPreviewStartTime.Location = new System.Drawing.Point(148, 224);
            this.txtPreviewStartTime.Name = "txtPreviewStartTime";
            this.txtPreviewStartTime.Size = new System.Drawing.Size(100, 20);
            this.txtPreviewStartTime.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(646, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(464, 274);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 9999999;
            this.label18.Text = "Icon";
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(499, 274);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(222, 20);
            this.txtIcon.TabIndex = 28;
            this.txtIcon.TextChanged += new System.EventHandler(this.txtIcon_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(461, 315);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 999999;
            this.label19.Text = "Count";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(499, 308);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(222, 20);
            this.txtCount.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1000000000;
            this.label3.Text = "Playlist Track";
            // 
            // txtPlaylistTrack
            // 
            this.txtPlaylistTrack.Location = new System.Drawing.Point(94, 374);
            this.txtPlaylistTrack.Name = "txtPlaylistTrack";
            this.txtPlaylistTrack.Size = new System.Drawing.Size(47, 20);
            this.txtPlaylistTrack.TabIndex = 1000000001;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 426);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 1000000002;
            this.label20.Text = "Album Track";
            // 
            // txtAlbumTrack
            // 
            this.txtAlbumTrack.Location = new System.Drawing.Point(92, 423);
            this.txtAlbumTrack.Name = "txtAlbumTrack";
            this.txtAlbumTrack.Size = new System.Drawing.Size(47, 20);
            this.txtAlbumTrack.TabIndex = 1000000003;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(217, 374);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 1000000004;
            this.label21.Text = "Comments";
            // 
            // txtComments
            // 
            this.txtComments.AcceptsReturn = true;
            this.txtComments.Location = new System.Drawing.Point(279, 371);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(345, 78);
            this.txtComments.TabIndex = 1000000005;
            // 
            // timeCalcToolStripMenuItem
            // 
            this.timeCalcToolStripMenuItem.Name = "timeCalcToolStripMenuItem";
            this.timeCalcToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.timeCalcToolStripMenuItem.Text = "Time Calc";
            this.timeCalcToolStripMenuItem.Click += new System.EventHandler(this.timeCalcToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 461);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtAlbumTrack);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtPlaylistTrack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPreviewStartTime);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFrets);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCharter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSongLength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Clone Hero INI Editor v 0.4.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSongLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCharter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboguitarDifficulty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFrets;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboBandDifficulty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboKeysDifficulty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboDrumsDifficulty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboBassDifficulty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboBassGHLDifficulty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboGuitarGHLDifficulty;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPreviewStartTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlaylistTrack;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtAlbumTrack;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.ToolStripMenuItem timeCalcToolStripMenuItem;
    }
}

