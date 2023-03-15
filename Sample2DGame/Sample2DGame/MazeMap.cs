using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2DGame
{
    public class MazeMap
    {
        private MazeElements[,] field;

        public Size MapDimensions
        {
            get
            {
                return new Size(this.field.GetLength(0), this.field.GetLength(1));
            }
        }

        public MazeMap(MazeElements[,] field)
        {
            this.field = new MazeElements[field.GetLength(0), field.GetLength(1)];
            for(int i=0; i < this.field.GetLength(0); i++)
                for(int j=0; j < this.field.GetLength(1); j++)
                    this.field[i, j] = field[j, i];
        }

        public void Render(Graphics g, Size canvasSize)
        {
            for (int i = 0; i < this.field.GetLength(0); i++)
            {
                for (int j = 0; j < this.field.GetLength(1); j++)
                {
                    if (this.field[i,j] == MazeElements.Grass)
                    {
                        g.DrawImage(Properties.Resources.grass, new Rectangle(i*(canvasSize.Width/this.field.GetLength(0)), j* (canvasSize.Height / this.field.GetLength(1)), (canvasSize.Width / this.field.GetLength(0)), (canvasSize.Height / this.field.GetLength(1))));
                    }
                    else if (this.field[i, j] == MazeElements.Wall)
                    {
                        g.DrawImage(Properties.Resources.wall, new Rectangle(i * (canvasSize.Width / this.field.GetLength(0)), j * (canvasSize.Height / this.field.GetLength(1)), (canvasSize.Width / this.field.GetLength(0)), (canvasSize.Height / this.field.GetLength(1))));
                    }
                }
            }
        }

        public bool IsValidCharacterDestination(int x, int y)
        {
            return x >= 0 && x < this.field.GetLength(0) && y >= 0 && y < this.field.GetLength(1) && this.field[x, y] == MazeElements.Grass;
        }
    }
}
