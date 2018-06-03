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

            sqlCommand.Parameters.AddWithValue("Nazv", "hui");
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}