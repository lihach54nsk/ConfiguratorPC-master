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
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Insert Into [Config] (Nazv, Seria, Soket, TechProc, EnergyPotr, Takt, Yadra) Values(@Nazv, @Seria, @Soket, @TechProc, @EnergyPotr, @Takt, @Yadra)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Nazv", ReadDataGridView.Rows[0].Cells[0].Value);
            sqlCommand.Parameters.AddWithValue("@Seria", "FX 6300");
            sqlCommand.Parameters.AddWithValue("@Soket", "AM3+");
            sqlCommand.Parameters.AddWithValue("@TechProc", 32);
            sqlCommand.Parameters.AddWithValue("@EnergyPotr", 95);
            sqlCommand.Parameters.AddWithValue("@Takt", 10);
            sqlCommand.Parameters.AddWithValue("@Yadra", 6);
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Insert Into [Config] (Nazv, Seria, Soket, TechProc, EnergyPotr, Takt, Yadra) Values(@Nazv, @Seria, @Soket, @TechProc, @EnergyPotr, @Takt, @Yadra)", sqlConnection);

            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            for (int i = 0; i < 9; i++)
            {
                ReadDataGridView.Rows.Add(reader.GetValue(1));
            }
        }
    }
}