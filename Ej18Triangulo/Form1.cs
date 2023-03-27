using System.Security.Policy;

namespace Ej18Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Triangle
        {
           public int Base { get; set; }
            public int Side { get; set; }
            public int Height { get; set; }

            public Triangle(int Base, int Side,int Height)
            {
                this.Base = Base;
                this.Side = Side;
                this.Height = Height;
            }
           
        }
        Triangle tri = new Triangle(0,0,0);
        private void buttonEquilateral_Click(object sender, EventArgs e)
        {
            if(tri.Base== tri.Height && tri.Height== tri.Side)
            {
                MessageBox.Show("The triangle is a equilater: ");
            }
            else
            {
                MessageBox.Show("The triangle is not a equilater");
            }

        }

        private void buttonSide_Click(object sender, EventArgs e)
        {
           

            int max = tri.Side;

            if (tri.Base > max)
            {
                max = tri.Base;
            }

            if (tri.Height > max)
            {
                max = tri.Height;
            }

            MessageBox.Show("The long side is: " + max);

        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            int area = tri.Base * tri.Height / 2;
            MessageBox.Show("The Area  is: " + area);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {



                tri.Base = (int)numericBase.Value;
                tri.Height= (int)numericHeight.Value;
                tri.Side = (int)numericSide.Value;
                if (tri.Base <= 0 && tri.Side <= 0 && tri.Height <= 0)
                {
                    MessageBox.Show("Introduce un valor mayor a 0 en los tres campos");
                }
            
            



        }
    }
}