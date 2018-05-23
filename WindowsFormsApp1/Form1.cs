using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    System.IO.File.Copy(f.FileName, Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\\backup\\" +filename);
                }
                path = f.FileName;
                isNew = false;
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                string line;
                while ((line = file.ReadLine())!= null)
                    {
                    //chop up the output one line at a time to determine what value is selected..this will be a bit ugly..
                    //fix for lines with no space between the equal sign and the label...
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
                        if (line.StartsWith("frets = "))
                        {
                            txtFrets.Text = line.Replace("frets = ", "");
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
                            switch(tmp)
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
                        if (line.StartsWith("charter = "))
                        {
                        txtCharter.Text = line.Replace("charter = ", "");
                        }
                        if (line.StartsWith("count = "))
                        {
                        txtCount.Text = line.Replace("count = ", "");
                        }

                    }
                file.Close();
                }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isNew = true; //by default.  If a file is opened later, this will get swapped..
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Value");
            for (int i = - 1; i < 7; i++)
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

        private void txtCharter_TextChanged(object sender, EventArgs e)
        {
            txtFrets.Text = txtCharter.Text;
        }

        private void txtFrets_TextChanged(object sender, EventArgs e)
        {
            txtCharter.Text = txtFrets.Text;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
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
            txtFrets.Text = "";
            txtCharter.Text = "";
            cboBandDifficulty.SelectedIndex = 0;
            cboBassDifficulty.SelectedIndex = 0;
            cboBassGHLDifficulty.SelectedIndex = 0;
            cboDrumsDifficulty.SelectedIndex = 0;
            cboguitarDifficulty.SelectedIndex = 0;
            cboGuitarGHLDifficulty.SelectedIndex = 0;
            cboKeysDifficulty.SelectedIndex = 0;
            isNew = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void writeFile(string path)
        {
            using (System.IO.StreamWriter outputFile = new StreamWriter(path, false))
            {
                outputFile.WriteLine("[Song]");
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
                outputFile.WriteLine("frets = " + txtFrets.Text);
                outputFile.WriteLine("charter = " + txtCharter.Text);
                outputFile.WriteLine("icon = " + txtIcon.Text);

            }
            MessageBox.Show("ini file saved successfully!", "Success!");
        }
    }

}
