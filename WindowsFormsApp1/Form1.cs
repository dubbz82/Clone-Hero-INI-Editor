using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string path;
        bool isNew;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clearData();
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "CH INI Configuration Files |*.ini";
            f.Multiselect = false;
            DialogResult r = f.ShowDialog();
            if (r == DialogResult.OK)
            {
                DialogResult b;
                b = MessageBox.Show("Would you like to back up the current file before overwriting?", "Back up file first?", MessageBoxButtons.YesNo);
                if (b == DialogResult.Yes)
                {
                    string filename = f.FileName;
                    int idx = filename.LastIndexOf("\\");
                    filename = filename.Substring(idx, filename.Length - idx);
                    filename = filename.Replace("\\", "");
                    filename = DateTime.Now.ToString() + "_" + filename;
                    filename = filename.Replace("/", "_");
                    filename = filename.Replace(":", " ");
                    System.IO.Directory.CreateDirectory(Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\\backup\\");
                    System.IO.File.Copy(f.FileName, Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\\backup\\" + filename);
                }
                path = f.FileName;
                isNew = false;
                System.IO.StreamReader file = new System.IO.StreamReader(path);

                foreach (string txtline in File.ReadLines(path))
                {
                    //chop up the output one line at a time to determine what value is selected..this will be a bit ugly..
                    //fix for lines with no space between the equal sign and the label...
                    string line = txtline;
                    if (line.Contains(" = ") == false && line.Contains("]") == false && line.Contains("]") == false && line.Length > 0 && line.StartsWith(";") == false)
                    {
                        int position = line.IndexOf("=");
                        string start = line.Substring(0, position);
                        string end = line.Replace(start, "");
                        start = start.Trim();
                        end = end.Trim();
                        end = end.Replace("=", " = ");

                        line = start + end;

                    }
                    if (line.StartsWith("artist = "))
                    {
                        txtArtist.Text = line.Replace("artist = ", "");
                    }
                    if (line.StartsWith("name = "))
                    {
                        txtSongName.Text = line.Replace("name = ", "");
                    }
                    //charter and frets are really one in the same....
                    if (line.StartsWith("charter = "))
                    {
                        txtCharter.Text = line.Replace("charter = ", "");
                    }
                    if (line.StartsWith("frets = ") && txtCharter.Text == "")
                    {
                        txtCharter.Text = line.Replace("frets = ", "");
                    }
                    if (line.StartsWith("icon = "))
                    {
                        txtIcon.Text = line.Replace("icon = ", "");
                    }
                    if (line.StartsWith("album = "))
                    {
                        txtAlbum.Text = line.Replace("album = ", "");
                    }
                    if (line.StartsWith("year = "))
                    {
                        txtYear.Text = line.Replace("year = ", "");
                    }
                    if (line.StartsWith("diff_guitar = "))
                    {
                        string tmp = line.Replace("diff_guitar = ", "");
                        switch (tmp)
                        {
                            case "-1":
                            case "0":
                            case "1":
                            case "2":
                            case "3":
                            case "4":
                            case "5":
                            case "6":
                                cboguitarDifficulty.SelectedIndex = int.Parse(tmp) + 1;
                                break;

                        }
                    }
                    if (line.StartsWith("diff_band = "))
                    {
                        string tmp = line.Replace("diff_band = ", "");
                        switch (tmp)
                        {
                            case "-1":
                            case "0":
                            case "1":
                            case "2":
                            case "3":
                            case "4":
                            case "5":
                            case "6":
                                cboBandDifficulty.SelectedIndex = int.Parse(tmp) + 1;
                                break;

                        }
                    }
                    if (line.StartsWith("diff_bass = "))
                    {
                        string tmp = line.Replace("diff_bass = ", "");
                        switch (tmp)
                        {
                            case "-1":
                            case "0":
                            case "1":
                            case "2":
                            case "3":
                            case "4":
                            case "5":
                            case "6":
                                cboBassDifficulty.SelectedIndex = int.Parse(tmp) + 1;
                                break;

                        }
                    }
                    if (line.StartsWith("diff_drums = "))
                    {
                        string tmp = line.Replace("diff_drums = ", "");
                        switch (tmp)
                        {
                            case "-1":
                            case "0":
                            case "1":
                            case "2":
                            case "3":
                            case "4":
                            case "5":
                            case "6":
                                cboDrumsDifficulty.SelectedIndex = int.Parse(tmp) + 1;
                                break;

                        }
                    }
                    if (line.StartsWith("diff_keys = "))
                    {
                        string tmp = line.Replace("diff_keys = ", "");
                        switch (tmp)
                        {
                            case "-1":
                            case "0":
                            case "1":
                            case "2":
                            case "3":
                            case "4":
                            case "5":
                            case "6":
                                cboKeysDifficulty.SelectedIndex = int.Parse(tmp) + 1;
                                break;

                        }
                    }
                    if (line.StartsWith("diff_guitarghl = "))
                    {
                        string tmp = line.Replace("diff_guitarghl = ", "");
                        switch (tmp)
                        {
                            case "-1":
                            case "0":
                            case "1":
                            case "2":
                            case "3":
                            case "4":
                            case "5":
                            case "6":
                                cboGuitarGHLDifficulty.SelectedIndex = int.Parse(tmp) + 1;
                                break;

                        }
                    }
                    if (line.StartsWith("diff_bassghl = "))
                    {
                        string tmp = line.Replace("diff_bassghl = ", "");
                        switch (tmp)
                        {
                            case "-1":
                            case "0":
                            case "1":
                            case "2":
                            case "3":
                            case "4":
                            case "5":
                            case "6":
                                cboKeysDifficulty.SelectedIndex = int.Parse(tmp) + 1;
                                break;

                        }
                    }
                    if (line.StartsWith("genre = "))
                    {
                        txtGenre.Text = line.Replace("genre = ", "");
                    }
                    if (line.StartsWith("song_length = "))
                    {

                        txtSongLength.Text = line.Replace("song_length = ", "");
                    }
                    if (line.StartsWith("preview_start_time = "))
                    {

                        txtPreviewStartTime.Text = line.Replace("preview_start_time = ", "");
                    }
                   
                    if (line.StartsWith("count = "))
                    {
                        txtCount.Text = line.Replace("count = ", "");
                    }
                    if (line.StartsWith("playlist_track ="))
                    {
                        txtPlaylistTrack.Text = line.Replace("playlist_track = ", "");
                    }
                    if (line.StartsWith("track = "))
                    {
                        txtAlbumTrack.Text = line.Replace("track = ", "");
                    }
                    if (line.StartsWith("album_track = "))
                    {
                        txtAlbumTrack.Text = line.Replace("album_track = ", "");
                    }

                    if (line.StartsWith(";"))
                    {
                        txtComments.Text = txtComments.Text + line.Replace(";", "").Trim() + Environment.NewLine;
                    }
                }


                file.Close();
                txtComments.Text = txtComments.Text.Trim();
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            isNew = true; //by default.  If a file is opened later, this will get swapped..
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Value");
            for (int i = -1; i < 7; i++)
            {
                if (i == -1)
                {
                    dt.Rows.Add("N/A", i);
                }
                else
                {
                    dt.Rows.Add(i.ToString(), i);
                }
            }

            cboBandDifficulty.DataSource = dt;
            cboBandDifficulty.DisplayMember = "Name";
            cboBandDifficulty.ValueMember = "Value";
            cboBassDifficulty.DataSource = dt;
            cboBassDifficulty.DisplayMember = "Name";
            cboBassDifficulty.ValueMember = "Value";
            cboBassGHLDifficulty.DataSource = dt;
            cboBassGHLDifficulty.DisplayMember = "Name";
            cboBassGHLDifficulty.ValueMember = "Value";
            cboDrumsDifficulty.DataSource = dt;
            cboDrumsDifficulty.DisplayMember = "Name";
            cboDrumsDifficulty.ValueMember = "Value";
            cboguitarDifficulty.DataSource = dt;
            cboguitarDifficulty.DisplayMember = "Name";
            cboguitarDifficulty.ValueMember = "Value";
            cboGuitarGHLDifficulty.DataSource = dt;
            cboGuitarGHLDifficulty.DisplayMember = "Name";
            cboGuitarGHLDifficulty.ValueMember = "Value";
            cboKeysDifficulty.DataSource = dt;
            cboKeysDifficulty.DisplayMember = "Name";
            cboKeysDifficulty.ValueMember = "Value";


        }

        private void cboBandDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string err = validate();
            if (err == "")
            {
                if (isNew == false)
                {

                    DialogResult r;
                    r = MessageBox.Show("This will overwrite the existing file", "Overwrite?", MessageBoxButtons.OKCancel);
                    if (r == DialogResult.OK)
                    {
                        writeFile(path);
                    }
                }
                else
                {
                    SaveFileDialog f = new SaveFileDialog();
                    f.AddExtension = true;
                    f.DefaultExt = ".ini";
                    f.Filter = "CH INI Configuration Files |*.ini";
                    DialogResult r;
                    r = f.ShowDialog();
                    if (r == DialogResult.OK)
                    {
                        path = f.FileName;
                        writeFile(path);
                    }
                }
            }
            else
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearData();
            isNew = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string err = validate();
            if (err == "")
            {
                SaveFileDialog f = new SaveFileDialog();
                DialogResult r;
                r = f.ShowDialog();
                f.AddExtension = true;
                f.DefaultExt = ".ini";
                f.Filter = "CH INI Configuration Files |*.ini";
                if (r == DialogResult.OK)
                {
                    path = f.FileName;
                    writeFile(path);
                }
            }
            else
            {
                MessageBox.Show(err, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void writeFile(string path)
        {

            using (System.IO.StreamWriter outputFile = new StreamWriter(path, false))
            {
                outputFile.WriteLine("[Song]");
                foreach (string str in txtComments.Text.Split('\n'))
                {
                    outputFile.WriteLine(";" + str);
                }

                outputFile.WriteLine("name = " + txtSongName.Text);
                outputFile.WriteLine("artist = " + txtArtist.Text);
                outputFile.WriteLine("album = " + txtAlbum.Text);
                outputFile.WriteLine("genre = " + txtGenre.Text);
                outputFile.WriteLine("year = " + txtYear.Text);
                outputFile.WriteLine("song_length = " + txtSongLength.Text);
                outputFile.WriteLine("count = " + txtCount.Text);

                outputFile.WriteLine("diff_band = " + cboBandDifficulty.SelectedValue);
                outputFile.WriteLine("diff_guitar = " + cboguitarDifficulty.SelectedValue);
                outputFile.WriteLine("diff_bass = " + cboBassDifficulty.SelectedValue);
                outputFile.WriteLine("diff_drums = " + cboDrumsDifficulty.SelectedValue);
                outputFile.WriteLine("diff_keys = " + cboKeysDifficulty.SelectedValue);
                outputFile.WriteLine("diff_guitarghl = " + cboGuitarGHLDifficulty.SelectedValue);
                outputFile.WriteLine("diff_bassghl = " + cboBassGHLDifficulty.SelectedValue);

                outputFile.WriteLine("preview_start_time = " + txtPreviewStartTime.Text);
                outputFile.WriteLine("frets = " + txtCharter.Text);
                outputFile.WriteLine("charter = " + txtCharter.Text);
                outputFile.WriteLine("icon = " + txtIcon.Text);
                outputFile.WriteLine("album_track = " + txtAlbumTrack.Text);
                outputFile.WriteLine("playlist_track = " + txtPlaylistTrack.Text);


            }
            MessageBox.Show("ini file saved successfully!", "Success!");
        }

        private void clearData()
        {

            txtSongName.Text = "";
            txtArtist.Text = "";
            txtAlbum.Text = "";
            txtGenre.Text = "";
            txtYear.Text = "";
            txtSongLength.Text = "";
            txtCount.Text = "";
            txtPreviewStartTime.Text = "";
            txtIcon.Text = "";
            txtCharter.Text = "";
            txtAlbumTrack.Text = "";
            txtPlaylistTrack.Text = "";
            cboBandDifficulty.SelectedIndex = 0;
            cboBassDifficulty.SelectedIndex = 0;
            cboBassGHLDifficulty.SelectedIndex = 0;
            cboDrumsDifficulty.SelectedIndex = 0;
            cboguitarDifficulty.SelectedIndex = 0;
            cboGuitarGHLDifficulty.SelectedIndex = 0;
            cboKeysDifficulty.SelectedIndex = 0;
        }

        private string validate()
        {
            string errMsg = "";
            if (txtSongName.Text == "")
            {
                errMsg = "Song Title is Required!";
            }
            if (txtArtist.Text == "")
            {
                errMsg = "Artist Name is Required!";
            }
            return errMsg;
        }

        private void txtIcon_TextChanged(object sender, EventArgs e)
        {
            if (txtIcon.Text.EndsWith(".png") || txtIcon.Text.EndsWith(".jpg"))
                {
                txtIcon.Text = txtIcon.Text.Substring(0, txtIcon.Text.Length - 4);
                MessageBox.Show("Icons should not have file extensions after their names.  This has been removed for you");
            }

        }

        private void timeCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimeCalculator t = new frmTimeCalculator();
            t.Show();
        }

        private void openMp3oggToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open the media file and read in ID3 tags, populate accordingly.
            
            
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "OGG Audio Files |*.ogg|MP3 Audio Files |*.mp3";
            f.Multiselect = false;
            DialogResult r = f.ShowDialog();
            if (r == DialogResult.OK)
            {
                string audiopath = f.FileName;
                //ID3 library from https://www.nuget.org/packages/taglib
                TagLib.File tag = TagLib.File.Create(audiopath);

                if (tag.Tag.Title + "" != "")
                {
                    clearData(); //only clear data if there's actually tags to update..presumption is that the track will have a title.
                    isNew = true;

                }
                else
                {
                    MessageBox.Show("No data could be found!  Please fill this data in manually!", "Not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                foreach (var artist in tag.Tag.Performers)
                {
                    if (txtArtist.Text == "")
                    {
                        txtArtist.Text = artist;
                    }
                    else
                    {
                        txtArtist.Text = txtArtist.Text + ", " + artist;
                    }
                }

                txtAlbum.Text = tag.Tag.Album + "";
                foreach (var genre in tag.Tag.Genres)
                {
                    if (txtGenre.Text == "")
                    {
                        txtGenre.Text = genre;
                    }
                    else
                    {
                        txtGenre.Text = txtGenre.Text + ", " + genre;
                    }
                }
                txtAlbumTrack.Text = tag.Tag.Track + "";
                txtSongName.Text = tag.Tag.Title + "";
                txtYear.Text = tag.Tag.Year.ToString();
                if (txtAlbumTrack.Text == "0")
                {
                    txtAlbumTrack.Text = "";
                }
                if (txtYear.Text == "0")
                {
                    txtYear.Text = "";
                }
                txtSongLength.Text = tag.Properties.Duration.TotalMilliseconds.ToString();
            }
        }
    }

}
