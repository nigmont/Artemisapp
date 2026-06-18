using System;
using System.Windows.Forms;

namespace Artemisapp_UX
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin()); //desde que formularo va inicializar 
        }
    }
}