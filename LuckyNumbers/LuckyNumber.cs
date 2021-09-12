using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumbers
{
    public partial class LuckyNumber : Form
    {
        private DateTime birthday;
        private Color color;
        private Random random;
        private int lucky;

        private string[] message = {
            "Your lucky number is"
        };

        public LuckyNumber(int birthYear, byte birthMonth, byte birthDay, Color color)
        {
            InitializeComponent();
            birthday = DateTime.Parse($"{birthMonth}/{birthDay}/{birthYear}");
            this.color = color;
            random = new();
            Paint += LuckyNumber_Paint;
            lucky = random.Next(DateTime.DaysInMonth(birthYear, birthMonth));
        }

        private PointF[] StarPoints(int num_points, Rectangle bounds)
        {
            // Make room for the points.
            PointF[] pts = new PointF[num_points];

            double rx = bounds.Width / 2;
            double ry = bounds.Height / 2;
            double cx = bounds.X + rx;
            double cy = bounds.Y + ry;

            // Start at the top.
            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / num_points;
            for (int i = 0; i < num_points; i++)
            {
                pts[i] = new PointF(
                    (float)(cx + rx * Math.Cos(theta)),
                    (float)(cy + ry * Math.Sin(theta)));
                theta += dtheta;
            }

            return pts;
        }

        private void LuckyNumber_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            var b = new SolidBrush(color);
            g.Clear(Color.Black);
            List<PointF[]> stars = new();

            for(int i = 0; i < 8; i++)
            {
                int wh = random.Next(24, 36);
                stars.Add(StarPoints(5, new(random.Next(32, Width - 32), random.Next(96, 136), wh, wh)));
            }

            float r = 40 * (float)Math.PI;
            PointF loc = new(Width / 2 - (r / 2), Height - (r * 2));
            SizeF sz = g.MeasureString(message.First(), Font);
            g.DrawString(message.First(), Font, Brushes.White, new PointF(Width / 2 - sz.Width / 2, 32));
            stars.ForEach(s => g.FillPolygon(Brushes.LimeGreen, s));
            g.FillEllipse(b, new RectangleF(loc.X, loc.Y, r, r));
            loc.X *= 1.12f;
            loc.Y *= 1.12f;
            g.DrawString($"{lucky}", Font, b.Inverse(), loc);
        }
    }
}
