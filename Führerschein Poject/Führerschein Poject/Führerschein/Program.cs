using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Führerschein
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
            //Application.Run(new frmFindePerson());
            // Application.Run(new frmBenutzerListe());
            //Application.Run(new frmAddUpdateBenutzer());
            //Application.Run(new frmFindePerson());
            //Application.Run(new frmAnträgeBildschirm());

            // Application.Run(new frmTestTypeListe());
            //Application.Run(new frmAntragZumNeuenLokalenFührerschein());
             Application.Run(new frmAnmeldung());
            //Application.Run(new FrmLokalerFührerscheinAntragsListe());
            // Application.Run(new frmTestTerminListe());
           //Application.Run(new frmBeschädigterOderVerlorenerFührerscheinErsetzen());
          // Application.Run(new frmLokalerFührerscheinErneuern());
            
        }
    }
    
}
