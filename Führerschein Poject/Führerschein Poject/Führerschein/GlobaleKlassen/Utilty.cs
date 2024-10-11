using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace Führerschein.Klassen
{
    internal class clsUtil
    {
        public static string GenerateGUID()
        {
            // generate a new GUID
            Guid newGuid = Guid.NewGuid();
            // convert the GUID to string
            return newGuid.ToString();
        }

        public static bool CreateFolderIfDoesNotExist(string OrdnerPfad)
        {
            // check if the Order exist
            if(!Directory.Exists(OrdnerPfad))
            {
                try
                {
                    // if dose not exist, create a new folder
                    Directory.CreateDirectory(OrdnerPfad);
                    return true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Fehler beim Erstellen eines Orders: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static string ReplaceFileNameWithGUID(string QuellDatei)
        {
            //change your file name
            string DateiName = QuellDatei;
            FileInfo fil = new FileInfo(DateiName);
            string exten = fil.Extension;
            return GenerateGUID() + exten;
        }

        public static bool CopyImageToProjectImagesFolder(ref string QuellDatei)
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.

            string ZielOrdner = @"C:\Führerschein_Menschen_Fotos\";
            if(!CreateFolderIfDoesNotExist(ZielOrdner))
            {
                return false;
            }

            string ZielDatei = ZielOrdner + ReplaceFileNameWithGUID(QuellDatei);
            try
            {
                File.Copy(QuellDatei, ZielDatei, true);
            }
            catch(IOException iox)
            {
                MessageBox.Show(iox.Message, "FehlerMeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            QuellDatei = ZielDatei;
            return true;
        }

    }
}
