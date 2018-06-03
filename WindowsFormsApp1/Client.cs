using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Client : Form
    {
        SqlConnection sqlConnection;
        public Client()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        //private async void Form2_Load(object sender, EventArgs e)
        //{
        //    // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Client". При необходимости она может быть перемещена или удалена.
        //    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\APP\KR\WINDOWSFORMSAPP1\CONFIG.MDF;Integrated Security=True";

        //    sqlConnection = new SqlConnection(connectionString);

        //    await sqlConnection.OpenAsync();

        //    SqlDataReader sqlReader = null;

        //    SqlCommand command = new SqlCommand("Select * From [Client]", sqlConnection);


        //    try
        //    {
        //        sqlReader = await command.ExecuteReaderAsync();

        //        while (await sqlReader.ReadAsync())
        //        {
        //           listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + " " + Convert.ToString(sqlReader["NameOrg"]) + " " + " " + "ИНН" + " " + Convert.ToString(sqlReader["INN"]) + " " + " " + "КПП" + " " + Convert.ToString(sqlReader["KPP"]) + " " + " " + "Индекс" + " " + Convert.ToString(sqlReader["Indeks"])
        //                + " " + " " + "г." + Convert.ToString(sqlReader["City"]) + " " + " " + "ул." + Convert.ToString(sqlReader["Street"]) + " " + " " + "дом" + " " + Convert.ToString(sqlReader["House"]) + " " + " " + "номер" + " " + Convert.ToString(sqlReader["KonNumber"]));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        if (sqlReader != null)
        //            sqlReader.Close();
        //    }
        //}

        private async void обновитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("Select * From [Client]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + " " + Convert.ToString(sqlReader["NameOrg"]) + " " + " " + "ИНН" + " " + Convert.ToString(sqlReader["INN"]) + " " + " " + "КПП" + " " + Convert.ToString(sqlReader["KPP"]) + " " + " " + "Индекс" + " " + Convert.ToString(sqlReader["Indeks"])
                        + " " + " " + "г." + Convert.ToString(sqlReader["City"]) + " " + " " + "ул." + Convert.ToString(sqlReader["Street"]) + " " + " " + "дом" + " " + Convert.ToString(sqlReader["House"]) + " " + " " + "номер" + " " + Convert.ToString(sqlReader["KonNumber"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            {
                SqlCommand command = new SqlCommand("Insert Into [Config] (Nazv, Seria, Soket, TechProc, EnergyPotr, Takt, Yadra) Values(@Nazv, @Seria, @Soket, @TechProc, @EnergyPotr, @Takt, @Yadra)", sqlConnection);

                command.Parameters.AddWithValue("Nazv", textBox1.Text);
                command.Parameters.AddWithValue("Seria", textBox2.Text);
                command.Parameters.AddWithValue("Soket", textBox7.Text);
                command.Parameters.AddWithValue("TechProc", textBox11.Text);
                command.Parameters.AddWithValue("EnergyPotr", textBox10.Text);
                command.Parameters.AddWithValue("Takt", textBox9.Text);
                command.Parameters.AddWithValue("Yadra", textBox12.Text);

                textBox1.Text = null;
                textBox2.Text = null;
                textBox7.Text = null;
                textBox11.Text = null;
                textBox10.Text = null;
                textBox9.Text = null;
                textBox12.Text = null;
                textBox13.Text = null;

                await command.ExecuteNonQueryAsync();
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            if (label7.Visible)
                label7.Visible = false;

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                 !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                 !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) &&
                 !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text) &&
                 !string.IsNullOrEmpty(textBox11.Text) && !string.IsNullOrWhiteSpace(textBox11.Text) &&
                 !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox10.Text) &&
                 !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox9.Text) &&
                 !string.IsNullOrEmpty(textBox12.Text) && !string.IsNullOrWhiteSpace(textBox12.Text) &&
                 !string.IsNullOrEmpty(textBox13.Text) && !string.IsNullOrWhiteSpace(textBox13.Text))
            {
                SqlCommand command = new SqlCommand("Update [Client] Set [NameOrg]=@NameOrg, [INN]=@INN, [KPP]=@KPP, [Indeks]=@Indeks, [City]=@City, [Street]=@Street, [House]=@House, [KonNumber]=@KonNumber Where [Id]=@Id", sqlConnection);

                command.Parameters.AddWithValue("NameOrg", textBox1.Text);
                command.Parameters.AddWithValue("INN", textBox2.Text);
                command.Parameters.AddWithValue("KPP", textBox7.Text);
                command.Parameters.AddWithValue("Indeks", textBox11.Text);
                command.Parameters.AddWithValue("City", textBox10.Text);
                command.Parameters.AddWithValue("Street", textBox9.Text);
                command.Parameters.AddWithValue("House", textBox12.Text);
                command.Parameters.AddWithValue("KonNumber", textBox13.Text);
                command.Parameters.AddWithValue("Id", textBox5.Text);

                textBox1.Text = null;
                textBox2.Text = null;
                textBox5.Text = null;
                textBox7.Text = null;
                textBox11.Text = null;
                textBox10.Text = null;
                textBox9.Text = null;
                textBox12.Text = null;
                textBox13.Text = null;

                await command.ExecuteNonQueryAsync();
            }
            else if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                 !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                 !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) &&
                 !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text) &&
                 !string.IsNullOrEmpty(textBox11.Text) && !string.IsNullOrWhiteSpace(textBox11.Text) &&
                 !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox10.Text) &&
                 !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox9.Text) &&
                 !string.IsNullOrEmpty(textBox12.Text) && !string.IsNullOrWhiteSpace(textBox12.Text) &&
                 !string.IsNullOrEmpty(textBox13.Text) && !string.IsNullOrWhiteSpace(textBox13.Text))
            {
            }
            else
            {
                label7.Visible = true;
                label7.Text = "Все поля должны быть заполнены!";
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            if (label8.Visible)
                label8.Visible = false;

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                SqlCommand command = new SqlCommand("Delete from [Client] Where [NameOrg]=@NameOrg", sqlConnection);

                command.Parameters.AddWithValue("NameOrg", textBox1.Text);

                textBox1.Text = null;

                await command.ExecuteNonQueryAsync();
            }
            else
            {
                label8.Visible = true;
                label8.Text = "Название Организации должено быть заполнено!";
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}