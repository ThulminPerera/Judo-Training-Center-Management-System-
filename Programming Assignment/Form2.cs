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
using System.Xml.Linq;

namespace Programming_Assignment
{
    public partial class Form2 : Form
    {


        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=AthleteTrainingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Form2()
        {
            InitializeComponent();
            InitializeTrainingPlanComboBox();
            InitializeWeightCategoryComboBox();
            LoadAthleteIDs();
            CalculateTotalCost();

            cmbTrainingPlan.SelectedIndexChanged += cmbTrainingPlan_SelectedIndexChanged;
            txtPrivateHours.TextChanged += txtPrivateHours_TextChanged;


            cmbTrainingPlan.SelectedIndexChanged += UpdateTotalCost;
            txtPrivateHours.TextChanged += UpdateTotalCost;
            txtNoOfCompetitions.TextChanged += UpdateTotalCost;
            cmbAthleteID.SelectedIndexChanged += CmbAthleteID_SelectedIndexChanged;

            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadAthleteIDs();
            CalculateTotalCost();
        }

        private void InitializeTrainingPlanComboBox()
        {
            cmbTrainingPlan.Items.AddRange(new string[] { "Beginner", "Intermediate", "Elite" });
        }

        private void InitializeWeightCategoryComboBox()
        {
            cmbWeightCategory.Items.AddRange(new string[]
            {
        "Heavyweight", "Light-Heavyweight", "Middleweight",
        "Light-Middleweight", "Lightweight", "Flyweight"
            });
        }

        private void LoadAthleteIDs()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT AthleteID FROM Athletes";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbAthleteID.Items.Clear();

