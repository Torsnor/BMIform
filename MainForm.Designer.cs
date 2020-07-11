namespace BMIForm
{
    partial class MainForm
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
            this.YourName = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtYourName = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnUsUnit = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblResultWeightCategory = new System.Windows.Forms.TextBox();
            this.lblResultYourBmi = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculateBMI = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // YourName
            // 
            this.YourName.AutoSize = true;
            this.YourName.Location = new System.Drawing.Point(12, 20);
            this.YourName.Name = "YourName";
            this.YourName.Size = new System.Drawing.Size(89, 20);
            this.YourName.TabIndex = 0;
            this.YourName.Text = "Your Name";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 114);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(98, 20);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height (feet)";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 157);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(93, 20);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight (lbs)";
            // 
            // txtYourName
            // 
            this.txtYourName.Location = new System.Drawing.Point(143, 14);
            this.txtYourName.Name = "txtYourName";
            this.txtYourName.Size = new System.Drawing.Size(451, 26);
            this.txtYourName.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(143, 108);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 26);
            this.txtHeight.TabIndex = 4;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(143, 151);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 26);
            this.txtWeight.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnUsUnit);
            this.groupBox2.Controls.Add(this.rbtnMetric);
            this.groupBox2.Location = new System.Drawing.Point(363, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 131);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unit";
            // 
            // rbtnUsUnit
            // 
            this.rbtnUsUnit.AutoSize = true;
            this.rbtnUsUnit.Location = new System.Drawing.Point(6, 76);
            this.rbtnUsUnit.Name = "rbtnUsUnit";
            this.rbtnUsUnit.Size = new System.Drawing.Size(160, 24);
            this.rbtnUsUnit.TabIndex = 1;
            this.rbtnUsUnit.TabStop = true;
            this.rbtnUsUnit.Text = "US Unit (foot, lbs)";
            this.rbtnUsUnit.UseVisualStyleBackColor = true;
            this.rbtnUsUnit.CheckedChanged += new System.EventHandler(this.rbtnUsUnit_CheckedChanged);
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(6, 44);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(166, 24);
            this.rbtnMetric.TabIndex = 0;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric Unit (kg cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblResultWeightCategory);
            this.grpResults.Controls.Add(this.lblResultYourBmi);
            this.grpResults.Controls.Add(this.Name);
            this.grpResults.Controls.Add(this.label7);
            this.grpResults.Location = new System.Drawing.Point(16, 268);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(578, 131);
            this.grpResults.TabIndex = 7;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results for Apu";
            // 
            // lblResultWeightCategory
            // 
            this.lblResultWeightCategory.Location = new System.Drawing.Point(319, 89);
            this.lblResultWeightCategory.Name = "lblResultWeightCategory";
            this.lblResultWeightCategory.Size = new System.Drawing.Size(218, 26);
            this.lblResultWeightCategory.TabIndex = 7;
            // 
            // lblResultYourBmi
            // 
            this.lblResultYourBmi.Location = new System.Drawing.Point(437, 35);
            this.lblResultYourBmi.Name = "lblResultYourBmi";
            this.lblResultYourBmi.Size = new System.Drawing.Size(100, 26);
            this.lblResultYourBmi.TabIndex = 6;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(18, 92);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(127, 20);
            this.Name.TabIndex = 1;
            this.Name.Text = "Weight Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Your BMI";
            // 
            // btnCalculateBMI
            // 
            this.btnCalculateBMI.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateBMI.Location = new System.Drawing.Point(224, 220);
            this.btnCalculateBMI.Name = "btnCalculateBMI";
            this.btnCalculateBMI.Size = new System.Drawing.Size(168, 42);
            this.btnCalculateBMI.TabIndex = 8;
            this.btnCalculateBMI.Text = "Calculate";
            this.btnCalculateBMI.UseVisualStyleBackColor = true;
            this.btnCalculateBMI.Click += new System.EventHandler(this.btnCalculateBMI_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Normal BMI is between 18.50 and 24.9";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(625, 467);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCalculateBMI);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtYourName);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.YourName);
            
            this.Text = "Body Mass Index";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label YourName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtYourName;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnUsUnit;
        private System.Windows.Forms.RadioButton rbtnMetric;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.TextBox lblResultWeightCategory;
        private System.Windows.Forms.TextBox lblResultYourBmi;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculateBMI;
        private System.Windows.Forms.Label label9;
    }
}

