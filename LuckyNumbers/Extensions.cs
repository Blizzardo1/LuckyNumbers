using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumbers
{
    internal static class Extensions
    {
        public static T[] GetProperties<T>(this T t) where T: struct
        {
            var info = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Static);
            List<T> props = new();
            foreach(var i in info)
            {
                props.Add((T)i.GetValue(t));
            }
            return props.ToArray();
        }

        public static T ConvertText<T>(this Control c) where T: struct, IConvertible
        {
            return (T)Convert.ChangeType(c.Text, typeof(T));
        }

        public static Brush Inverse(this Brush brush) => new SolidBrush(Color.FromArgb(((SolidBrush)brush).Color.ToArgb() ^ 0xFFFFFF));
    }
}
