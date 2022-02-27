using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFileSystemWatcher
{
    public partial class FileSystemWatcterForm : Form
    {
        public FileSystemWatcterForm()
        {
            InitializeComponent();
        }
        FileSystemWatcher fsw_obj;
        public string path;
        public string file;
        public string extension;
        public string eventType;
        public DateTime time;
        public string txtQuery;
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData("select * from FolderData");
                ext_ComboBox.Items.Add("*.exe");
                ext_ComboBox.Items.Add("*.txt");
                ext_ComboBox.Items.Add("*.rtf");
                ext_ComboBox.Items.Add("*.pub");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source =./FWSdatabase.db;Version=3;New=False;Compress=Trure;");
        }
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void LoadData(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = txtQuery;
            DB = new SQLiteDataAdapter(CommandText , sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            File_Watcher_View.DataSource = DT;
            sql_con.Close();
        }

        private void query_MenuStrip_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueryForm form2 = new QueryForm();
            form2.ShowDialog();
            this.Close();
        }

        private void FSW_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {
                path = e.FullPath;
            time = DateTime.Now;
            file = new FileInfo(path).Name;
            extension = Path.GetExtension(path);
            eventType = "File Changed";
            txtQuery = "insert into FolderData (Extension,Filename,Path,Event,Date_Time)values('" + extension + "','" + file + "','" + path + "','" + eventType + "','" + time + "')";
            ExecuteQuery(txtQuery);
            LoadData("select * from FolderData");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void FSW_Created(object sender, FileSystemEventArgs e)
        {
            try
            {
                path = e.FullPath;
            time = DateTime.Now;
            file = new FileInfo(path).Name;
            extension = Path.GetExtension(path);
            eventType = "File Created";
            txtQuery = "insert into FolderData (Extension,Filename,Path,Event,Date_Time)values('" + extension + "','" + file + "','" + path + "','" + eventType + "','" + time + "')";
            ExecuteQuery(txtQuery);
            LoadData("select * from FolderData");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void FSW_Deleted(object sender, FileSystemEventArgs e)
        {
            try
            {
                path = e.FullPath;
            time = DateTime.Now;
            file = new FileInfo(path).Name;
            extension = Path.GetExtension(path);
            eventType = "File Deleted";
            txtQuery = "insert into FolderData (Extension,Filename,Path,Event,Date_Time)values('" + extension + "','" + file + "','" + path + "','" + eventType + "','" + time + "')";
            ExecuteQuery(txtQuery);
            LoadData("select * from FolderData");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void FSW_Renamed(object sender, RenamedEventArgs e)
        {
            try
            {
                path = e.FullPath;
                time = DateTime.Now;
                file = new FileInfo(path).Name;
                extension = Path.GetExtension(path);
                eventType = "File Renamed";
                txtQuery = "insert into FolderData (Extension,Filename,Path,Event,Date_Time)values('" + extension + "','" + file + "','" + path + "','" + eventType + "','" + time + "')";
                ExecuteQuery(txtQuery);
                LoadData("select * from FolderData");
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void PathSubmit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                fsw_obj = new FileSystemWatcher(FolderPath_box.Text);
                fsw_obj.IncludeSubdirectories = true;
                fsw_obj.NotifyFilter = NotifyFilters.CreationTime |
                                         NotifyFilters.LastAccess |
                                         NotifyFilters.LastWrite |
                                         NotifyFilters.DirectoryName |
                                         NotifyFilters.FileName;

                if (!ext_ComboBox.Text.Equals(""))
                {
                    fsw_obj.Filter = ext_ComboBox.Text;
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
}

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ext_ComboBox.Items.Add("*." + ext_box.Text);
                ext_box.Text = "";
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            
            fsw_obj.Changed += new FileSystemEventHandler(FSW_Changed);
            fsw_obj.Deleted += new FileSystemEventHandler(FSW_Deleted);
            fsw_obj.Changed += new FileSystemEventHandler(FSW_Created);
            fsw_obj.Renamed += new RenamedEventHandler(FSW_Renamed);
            fsw_obj.EnableRaisingEvents = true;
            this.Text = "Monitoring Started";
            monitor_label.Text = "Monitoring Status: ON";
        }

        private void start_MenuStrip_Click(object sender, EventArgs e)
        {
            fsw_obj.Changed += new FileSystemEventHandler(FSW_Changed);
            fsw_obj.Deleted += new FileSystemEventHandler(FSW_Deleted);
            fsw_obj.Changed += new FileSystemEventHandler(FSW_Created);
            fsw_obj.Renamed += new RenamedEventHandler(FSW_Renamed);
            fsw_obj.EnableRaisingEvents = true;
            this.Text = "Monitoring Started";
            monitor_label.Text = "Monitoring Status: ON";
        }

        private void stop_MenuStrip_Click(object sender, EventArgs e)
        {
            fsw_obj.Changed -= new FileSystemEventHandler(FSW_Changed);
            fsw_obj.Deleted -= new FileSystemEventHandler(FSW_Deleted);
            fsw_obj.Changed -= new FileSystemEventHandler(FSW_Created);
            fsw_obj.Renamed -= new RenamedEventHandler(FSW_Renamed);
            fsw_obj.EnableRaisingEvents = false;
            this.Text = "Monitoring Stopped";
            monitor_label.Text = "Monitoring Status: OFF";
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            fsw_obj.Changed -= new FileSystemEventHandler(FSW_Changed);
            fsw_obj.Deleted -= new FileSystemEventHandler(FSW_Deleted);
            fsw_obj.Changed -= new FileSystemEventHandler(FSW_Created);
            fsw_obj.Renamed -= new RenamedEventHandler(FSW_Renamed);
            fsw_obj.EnableRaisingEvents = false;
            this.Text = "Monitoring Stopped";
            monitor_label.Text = "Monitoring Status: OFF";
        }

        private void about_MenuStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Written by Mohammed Saeed Alyami\nVersion 1.0\nThis program watches files using the file system watcher class.");
        }

        private void close_MenuStrip_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Do you want to save the data to database??", "program close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    string txtQuery = "insert into FolderData (Extension,Filename,Path,Event,Date_Time)values('" + extension + "','" + file + "','" + path + "','" + eventType + "','" + time + "')";
                    ExecuteQuery(txtQuery);
                    this.Close();
                    Application.Exit();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FileSystemWatcterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Do you want to save the data to database??", "program close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    string txtQuery = "insert into FolderData (Extension,Filename,Path,Event,Date_Time)values('" + extension + "','" + file + "','" + path + "','" + eventType + "','" + time + "')";
                    ExecuteQuery(txtQuery);
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }

}
