using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorLayerConversion
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //PolygonCreator pc = new PolygonCreator();
            //pc.Polygonize(@"C:\Users\rez\Pictures\Saburov\cosmoPictures\L1C_T39VVJ_A020238_20190508T080610.tif");
        }
    }
}
