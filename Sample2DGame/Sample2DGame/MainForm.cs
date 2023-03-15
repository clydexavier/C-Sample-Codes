namespace Sample2DGame
{
    public partial class MainForm : Form
    {
        MazeMap m;
        Point mainChar;
        Point finishLine;

        public MainForm()
        {
            InitializeComponent();
            MazeElements[,] mapData = new MazeElements[,]
            {
                { MazeElements.Grass, MazeElements.Grass, MazeElements.Grass, MazeElements.Grass, MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Wall},
                { MazeElements.Grass, MazeElements.Wall, MazeElements.Wall, MazeElements.Wall, MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Grass},
                { MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Wall, MazeElements.Wall, MazeElements.Grass},
                { MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Grass},
                { MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Wall},
                { MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Grass},
                { MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Wall, MazeElements.Wall, MazeElements.Grass},
                { MazeElements.Grass, MazeElements.Grass, MazeElements.Grass, MazeElements.Wall, MazeElements.Grass, MazeElements.Grass, MazeElements.Grass, MazeElements.Grass}
            };

            m = new MazeMap(mapData);
            mainChar = new Point(2, 6);
            finishLine = new Point(6, 0);
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            Graphics g = canvas.CreateGraphics();
            //map
            m.Render(g, canvas.Size);
            //char
            g.DrawImage(Properties.Resources.character, new Rectangle(mainChar.X * (canvas.Size.Width / m.MapDimensions.Width), mainChar.Y * (canvas.Size.Height / m.MapDimensions.Height), (canvas.Size.Width / m.MapDimensions.Width), (canvas.Size.Height / m.MapDimensions.Height)));
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            this.canvas_Click(sender, e);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W: if (m.IsValidCharacterDestination(mainChar.X, mainChar.Y - 1)) mainChar.Y--;
                    break;
                case Keys.S:
                    if (m.IsValidCharacterDestination(mainChar.X, mainChar.Y + 1)) mainChar.Y++;
                    break;
                case Keys.A:
                    if (m.IsValidCharacterDestination(mainChar.X-1, mainChar.Y)) mainChar.X--;
                    break;
                case Keys.D:
                    if (m.IsValidCharacterDestination(mainChar.X+1, mainChar.Y)) mainChar.X++;
                    break;
            }
            canvas_Click(sender, e);
            if (mainChar.Equals(finishLine))
                MessageBox.Show("You win!");
        }
    }
}