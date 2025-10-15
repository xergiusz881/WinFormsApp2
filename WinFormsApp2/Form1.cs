namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        char player = 'X';
        public Form1()
        {
            InitializeComponent(); currentplayerLabel.Text = "teraz gra " + player.ToString();
            
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = player.ToString();
            if (player == 'X')
            {
                player = 'O';
            }
            else
            {
                player = 'X';
            }
            currentplayerLabel.Text = "teraz gra " + player.ToString();
            button.Enabled = false;

            panel1.Text = "Teraz gra: " + player.ToString();
            
            
        
            char? winner = CheckWinner();
            if (winner != null)
            {
                MessageBox.Show("Wygra³: " + winner.ToString());
                Application.Restart();
            }
            else if (CheckTie())
            {
                MessageBox.Show("Remis!");
                Application.Restart();
            }
        }

        private bool CheckTie()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button button && button.Enabled)
                {
                    return false;
                }
            }
            return true;

        }
        private char? CheckWinner()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")

                return button1.Text[0];
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
                return button4.Text[0];
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
                return button7.Text[0];
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
                return button1.Text[0];
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
                return button2.Text[0];
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
                return button3.Text[0];
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
                return button1.Text[0];
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
                return button3.Text[0];


            return null;

        }

    }
}

