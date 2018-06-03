using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Interface : Form
    {


        SqlConnection sqlConnection;

        public Interface()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ГЕРАЛЬТ ИЗ РИВИИ\DESKTOP\CONFIGURATORPC-MASTER\WINDOWSFORMSAPP1\CONFIG.MDF;Integrated Security=True";
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //SqlCommand sqlCommand = new SqlCommand("Insert Into [Config] (Nazv, Seria, Soket, TechProc, EnergyPotr, Takt, Yadra) Values(@Nazv, @Seria, @Soket, @TechProc, @EnergyPotr, @Takt, @Yadra)", sqlConnection);

            SqlCommand sqlCommand = new SqlCommand("Select * From [Interface]", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Nazv", ReadDataGridView.Rows[0].Cells[0].Value);
            sqlCommand.Parameters.AddWithValue("@Seria", "FX 6300");
            sqlCommand.Parameters.AddWithValue("@Soket", "AM3+");
            sqlCommand.Parameters.AddWithValue("@TechProc", 32);
            sqlCommand.Parameters.AddWithValue("@EnergyPotr", 95);
            sqlCommand.Parameters.AddWithValue("@Takt", 10);
            sqlCommand.Parameters.AddWithValue("@Yadra", 6);
        }

        private async void RandomButton_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommandRead = new SqlCommand("Insert Into [CPU] (Nazv, Seria, Soket, TechProc, EnergyPotr, Takt, Yadra) Values(@Nazv, @Seria, @Soket, @TechProc, @EnergyPotr, @Takt, @Yadra)", sqlConnection);

            SqlCommand sqlCommandWrite = new SqlCommand("Select * From [CPU]", sqlConnection);

            SqlDataReader dataReader = null;

            sqlCommandRead.Parameters.AddWithValue("Nazv", ReadDataGridView.Rows[0].Cells[0].Value);
            sqlCommandRead.Parameters.AddWithValue("Seria", "FX 6300");
            sqlCommandRead.Parameters.AddWithValue("Soket", "AM3+");
            sqlCommandRead.Parameters.AddWithValue("TechProc", 32);
            sqlCommandRead.Parameters.AddWithValue("EnergyPotr", 95);
            sqlCommandRead.Parameters.AddWithValue("Takt", 10);
            sqlCommandRead.Parameters.AddWithValue("Yadra", 6);

            await sqlConnection.OpenAsync();
            dataReader = await sqlCommandWrite.ExecuteReaderAsync();

            while (await dataReader.ReadAsync())
            {
                WriteDataGridView[0, 0].Value = dataReader["Nazv"].ToString();
                WriteDataGridView[0, 1].Value = dataReader["Seria"].ToString();
                WriteDataGridView[0, 2].Value = dataReader["Socket"].ToString();
            }

            sqlConnection.Close();
        }
    }
}