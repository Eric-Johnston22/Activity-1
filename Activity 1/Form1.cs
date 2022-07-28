namespace Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Displays text when button is clicked
        private void clickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for clicking :)");
            label1.Text = "You've clicked the button";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void clickNext_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.OrangeRed;
        }
    }
}