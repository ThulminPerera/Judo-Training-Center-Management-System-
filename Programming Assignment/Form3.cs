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
    public partial class Form3 : Form
    {

        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=AthleteTrainingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
       
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadCompetitionIDs();
            LoadAthleteIDs();
        }

        private void LoadCompetitionIDs()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT CompetitionID FROM Competitions";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbCompetitionID.DataSource = dt;
                    cmbCompetitionID.DisplayMember = "CompetitionID";
                    cmbCompetitionID.ValueMember = "CompetitionID";
                }
            }
        }

        private void LoadAthleteIDs()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT AthleteID, Name FROM Athletes";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbAthleteID.DataSource = dt;
                    cmbAthleteID.DisplayMember = "AthleteID";
                    cmbAthleteID.ValueMember = "AthleteID";
                }
            }
        }

        private void cmbAthleteID_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (cmbAthleteID.SelectedValue != null)
                {
                    int athleteID = Convert.ToInt32(((DataRowView)cmbAthleteID.SelectedItem)["AthleteID"]);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT Name FROM Athletes WHERE AthleteID = @AthleteID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@AthleteID", athleteID);
                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                txtName.Text = result.ToString(); 
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (cmbAthleteID.SelectedValue == null || string.IsNullOrWhiteSpace(txtCompetitionFee.Text))
                {
                    MessageBox.Show("Please select an Athlete and enter Competition Fee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int athleteID = Convert.ToInt32(cmbAthleteID.SelectedValue);
                decimal competitionFee;

                if (!decimal.TryParse(txtCompetitionFee.Text, out competitionFee))
                {
                    MessageBox.Show("Invalid competition fee format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Competitions (AthleteID, CompetitionFee) VALUES (@AthleteID, @CompetitionFee)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AthleteID", athleteID);
                        cmd.Parameters.AddWithValue("@CompetitionFee", competitionFee);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Competition details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}