                        while (reader.Read())
                        {
                            cmbAthleteID.Items.Add(reader["AthleteID"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Athlete IDs: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbAthleteID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAthleteID.SelectedItem == null) return;

            string selectedID = cmbAthleteID.SelectedItem.ToString();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Name, TrainingPlan, CurrentWeight, WeightCategory, NoOfCompetitions, PrivateHours, TotalCost FROM Athletes WHERE AthleteID = @AthleteID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AthleteID", selectedID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["Name"].ToString();
                                cmbTrainingPlan.SelectedItem = reader["TrainingPlan"].ToString();
                                txtCurrentWeight.Text = reader["CurrentWeight"].ToString();
                                cmbWeightCategory.SelectedItem = reader["WeightCategory"].ToString();
                                txtNoOfCompetitions.Text = reader["NoOfCompetitions"].ToString();
                                txtPrivateHours.Text = reader["PrivateHours"].ToString();
                                txtTotalCost.Text = reader["TotalCost"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching athlete details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                int athleteID;
                if (!int.TryParse(cmbAthleteID.Text, out athleteID))
                {
                    MessageBox.Show("Invalid Athlete ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string checkQuery = "SELECT COUNT(*) FROM Athletes WHERE AthleteID = @AthleteID";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@AthleteID", athleteID);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {

                        string updateQuery = "UPDATE Athletes SET Name=@Name, TrainingPlan=@TrainingPlan, CurrentWeight=@CurrentWeight, WeightCategory=@WeightCategory, NoofCompetitions=@NoofCompetitions, PrivateHours=@PrivateHours, TotalCost=@TotalCost WHERE AthleteID=@AthleteID";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Name", txtName.Text);
                            updateCmd.Parameters.AddWithValue("@TrainingPlan", cmbTrainingPlan.SelectedItem?.ToString() ?? "");
                            updateCmd.Parameters.AddWithValue("@CurrentWeight", Convert.ToDecimal(txtCurrentWeight.Text));
                            updateCmd.Parameters.AddWithValue("@WeightCategory", cmbWeightCategory.SelectedItem?.ToString() ?? "");
                            updateCmd.Parameters.AddWithValue("@NoofCompetitions", Convert.ToInt32(txtNoOfCompetitions.Text));
                            updateCmd.Parameters.AddWithValue("@PrivateHours", Convert.ToInt32(txtPrivateHours.Text));
                            updateCmd.Parameters.AddWithValue("@TotalCost", Convert.ToDecimal(txtTotalCost.Text));
                            updateCmd.Parameters.AddWithValue("@AthleteID", athleteID);

                            updateCmd.ExecuteNonQuery();
                            MessageBox.Show("Athlete details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {

                        string insertQuery = "INSERT INTO Athletes (Name, TrainingPlan, CurrentWeight, WeightCategory, NoofCompetitions, PrivateHours, TotalCost) VALUES (@Name, @TrainingPlan, @CurrentWeight, @WeightCategory, @NoofCompetitions, @PrivateHours, @TotalCost)";

                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Name", txtName.Text);
                            insertCmd.Parameters.AddWithValue("@TrainingPlan", cmbTrainingPlan.SelectedItem?.ToString() ?? "");
                            insertCmd.Parameters.AddWithValue("@CurrentWeight", Convert.ToDecimal(txtCurrentWeight.Text));
                            insertCmd.Parameters.AddWithValue("@WeightCategory", cmbWeightCategory.SelectedItem?.ToString() ?? "");
                            insertCmd.Parameters.AddWithValue("@NoofCompetitions", Convert.ToInt32(txtNoOfCompetitions.Text));
                            insertCmd.Parameters.AddWithValue("@PrivateHours", Convert.ToInt32(txtPrivateHours.Text));
                            insertCmd.Parameters.AddWithValue("@TotalCost", Convert.ToDecimal(txtTotalCost.Text));

                            insertCmd.ExecuteNonQuery();
                            MessageBox.Show("New athlete added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void UpdateTotalCost(object sender, EventArgs e)
        {

            CalculateTotalCost();
        }

        private void CalculateTotalCost()
        {
            decimal trainingCost = 0;
            decimal competitionEntryFee = 220.00M;
            decimal privateTuitionFee = 90.50M;

            if (cmbTrainingPlan.SelectedItem != null)
            {
                switch (cmbTrainingPlan.SelectedItem.ToString())
                {
                    case "Beginner":
                        trainingCost = 250.00M * 4;
                        txtNoOfCompetitions.Text = "0";
                        txtNoOfCompetitions.Enabled = false;
                        break;
                    case "Intermediate":
                        trainingCost = 300.00M * 4;
                        txtNoOfCompetitions.Enabled = true;
                        break;
                    case "Elite":
                        trainingCost = 350.00M * 4;
                        txtNoOfCompetitions.Enabled = true;
                        break;
                }
            }

            decimal noOfCompetitions = 0;
            if (cmbTrainingPlan.SelectedItem != null &&
                cmbTrainingPlan.SelectedItem.ToString() != "Beginner" &&
                decimal.TryParse(txtNoOfCompetitions.Text, out decimal parsedCompetitions))
            {
                noOfCompetitions = parsedCompetitions;
            }

            decimal competitionCost = noOfCompetitions * competitionEntryFee;

            decimal privateHours = 0;
            if (decimal.TryParse(txtPrivateHours.Text, out decimal parsedHours))
            {
                privateHours = Math.Min(parsedHours, 5);
                txtPrivateHours.Text = privateHours.ToString();
            }

            decimal privateHourCost = privateHours * privateTuitionFee;

            decimal totalCost = trainingCost + competitionCost + privateHourCost;
            txtTotalCost.Text = totalCost.ToString("F2");
        }

        private void cmbTrainingPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }


        private void txtPrivateHours_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrivateHours.Text, out decimal hours) && hours > 5)
            {
                txtPrivateHours.Text = "5";
            }
            CalculateTotalCost();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
        private void ClearFields()
        {
            cmbAthleteID.SelectedIndex = -1;
            txtName.Clear();
            cmbTrainingPlan.SelectedIndex = -1;
            txtCurrentWeight.Clear();
            cmbWeightCategory.SelectedIndex = -1;
            txtNoOfCompetitions.Clear();
            txtPrivateHours.Clear();
            txtTotalCost.Clear();
        }
        

        private void button3_Click_1(object sender, EventArgs e)
        {
            {
                if (cmbAthleteID.SelectedItem == null)
                {
                    MessageBox.Show("Please select an Athlete ID to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this athlete?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmDelete == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string deleteQuery = "DELETE FROM Athletes WHERE AthleteID = @AthleteID";

                            using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@AthleteID", cmbAthleteID.SelectedItem.ToString());

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Athlete deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    
                                    LoadAthleteIDs();
                                    ClearFields();
                                }
                                else
                                {
                                    MessageBox.Show("Athlete not found or could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting athlete: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}