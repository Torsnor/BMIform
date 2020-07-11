using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIForm
{
    class BMICalculator
    {
        private string name = "No Name";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;

        public string GetName ()
        {
            return name;
        }

        public void SetName(string value)
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double value)
        {
            if (value >= 0)
                height = value;
        }

        public double GetWeight()
        {
            return weight;
        }

        public void SetWeight(double value)
        {
            if (value >= 0)
                weight = value;
        }


        public UnitTypes GetUnit()
        {
            return unit;
        }

        public void SetUnit(UnitTypes value)
        {
            unit = value;
        }

        public double CalculateBMI()
        {
            double bmiValue = 0.0;
            double factor = 0.0;

            if (unit == UnitTypes.American)
            {
                factor = 703.0;
            }
            else
            {
                factor = 1.0;
            }

            bmiValue = factor * weight / (height * height);

            return bmiValue;
        }

        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI();
            string stringout = string.Empty;
            if (bmi > 40)
                stringout = "Overweight (Obesity class III)";
            else if (bmi < 40 - 35)
                stringout = "Overweight (Obesity class II) ";
            else if (bmi < 35 - 30)
                stringout = "Overweight (Obesity class I) ";

            return stringout;
        }
    }

   
}
