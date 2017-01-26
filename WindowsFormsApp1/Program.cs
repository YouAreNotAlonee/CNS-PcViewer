using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace WindowsFormsApp1
{
    //extern "C" __declspec(dllexport) void DLL_int_insert(int _data)
    static class Program
    {
        [DllImport("MFCLibrary1.dll")]
        public static extern void DLL_int_insert(int _data);
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DLL_int_insert(10);
            //Console.WriteLine("DLL_int_Return = {0}", )
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }
    }
}
