using MenschenDataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Führerschein
{
    public partial class frmAnmeldung : Form
    {
        public frmAnmeldung()
        {
            InitializeComponent();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAnmeldung_Load(object sender, EventArgs e)
        {

            string BenutzerName = ""; string Password = "";
            //if (clsGlobaleKlasse.GetStoredCredential(ref BenutzerName, ref Password))
            //{
            //    txtbBenutzerName.Text = BenutzerName;
            //    txtbPassword.Text = Password;
            //    chbRememberMe.Checked = true;
            //}
            //else
            //    chbRememberMe.Checked = false;

            if(clsGlobaleKlasse.ReadDataFromFile(ref BenutzerName, ref Password))
            {
                txtbBenutzerName.Text = BenutzerName;
                txtbPassword.Text = Password;
                chbRememberMe.Checked = true;
            }
            else
                chbRememberMe.Checked = false;
        }

        private void btnAnmelden_Click(object sender, EventArgs e)
        {
            clsBenutzerDaten Benutzer = clsBenutzerDaten.FindByUserNameAndPassword(txtbBenutzerName.Text.Trim(),
                                                               txtbPassword.Text.Trim());
            //if (Benutzer != null)
            //{
            //    if (chbRememberMe.Checked)
            //    {
            //        //Store Username and Password
            //        clsGlobaleKlasse.RememberUsernameAndPassword(txtbBenutzerName.Text.Trim(),
            //                                                     txtbPassword.Text.Trim());
            //    }
            //    else
            //        //Store empty Username and Password.
            //        clsGlobaleKlasse.RememberUsernameAndPassword("", "");

            //    if (!Benutzer.IsAktive)
            //    {
            //        // incase the User is not active.
            //        txtbBenutzerName.Focus();
            //        MessageBox.Show("Ihr Account is nicht Aktive, Kontaktieren Sie Ihren Admin",
            //                      "Is Account Aktive", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    } 

            //    clsGlobaleKlasse.Benutzer = Benutzer;
            //    this.Hide();
            //    frmMain frm = new frmMain(this);
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    txtbBenutzerName.Focus();
            //    MessageBox.Show("Ungültige AnmeldeDaten", "Fehler beim Anmelden",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            if (Benutzer != null)
            {
                if (chbRememberMe.Checked)
                {
                    clsGlobaleKlasse.WriteDataToFile(txtbBenutzerName.Text, txtbPassword.Text, chbRememberMe.Checked);
                }
                else
                    clsGlobaleKlasse.WriteDataToFile(txtbBenutzerName.Text, txtbPassword.Text, false);

                if (!Benutzer.IsAktive)
                {
                    // incase the User is not active.
                    txtbBenutzerName.Focus();
                    MessageBox.Show("Ihr Account is nicht Aktive, Kontaktieren Sie Ihren Admin",
                                  "Is Account Aktive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobaleKlasse.Benutzer = Benutzer;
                this.Hide();
                frmMain frm = new frmMain(this);
                frm.ShowDialog();
            }
            else
            {
                txtbBenutzerName.Focus();
                MessageBox.Show("Ungültige AnmeldeDaten", "Fehler beim Anmelden",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void frmAnmeldung_Activated(object sender, EventArgs e)
        {
            btnAnmelden.Focus();
        }
    }
}
