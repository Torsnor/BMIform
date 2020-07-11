using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIForm
{
    public partial class MainForm : Form
    {
        private BMICalculator bmiCalc = new BMICalculator();
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "The Body Mass Calculator";

            rbtnUsUnit.Checked = true;
            lblHeight.Text = "Height (feet)";
            lblWeight.Text = "Weight (lbs)";

            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        private void DisplayResults()
        {
            lblResultYourBmi.Text = bmiCalc.CalculateBMI().ToString("f2");
            lblResultWeightCategory.Text = bmiCalc.BmiWeightCategory().ToString();
            grpResults.Text = "Result for " + bmiCalc.GetName();         
        }

        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                bmiCalc.SetUnit(UnitTypes.Metric);
            }
        }

        private void rbtnUsUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUsUnit.Checked)
            {
                lblHeight.Text = "Foot (inch)";
                lblWeight.Text = "Lbs (lbs)";
                bmiCalc.SetUnit(UnitTypes.American);
            }               
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();

            if (ok)
            {
                DisplayResults();
            }
        }

        private bool ReadInputBMI()
        {
            bool isInputOk = false;

            ReadName();
            ReadUnitType();
            isInputOk = ReadHeight();
            isInputOk = isInputOk && ReadWeight();

            return isInputOk;
        }

        private void ReadName()
        {
            txtYourName.Text.Trim();
            if (!string.IsNullOrEmpty(txtYourName.Text))
                bmiCalc.SetName(txtYourName.Text);
            else
                bmiCalc.SetName("Unknown");
        }

        private bool ReadHeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(txtHeight.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    if (bmiCalc.GetUnit() == UnitTypes.Metric)
                    {
                        bmiCalc.SetHeight(outValue * Height);
                    }
                    else
                    {
                        bmiCalc.SetHeight(outValue / 100.0);
                    }
                }
                else
                    ok = false;
            }
            if (!ok)
                MessageBox.Show("invalid height value!", "Error");
            return ok;
        }

        private bool ReadWeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(txtWeight.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    if (bmiCalc.GetUnit() == UnitTypes.American)
                    {
                        bmiCalc.SetWeight(outValue * 12.00);
                    }
                    else
                    {
                        bmiCalc.SetHeight(outValue / 500.0);
                    }
                }
                else
                    ok = false;
            }
            if (!ok)
                MessageBox.Show("invalid weight value!", "Error");
            return ok;
        }

        private void ReadUnitType()
        {
            if (rbtnMetric.Checked)
                bmiCalc.SetUnit(UnitTypes.Metric);
            else bmiCalc.SetUnit(UnitTypes.American);
        }      
    }
}
