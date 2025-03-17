namespace Programming_Assignment
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.athleteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privateHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfCompetitionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athletesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athleteTrainingDBDataSet = new Programming_Assignment.AthleteTrainingDBDataSet();
            this.athletesTableAdapter = new Programming_Assignment.AthleteTrainingDBDataSetTableAdapters.AthletesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.competitionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athleteIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athleteTrainingDBDataSet1 = new Programming_Assignment.AthleteTrainingDBDataSet1();
            this.competitionsTableAdapter = new Programming_Assignment.AthleteTrainingDBDataSet1TableAdapters.CompetitionsTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.coachingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athleteIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachingHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privateCoachingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athleteTrainingDBDataSet2 = new Programming_Assignment.AthleteTrainingDBDataSet2();
            this.privateCoachingTableAdapter = new Programming_Assignment.AthleteTrainingDBDataSet2TableAdapters.PrivateCoachingTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athletesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athleteTrainingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athleteTrainingDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privateCoachingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athleteTrainingDBDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.athleteIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.trainingPlanDataGridViewTextBoxColumn,
            this.currentWeightDataGridViewTextBoxColumn,
            this.weightCategoryDataGridViewTextBoxColumn,
            this.privateHoursDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.noOfCompetitionsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.athletesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // athleteIDDataGridViewTextBoxColumn
            // 
            this.athleteIDDataGridViewTextBoxColumn.DataPropertyName = "AthleteID";
            this.athleteIDDataGridViewTextBoxColumn.HeaderText = "AthleteID";
            this.athleteIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.athleteIDDataGridViewTextBoxColumn.Name = "athleteIDDataGridViewTextBoxColumn";
            this.athleteIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.athleteIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainingPlanDataGridViewTextBoxColumn
            // 
            this.trainingPlanDataGridViewTextBoxColumn.DataPropertyName = "TrainingPlan";
            this.trainingPlanDataGridViewTextBoxColumn.HeaderText = "TrainingPlan";
            this.trainingPlanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainingPlanDataGridViewTextBoxColumn.Name = "trainingPlanDataGridViewTextBoxColumn";
            this.trainingPlanDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentWeightDataGridViewTextBoxColumn
            // 
            this.currentWeightDataGridViewTextBoxColumn.DataPropertyName = "CurrentWeight";
            this.currentWeightDataGridViewTextBoxColumn.HeaderText = "CurrentWeight";
            this.currentWeightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentWeightDataGridViewTextBoxColumn.Name = "currentWeightDataGridViewTextBoxColumn";
            this.currentWeightDataGridViewTextBoxColumn.Width = 125;
            // 
            // weightCategoryDataGridViewTextBoxColumn
            // 
            this.weightCategoryDataGridViewTextBoxColumn.DataPropertyName = "WeightCategory";
            this.weightCategoryDataGridViewTextBoxColumn.HeaderText = "WeightCategory";
            this.weightCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightCategoryDataGridViewTextBoxColumn.Name = "weightCategoryDataGridViewTextBoxColumn";
            this.weightCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // privateHoursDataGridViewTextBoxColumn
            // 
            this.privateHoursDataGridViewTextBoxColumn.DataPropertyName = "PrivateHours";
            this.privateHoursDataGridViewTextBoxColumn.HeaderText = "PrivateHours";
            this.privateHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.privateHoursDataGridViewTextBoxColumn.Name = "privateHoursDataGridViewTextBoxColumn";
            this.privateHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // noOfCompetitionsDataGridViewTextBoxColumn
            // 
            this.noOfCompetitionsDataGridViewTextBoxColumn.DataPropertyName = "NoOfCompetitions";
            this.noOfCompetitionsDataGridViewTextBoxColumn.HeaderText = "NoOfCompetitions";
            this.noOfCompetitionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noOfCompetitionsDataGridViewTextBoxColumn.Name = "noOfCompetitionsDataGridViewTextBoxColumn";
            this.noOfCompetitionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // athletesBindingSource
            // 
            this.athletesBindingSource.DataMember = "Athletes";
            this.athletesBindingSource.DataSource = this.athleteTrainingDBDataSet;
            // 
            // athleteTrainingDBDataSet
            // 
            this.athleteTrainingDBDataSet.DataSetName = "AthleteTrainingDBDataSet";
            this.athleteTrainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // athletesTableAdapter
            // 
            this.athletesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Athlete details and Payment Details";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.competitionIDDataGridViewTextBoxColumn,
            this.athleteIDDataGridViewTextBoxColumn1,
            this.competitionFeeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.competitionsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(56, 261);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(426, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // competitionIDDataGridViewTextBoxColumn
            // 
            this.competitionIDDataGridViewTextBoxColumn.DataPropertyName = "CompetitionID";
            this.competitionIDDataGridViewTextBoxColumn.HeaderText = "CompetitionID";
            this.competitionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.competitionIDDataGridViewTextBoxColumn.Name = "competitionIDDataGridViewTextBoxColumn";
            this.competitionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.competitionIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // athleteIDDataGridViewTextBoxColumn1
            // 
            this.athleteIDDataGridViewTextBoxColumn1.DataPropertyName = "AthleteID";
            this.athleteIDDataGridViewTextBoxColumn1.HeaderText = "AthleteID";
            this.athleteIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.athleteIDDataGridViewTextBoxColumn1.Name = "athleteIDDataGridViewTextBoxColumn1";
            this.athleteIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // competitionFeeDataGridViewTextBoxColumn
            // 
            this.competitionFeeDataGridViewTextBoxColumn.DataPropertyName = "CompetitionFee";
            this.competitionFeeDataGridViewTextBoxColumn.HeaderText = "CompetitionFee";
            this.competitionFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.competitionFeeDataGridViewTextBoxColumn.Name = "competitionFeeDataGridViewTextBoxColumn";
            this.competitionFeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // competitionsBindingSource
            // 
            this.competitionsBindingSource.DataMember = "Competitions";
            this.competitionsBindingSource.DataSource = this.athleteTrainingDBDataSet1;
            // 
            // athleteTrainingDBDataSet1
            // 
            this.athleteTrainingDBDataSet1.DataSetName = "AthleteTrainingDBDataSet1";
            this.athleteTrainingDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // competitionsTableAdapter
            // 
            this.competitionsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coachingIDDataGridViewTextBoxColumn,
            this.athleteIDDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1,
            this.coachingHoursDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.privateCoachingBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(56, 464);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(555, 150);
            this.dataGridView3.TabIndex = 3;
            // 
            // coachingIDDataGridViewTextBoxColumn
            // 
            this.coachingIDDataGridViewTextBoxColumn.DataPropertyName = "CoachingID";
            this.coachingIDDataGridViewTextBoxColumn.HeaderText = "CoachingID";
            this.coachingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coachingIDDataGridViewTextBoxColumn.Name = "coachingIDDataGridViewTextBoxColumn";
            this.coachingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.coachingIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // athleteIDDataGridViewTextBoxColumn2
            // 
            this.athleteIDDataGridViewTextBoxColumn2.DataPropertyName = "AthleteID";
            this.athleteIDDataGridViewTextBoxColumn2.HeaderText = "AthleteID";
            this.athleteIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.athleteIDDataGridViewTextBoxColumn2.Name = "athleteIDDataGridViewTextBoxColumn2";
            this.athleteIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // coachingHoursDataGridViewTextBoxColumn
            // 
            this.coachingHoursDataGridViewTextBoxColumn.DataPropertyName = "CoachingHours";
            this.coachingHoursDataGridViewTextBoxColumn.HeaderText = "CoachingHours";
            this.coachingHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coachingHoursDataGridViewTextBoxColumn.Name = "coachingHoursDataGridViewTextBoxColumn";
            this.coachingHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // privateCoachingBindingSource
            // 
            this.privateCoachingBindingSource.DataMember = "PrivateCoaching";
            this.privateCoachingBindingSource.DataSource = this.athleteTrainingDBDataSet2;
            // 
            // athleteTrainingDBDataSet2
            // 
            this.athleteTrainingDBDataSet2.DataSetName = "AthleteTrainingDBDataSet2";
            this.athleteTrainingDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // privateCoachingTableAdapter
            // 
            this.privateCoachingTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Competition Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Private Coaching Details";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1233, 641);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(908, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 85);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back to Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 637);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Database Tables";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athletesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athleteTrainingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athleteTrainingDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privateCoachingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athleteTrainingDBDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AthleteTrainingDBDataSet athleteTrainingDBDataSet;
        private System.Windows.Forms.BindingSource athletesBindingSource;
        private AthleteTrainingDBDataSetTableAdapters.AthletesTableAdapter athletesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privateHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfCompetitionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private AthleteTrainingDBDataSet1 athleteTrainingDBDataSet1;
        private System.Windows.Forms.BindingSource competitionsBindingSource;
        private AthleteTrainingDBDataSet1TableAdapters.CompetitionsTableAdapter competitionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private AthleteTrainingDBDataSet2 athleteTrainingDBDataSet2;
        private System.Windows.Forms.BindingSource privateCoachingBindingSource;
        private AthleteTrainingDBDataSet2TableAdapters.PrivateCoachingTableAdapter privateCoachingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachingHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}