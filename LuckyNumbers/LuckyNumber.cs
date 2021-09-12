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
        private string[] message = {
            "Your lucky number is"
        };

        public LuckyNumber(int birthYear, byte birthMonth, byte birthDay, Color color)
        {
            InitializeComponent();
            birthday = DateTime.Parse($"{birthMonth}/{birthDay}/{birthYear}");
            this.color = color;
            Paint += LuckyNumber_Paint;
        }

        // TODO: Add Random Stars around Message
        // TODO: Place Lucky Number in a Filled Circle whose Circle is the lucky color.
        private void LuckyNumber_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(Color.Black);
            SizeF sz = g.MeasureString(message.First(), Font);
            g.DrawString(message.First(), Font, Brushes.White, new PointF(Width / 2 - sz.Width / 2, 32));

        }
    }
}
