using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using XIGNCODE_ByPasser_By_DEMONKINGLBH;

namespace XIGNCODE_ByPasser_By_DEMONKINGLBH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " XIGNCODE ByPasser By DEMONKINGLBH";
            ConsoleKeyInfo cki;
            Console.WriteLine("Welcome..");
            Console.WriteLine("");
            Console.WriteLine("We are ready to f*ck up XIGNCODE. Press any key to continue....");
            Console.ReadKey();
            Console.Clear();

            #region Bypass
            ProcessSuspender.FuckUpThePROTECTION("x3.xem", ProcessSuspender.SUSPEND_RESUME.Suspend);
            ProcessSuspender.FuckUpThePROTECTION("xcorona.xem", ProcessSuspender.SUSPEND_RESUME.Suspend);
            ProcessSuspender.FuckUpThePROTECTION("xcorona_x64.xem", ProcessSuspender.SUSPEND_RESUME.Suspend);
            ProcessSuspender.FuckUpThePROTECTION("xm.exe", ProcessSuspender.SUSPEND_RESUME.Suspend);
            ProcessSuspender.FuckUpThePROTECTION("xmag.xem", ProcessSuspender.SUSPEND_RESUME.Suspend);
            ProcessSuspender.FuckUpThePROTECTION("xnina.xem", ProcessSuspender.SUSPEND_RESUME.Suspend);
            ProcessSuspender.FuckUpThePROTECTION("xxd-0.xem", ProcessSuspender.SUSPEND_RESUME.Suspend);
            MessageBox.Show("Now, you can Load your hacks easily :D");
            MessageBox.Show("When you load your hacks, Click OK ;)");
            ProcessSuspender.FuckUpThePROTECTION("x3.xem", ProcessSuspender.SUSPEND_RESUME.Resume);
            ProcessSuspender.FuckUpThePROTECTION("xcorona.xem", ProcessSuspender.SUSPEND_RESUME.Resume);
            ProcessSuspender.FuckUpThePROTECTION("xcorona_x64.xem", ProcessSuspender.SUSPEND_RESUME.Resume);
            ProcessSuspender.FuckUpThePROTECTION("xm.exe", ProcessSuspender.SUSPEND_RESUME.Resume);
            ProcessSuspender.FuckUpThePROTECTION("xmag.xem", ProcessSuspender.SUSPEND_RESUME.Resume);
            ProcessSuspender.FuckUpThePROTECTION("xnina.xem", ProcessSuspender.SUSPEND_RESUME.Resume);
            ProcessSuspender.FuckUpThePROTECTION("xxd-0.xem", ProcessSuspender.SUSPEND_RESUME.Resume);
            #endregion

            Console.WriteLine("Completed :* !!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Thanks for using || XIGNCODE ByPasser By DEMONKINGLBH ||");
            Console.WriteLine("Hope you enjoyed hacking PB with the Queen Of Hacks O:) ");
            Console.WriteLine("");
            Console.WriteLine("Press ESC to close...");
            do
            {
                cki = Console.ReadKey();
            }
            while (cki.Key != ConsoleKey.Escape);
        }
    }
}
