using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace os_form
{
    public partial class Directory : Form
    {
        public Directory()
        {
            InitializeComponent();
        }


        private void Directory_Load(object sender, EventArgs e)
        {
            DataTable Show(string sqlite)
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source = .\\Directory.db;");
                DataTable dataBase = new DataTable();                 
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlite,connection);
                adapter.Fill(dataBase);
                return dataBase;
            }

            string directory = "Select * From Kişiler";
            dataGrid.DataSource = Show(directory);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
