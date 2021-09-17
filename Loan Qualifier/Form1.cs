using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Names constants
                const decimal MINIMUM_SALARY = 40000m;
                const int MINIMUM_YEARS_ON_JOB = 2;

                // Local variables
                decimal salary;
                int yearsOnJob;

                // Get the salary and years on the job.
                salary = decimal.Parse(SalaryTextBox.Text);
                yearsOnJob = int.Parse(YearsTextBox.Text);

                // Determine whether the user qualifies.
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        // The user qualifies.
                        DecisionLabel.Text = "You qualify for the loan.";
                    }
                    else
                    {
                        // The user does not qualify.
                        DecisionLabel.Text = "Minimum years at current " + "job not met.";
                    }
                }
                else
                {
                    // The user does not qualify.
                    DecisionLabel.Text = "Minimum salary requirement " + "not met.";
                }
            }

            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the decisionLabel.
            SalaryTextBox.Text = "";
            YearsTextBox.Text = "";
            DecisionLabel.Text = "";

            // Reset the focus.
            SalaryTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
