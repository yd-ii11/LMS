namespace LMS
{
    public partial class LMS : Form
    {
        public LMS()
        {
            InitializeComponent();
        }

        public bool IsStudent;
        private void Login_Click(object sender, EventArgs e)
        {
            IsStudent = ID.Text == "1234";

            Close();
        }
    }
}
