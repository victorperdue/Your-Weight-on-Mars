/*
 * Victor Perdue
 * CST-150
 * Project: "Your weight on Mars"
 * 1/18/2025
 */

namespace CST_150_Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMars.Visible = false;
            lblMarsWeight.Visible = false;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Declare and Initialize
            decimal earthWeight = 0.0M;
            decimal finalValue = 0.0M;
            decimal gravAccEarth = 9.81M;
            decimal gravAccMars = 3.711M;

            // Read in the earth weight
            earthWeight = Convert.ToDecimal(txtEarthWeight.Text);

            // Calculate the final value
            finalValue = (earthWeight / gravAccEarth) * gravAccMars;

            // Display the results
            lblMarsWeight.Text = string.Format("{0:.##} lbs", finalValue);

            // Make sure to show the mars value and label
            lblMars.Visible = true;
            lblMarsWeight.Visible = true;
        }

        private void lblMarsWeight_Click(object sender, EventArgs e)
        {

        }
    }
}
