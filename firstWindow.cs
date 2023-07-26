using System.Windows.Forms;

namespace BackGammonProject
{
    public partial class firstWindow : Form
    {
        gameWindow gameWindow;
        public firstWindow()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, System.EventArgs e)
        {
                Hide();
                gameWindow = new gameWindow(textBox1.Text, textBox2.Text);
                gameWindow.Show();
        }
        private void enterPress(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Hide();
                gameWindow = new gameWindow(textBox1.Text, textBox2.Text);
                gameWindow.Show();
            }
        }
    }
}
