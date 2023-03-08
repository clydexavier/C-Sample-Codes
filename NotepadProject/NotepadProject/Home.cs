namespace NotepadProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            ofd.Filter = sfd.Filter = "Text File (*.txt)|*.txt";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                if(ofd.FileName.EndsWith(".txt"))
                    textArea.Text = File.ReadAllText(ofd.FileName);
                //else if(ofd.FileName.EndsWith(".rtf"))
                    //
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fd.ShowDialog() == DialogResult.OK) 
            { 
                textArea.Font = fd.Font;
            }
        }

        private void plaintextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textArea.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void richtextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textArea.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
            }
        }
    }
}