using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConvert_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string cannotBeEmpty = "Field cannot be empty";
        private string _choiceFrom = String.Empty;
        private string _choiceTo = String.Empty;

        private void Bttn_Convert_Click(object sender, EventArgs e)
        {
            var conversion = new Conversion();
            double userTemp = 0;

            if (string.IsNullOrEmpty(txtBox_UserTemp.Text))
            {
                lbl_IsEmptyWarning.Show();
                lbl_IsEmptyWarning.Text = cannotBeEmpty;                
            }
            else if (string.IsNullOrEmpty(CmboBox_TempFrom.Text))
            {
                lbl_degreeFromEmpty.Show();
                lbl_degreeFromEmpty.Text = cannotBeEmpty;
            }
            else if (string.IsNullOrEmpty(CmboBox_TempTo.Text))
            {
                lbl_degreeToEmpty.Show();
                lbl_degreeToEmpty.Text = cannotBeEmpty;
            }
            else
            {
                lbl_IsEmptyWarning.Hide();
                lbl_degreeToEmpty.Hide();
                lbl_degreeFromEmpty.Hide();
                try
                {
                    userTemp = Convert.ToDouble(txtBox_UserTemp.Text);
                    if(_choiceFrom == "Fahrenheit")
                    {
                        txtBox_AfterConversion.Text = conversion.ConvertFahrenheit(_choiceTo, userTemp).ToString();
                    }
                    else if (_choiceFrom == "Celsius")
                    {
                        txtBox_AfterConversion.Text = conversion.ConvertCelsius(_choiceTo, userTemp).ToString();
                    }
                    else if (_choiceFrom == "Kelvin")
                    {
                        txtBox_AfterConversion.Text = conversion.ConvertKelvin(_choiceTo, userTemp).ToString();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Did you input a number?");
                }
            }



        }

        private void CmboBox_TempFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmboBox_TempFrom.Text == (string)CmboBox_TempFrom.Items[0]) 
            {
                lbl_DegreeFrom.Text = "°F";
                _choiceFrom = CmboBox_TempFrom.Items[0].ToString();
            }
            else if (CmboBox_TempFrom.Text == (string)CmboBox_TempFrom.Items[1])
            {
                lbl_DegreeFrom.Text = "°C";
                _choiceFrom = CmboBox_TempFrom.Items[1].ToString();
            }
            else if (CmboBox_TempFrom.Text == (string)CmboBox_TempFrom.Items[2])
            {
                lbl_DegreeFrom.Text = "°K";
                _choiceFrom = CmboBox_TempFrom.Items[2].ToString();
            }
            else
            {
                lbl_DegreeFrom.Text = "--";
            }            
        }

        private void CmboBox_TempTo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CmboBox_TempTo.Text == (string)CmboBox_TempTo.Items[0])
            {
                lbl_degreeTo.Text = "°F";
                _choiceTo = CmboBox_TempTo.Items[0].ToString();
            }
            else if (CmboBox_TempTo.Text == (string)CmboBox_TempTo.Items[1])
            {
                lbl_degreeTo.Text = "°C";
                _choiceTo = CmboBox_TempTo.Items[1].ToString();
            }
            else if (CmboBox_TempTo.Text == (string)CmboBox_TempTo.Items[2])
            {
                lbl_degreeTo.Text = "°K";
                _choiceTo = CmboBox_TempTo.Items[2].ToString();
            }
            else
            {
                lbl_degreeTo.Text = "--";
            }
        }

        private void TxtBox_UserTemp_TextChanged(object sender, EventArgs e)
        {
            Bttn_Convert_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmboBox_TempFrom.Items.Add("Fahrenheit");
            CmboBox_TempFrom.Items.Add("Celsius");
            CmboBox_TempFrom.Items.Add("Kelvin");

            CmboBox_TempTo.Items.Add("Fahrenheit");
            CmboBox_TempTo.Items.Add("Celsius");
            CmboBox_TempTo.Items.Add("Kelvin");

            CmboBox_TempFrom.Text = (string)CmboBox_TempFrom.Items[0]; //Show first object from list From
            CmboBox_TempTo.Text = (string)CmboBox_TempTo.Items[0]; //Show first object from list To
        }
    }
}
