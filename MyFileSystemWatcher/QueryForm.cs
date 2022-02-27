using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFileSystemWatcher
{
    public partial class QueryForm : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {

        }
        private void SetConnection()
        {
            try { 
            sql_con = new SQLiteConnection("Data Source =./FWSdatabase.db;Version=3;New=False;Compress=Trure;");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void ExecuteQuery(string txtQuery)
        {
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = txtQuery;
                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void LoadData(string txtQuery)
        {
            try { 
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = txtQuery;
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            QueryView_grid.DataSource = DT;
            sql_con.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void query_btn_Click(object sender, EventArgs e)
        {
            try { 
            string text = query_box.Text;
            if (text.ToLower() == "show")
            {
                LoadData("select * from FolderData");
            }
            else if (text.ToLower() == "delete")
            {
                string my_query = "delete from FolderData";
                ExecuteQuery(my_query);
                LoadData("select * from FolderData");
            }
            else
            {
                ExecuteQuery(query_box.Text.ToString());
                LoadData("select * from FolderData");
            }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }


        private void QueryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Hide();
                FileSystemWatcterForm form1 = new FileSystemWatcterForm();
                form1.ShowDialog();
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
