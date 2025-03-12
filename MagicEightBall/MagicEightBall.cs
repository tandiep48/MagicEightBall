using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicEightBall
{
    public partial class MagicEightBall : Form
    {
        private readonly Random rndChoice = new Random();
        public MagicEightBall()
        {
            InitializeComponent();
        }


        private void txtBoxUser_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbViewChat.Items.Add("Me: " + txtBoxUser.Text);
                MagicBallThinking();
            }
        }

        private void btnEnter_Click(object sender, System.EventArgs e)
        {
            lbViewChat.Items.Add("Me: " + txtBoxUser.Text);
            MagicBallThinking();
        }
        private async void MagicBallThinking()
        {
            txtBoxUser.Enabled = !txtBoxUser.Enabled;
            btnEnter.Enabled = !btnEnter.Enabled;
            lbViewChat.Items.Add("Magic ball: ......");
            await SetTimeout(2000, MagicBallAnswer);
        }
        private void MagicBallAnswer()
        {
            lbViewChat.Items.Add("Magic ball: " + AnswerGroup.awsArray[rndChoice.Next(1, AnswerGroup.awsArray.Length)]);
            txtBoxUser.Enabled = !txtBoxUser.Enabled;
            btnEnter.Enabled = !btnEnter.Enabled;
            txtBoxUser.Clear();
        }
        private async Task SetTimeout(int milisecond, Action action)
        {
            await Task.Delay(milisecond);
            action();
        }
    }
}
