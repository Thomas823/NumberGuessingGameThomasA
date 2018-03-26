using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGameThomasA
{
    public partial class frmNumberGuessingGame : Form
    {
        // Delcare variables
        const int CORRECTANSWER = 8;
        double usersGuess;

        public frmNumberGuessingGame()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get users guess
            usersGuess = int.Parse(txtUsersGuess.Text);

            // Inform user of correct or wrong guess. Also display visual Results (Check or X), and play sound
            if (usersGuess == CORRECTANSWER)
            {
                lblAnswerResult.Text = "You Guessed Correctly!";

                this.picVisualResults.Image = Properties.Resources.checkmark;
            }
            else
            {
                lblAnswerResult.Text = "You Guessed Wrong!";

                this.picVisualResults.Image = Properties.Resources.red_x;
            }
        }
    }
}
