namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        char player = 'x';
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = player.ToString();
            if (player == 'x')
                player = 'o' ;
            else
                player = 'x';
            button.Enabled = false;
        }
    }
}
