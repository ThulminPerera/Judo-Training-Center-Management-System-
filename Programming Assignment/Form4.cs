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
    public partial class Form4 : Form

    {
        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=AthleteTrainingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            {
                LoadAthleteIDs();

            }

        }
        private void LoadAthleteIDs()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT AthleteID, Name FROM Athletes";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbAthleteID.DataSource = dt;
                    cmbAthleteID.DisplayMember = "AthleteID"; 
                    cmbAthleteID.ValueMember = "AthleteID"; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Athlete IDs: " + ex.Message);
            }
        }




        private void LoadAthleteName(int athleteID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Name FROM Athletes WHERE AthleteID = @AthleteID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AthleteID", athleteID);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    conn.Close();

                    if (result != null)
                    {
                        txtName.Text = result.ToString();
                    }
                    else
                    {
                        txtName.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading athlete name: " + ex.Message);
            }
        }

        private void cmbAthleteID_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (cmbAthleteID.SelectedValue != null)
                {
                    int athleteID = Convert.ToInt32(((DataRowView)cmbAthleteID.SelectedItem)["AthleteID"]);
                    LoadAthleteName(athleteID);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                int athleteID = Convert.ToInt32(cmbAthleteID.SelectedValue);
                string name = txtName.Text.Trim();
                int coachingHours = int.Parse(txtCoachingHours.Text); 

                string query = "INSERT INTO PrivateCoaching (AthleteID, Name, CoachingHours) VALUES (@AthleteID, @Name, @CoachingHours)";

                using (SqlConnection conn = new SqlConnection(connectionString)) 
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AthleteID", athleteID);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@CoachingHours", coachingHours);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            txtName.Clear();
                            txtCoachingHours.Clear();
                            cmbAthleteID.SelectedIndex = -1; 
                        }
                        else
                        {
                            MessageBox.Show("Submission failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all fields","Fill all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        
    

