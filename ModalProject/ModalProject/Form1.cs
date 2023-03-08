namespace ModalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm c = new ChildForm();
            c.MdiParent = this;
            c.Show();
        }
    }
}