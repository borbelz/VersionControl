using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_gyak_GJYYX0
{
    public partial class Form1 : Form
    {
        public class Ball : Label
        {
            public Ball()
            {
                AutoSize = false;
                Width = 50;
                Height = Width;
                Paint += Ball_Paint;
            }

            public void Ball_Paint(object sender, PaintEventArgs e)
            {
                DrawImage(e.Graphics);
            }

            protected void DrawImage(Graphics g)
            {
                g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
            }


            public void MoveBall()
            {
                Left += 1;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }
    }
}
