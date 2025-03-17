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

namespace Programming_Assignment
{
    public partial class Form6 : Form
    {
        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=AthleteTrainingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Form6()
        {
            InitializeComponent();
            LoadAthleteData();
            LoadCompetitionData();
            LoadPrivateCoachingData();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
            this.privateCoachingTableAdapter.Fill(this.athleteTrainingDBDataSet2.PrivateCoaching);
           
            this.competitionsTableAdapter.Fill(this.athleteTrainingDBDataSet1.Competitions);
           
            this.athletesTableAdapter.Fill(this.athleteTrainingDBDataSet.Athletes);
            this.competitionsTableAdapter.Fill(this.athleteTrainingDBDataSet1.Competitions);
            this.athletesTableAdapter.Fill(this.athleteTrainingDBDataSet.Athletes);



        }
        public void LoadAthleteData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Athletes";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        public void LoadCompetitionData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Competitions";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        public void LoadPrivateCoachingData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PrivateCoaching";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    
