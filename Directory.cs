using System;
using System.Data;
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

        static string connectionString = @"Data Source=C:\Users\Efe\Desktop\os_form\Data\directory.db";
        SQLiteConnection connection = new SQLiteConnection(connectionString);


        private DataTable dataTable()
        {   
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From guide", connection);
            adapter.Fill(dataTable);
            return dataTable;
           
        }
        private void Directory_Load(object sender, EventArgs e)
        {
            connection.Open();
            dataGrid.DataSource = dataTable();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string saveCode = "";
            if (selectPhoneNumber == "")
            {
                saveCode = "insert into guide(ad,soyad,numara,mail) values ('" + txtName.Text + "','" + txtSurname.Text + "','" + txtNumber.Text + "','" + txtEmail.Text + "');";
            }
            else
            {
                saveCode = "update guide set ad='" + txtName.Text + "', soyad='" + txtSurname.Text + "', mail='" + txtEmail.Text + "' where numara=" + selectPhoneNumber + ";";
            }
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(saveCode, connection);
                sQLiteCommand.ExecuteNonQuery();
                clearSelectedData();
                dataGrid.DataSource = dataTable();
            }
            catch (Exception err)
            {
                if (err.Message.Contains("UNIQUE"))
                {
                    MessageBox.Show("Numara Aynı Olamaz!!");
                }
                else
                {
                    throw;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM guide WHERE numara=" + selectPhoneNumber,connection);
            DialogResult dialogResult = MessageBox.Show("Kişiyi silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                clearSelectedData();
                dataGrid.DataSource = dataTable();
            }
        }

        string selectPhoneNumber = "";
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectPhoneNumber = dataGrid.CurrentRow.Cells[2].Value.ToString();
            txtName.Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            txtSurname.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dataGrid.CurrentRow.Cells[3].Value.ToString();
            txtNumber.Text = selectPhoneNumber;

            txtNumber.Enabled = false;
        }

        private void clearSelectedData()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtNumber.Text = "";
            txtEmail.Text = "";
            selectPhoneNumber = "";

            txtNumber.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clearSelectedData();
        }

        private void Directory_Leave(object sender, EventArgs e)
        {
            connection.Close();
        }
    }
}
