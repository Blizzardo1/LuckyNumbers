using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumbers
{
    public partial class LuckyWin : Form
    {
        public LuckyWin()
        {
            InitializeComponent();
            Build();
        }

        private string[] GetProperties<T>(params string[] exclude) where T : struct
        {
            var info = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Static);
            List<string> props = new();
            foreach (var i in info)
            {
                if (exclude.ToList().Any(s => i.Name == s)) continue;
                props.Add(i.Name);
            }
            return props.ToArray();
        }

        private void Build()
        {
            int currentYear = DateTime.Now.Year;

            // Hide the 3-Letter months because it's a secret!
            var years = Enumerable.Range(1900, (currentYear - 1900) + 1).ToList();
            years.Reverse();
            birthMonth.DataSource = Enum.GetNames<Month>().Except(Enum.GetNames<Month>().Where(s => s.Length == 3 && s != "May")).ToList();
            favColor.DataSource = GetProperties<Color>(exclude: "Transparent");
            birthYear.DataSource = years;
            birthYear.SelectedIndex = 0;
            birthMonth.SelectedIndex = 0;
            ComboBoxSelectedIndexChanged(this, EventArgs.Empty);
        }

        private void luckyNumber_Click(object sender, EventArgs e)
        {
            _ = int.TryParse(birthYear.Text, out int year);
            byte month = (byte)Enum.Parse<Month>(birthMonth.Text);
            _ = byte.TryParse(birthDay.Text, out byte day);
            Color color = Color.FromName(favColor.Text);
            new LuckyNumber(year, month, day, color).Show();
        }

        private void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (birthYear.Items.Count == 0) return;
            birthDay.DataSource = Enumerable.Range(1, DateTime.DaysInMonth(birthYear.ConvertText<int>(), (int)Enum.Parse<Month>(birthMonth.Text))).ToList();
        }
    }
}
