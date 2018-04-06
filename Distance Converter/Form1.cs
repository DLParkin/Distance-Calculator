using System;
using System.Windows.Forms;
/// <summary>
/// Convert measurements to different types based on user input.
/// By: David Parkin
/// Date: 24/03/2018
/// </summary>
namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        // 1 inch = 2.54 cm
        const double inchToCm = 2.54;
        // 1 foott = 0.3048 meters
        const double footToMtr = 0.3048;
        // 1 yard = 0.9144 meters
        const double yardToMtr = 0.9144;
        // 1 mile = 1.609 km
        const double mileToKm = 1.609; 
        
        public Form1()
        {
            InitializeComponent();
        }

        // inches to centimeters
        private void btnInchToCent_Click(object sender, EventArgs e)
        {
            // clear results before calculating
            ClearResults();

            double convertedToCM = 0; 
            // Check if no input
            if (txtConvertedResult == null)
            {
                MessageBox.Show("You have not entered a number to convert.\n" +
                    "Please enter a number.","Invalid Number");
                txtValueToChange.Clear();
                txtValueToChange.Focus();
            }
            // check that input is of a valid type
            else if (!double.TryParse(txtValueToChange.Text, out convertedToCM))
            {
                MessageBox.Show("You have not entered a valid number.\nPlease " +
                    "try again.","Invalid Number");
                txtValueToChange.Clear();
                txtValueToChange.Focus();
            }
            else if (convertedToCM <= 0)
            {
                MessageBox.Show("Negative Number entered!", "Invalid Number");
                txtValueToChange.Clear();
                txtValueToChange.Focus();
            }
            else
            {
                convertedToCM = convertedToCM * inchToCm;

                // format the output
                lblConvertFrom.Text = "inches";
                lblEqualsSign.Text = "=";
                txtConvertedResult.Visible = true;
                txtConvertedResult.Text = convertedToCM.ToString();
                lblConvertedTo.Text = "centimeters";
            }
        }

        // feet to meters
        private void btnFeetToMeters_Click(object sender, EventArgs e)
        {
            // clear results before calculating
            ClearResults();

            double convertedToMeters = 0;
            // Check if no input
            if (txtConvertedResult == null)
            {
                MessageBox.Show("You have not entered a number to convert.\n" +
                    "Please enter a number.","Invalid Number");
                txtValueToChange.Clear();
                txtValueToChange.Focus();
            }
            // check that input is of a valid type
            else if (!double.TryParse(txtValueToChange.Text, out convertedToMeters))
            {
                MessageBox.Show("You have not entered a valid number.\nPlease " +
                    "try again.","Invalid Number");
                txtValueToChange.Clear();
                txtValueToChange.Focus();
            }
            else if (convertedToMeters <= 0)
            {
                MessageBox.Show("Negative Number entered!", "Invalid Number");
                txtValueToChange.Clear();
                txtValueToChange.Focus();
            }
            else
            {
                convertedToMeters = convertedToMeters * footToMtr;

                // format the output
                lblConvertFrom.Text = "feet";
                lblEqualsSign.Text = "=";
                txtConvertedResult.Visible = true;
                txtConvertedResult.Text = convertedToMeters.ToString();
                lblConvertedTo.Text = "meters";
            }
        }

        // yards to meters
        private void btnYardsToMeters_Click(object sender, EventArgs e)
        {
            // clear results before calculating
            ClearResults();

            double convertedToMeters = 0;
            // Check if no input
            if (txtValueToChange == null)
            {
                MessageBox.Show("You have not entered a number to convert.\n" +
                    "Please enter a number.", "Invalid Number");
                txtValueToChange.Clear();
                txtValueToChange.Focus();
            }
            // check that input is of a valid type
            else if (!double.TryParse(txtValueToChange.Text, out convertedToMeters))
            {
                MessageBox.Show("You have not entered a valid number.\nPlease " +
                    "try again.","Invalid Number");
                txtValueToChange.Clear();
                txtValueToChange.Focus();
            }
            else if (convertedToMeters <= 0)
            {
                MessageBox.Show("Negative Number entered!", "Invalid Number");
                txtValueToChange.Clear();
                txtValueToChange.Focus();
            }
            else
            {
                convertedToMeters = convertedToMeters * yardToMtr;

                // format the output
                lblConvertFrom.Text = "yards";
                lblEqualsSign.Text = "=";
                txtConvertedResult.Visible = true;
                txtConvertedResult.Text = convertedToMeters.ToString();
                lblConvertedTo.Text = "meters";
            }
        }

        // miles to kilometers
        private void btnMilesToKilometers_Click(object sender, EventArgs e)
        {
            // clear results before calculating
            ClearResults();

            double convertedToKilometers = 0;
            // Check if no input
            if (txtConvertedResult == null)
            {
                MessageBox.Show("You have not entered a number to convert.\n" +
                    "Please enter a number.","Invalid Number");
                txtValueToChange.Clear();
                txtValueToChange.Focus();
            }
            // check that input is of a valid type
            else if (!double.TryParse(txtValueToChange.Text, out convertedToKilometers))
            {
                MessageBox.Show("You have not entered a valid number.\nPlease " +
                    "try again.","Invalid Number");
                txtValueToChange.Clear();
                txtValueToChange.Focus();
            }
            else if (convertedToKilometers <= 0)
            {
                MessageBox.Show("Negative Number entered!", "Invalid Number");
                txtValueToChange.Clear();
                txtValueToChange.Focus();
            }
            else
            {
                convertedToKilometers = convertedToKilometers * mileToKm;

                // format the output
                lblConvertFrom.Text = "miles";
                lblEqualsSign.Text = "=";
                txtConvertedResult.Visible = true;
                txtConvertedResult.Text = convertedToKilometers.ToString();
                lblConvertedTo.Text = "kilometers";
            }
        }
        // exit button to close the form.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // clear results for next calculation
        public void ClearResults()
        {
            lblConvertFrom.Text = "";
            lblEqualsSign.Text = "";
            txtConvertedResult.Visible = false;
            lblConvertedTo.Text = "";
        }
    }
}
