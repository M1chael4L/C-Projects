namespace Istinski_med
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            addUserControl(home);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Bees bees = new Bees();
            addUserControl(bees);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Contacts contacts = new Contacts();
            addUserControl(contacts);
        }
    }
}
