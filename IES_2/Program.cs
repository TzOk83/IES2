using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class
         | AttributeTargets.Method)]
    public sealed class ExtensionAttribute : Attribute { }
}

namespace IES_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hu-HU");
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("hu-HU");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
        /// <summary>
        /// Limit value to a certain min/max interval.
        /// </summary>
        /// <param name="value">The original value.</param>
        /// <param name="minValue">The minimum allowed value.</param>
        /// <param name="maxValue">The maximum allowed value.</param>
        /// <returns>The resulting value.</returns>
        public static decimal Limit(this decimal value, decimal minValue, decimal maxValue)
        {
            return Math.Max(minValue, Math.Min(maxValue, value));
        }
        /// <summary>
        /// Get bit flag from a byte value.
        /// </summary>
        /// <param name="value">The original value.</param>
        /// <param name="index">Bit index.</param>
        /// <returns>The resulting value.</returns>
        public static bool GetBit(this byte value, byte index)
        {
            return ((value & (byte)(1 << index)) != 0);
        }
    }
}
