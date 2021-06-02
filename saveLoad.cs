using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rm_idle
{
    class saveLoad
    {
        public static bool saveData()
        {
            var sfdlg = new SaveFileDialog
            {
                Title = "Save Game",
                Filter = "rm-Clicker Save (*.rmc)|*.rmc|All files (*.*)|*.*",
                FilterIndex = 1,
                FileName = "save.rmc",
                RestoreDirectory = true
            };

            if (sfdlg.ShowDialog() == DialogResult.OK)
            {
                Program.rawsavedata = new string[27];
                Program.filepath = sfdlg.FileName; // Stores full path
                var success = convertToRaw();
                if (success == false) return false;
                File.WriteAllLines(Program.filepath, Program.rawsavedata);
            }
            else
            {
                return false;
            }
            return true;
        }

        public static bool loadData()
        {
            var fdlg = new OpenFileDialog
            {
                Title = "Load Save",
                Filter = "rm-Clicker Save (*.rmc)|*.rmc|All files (*.*)|*.*",
                FilterIndex = 1,
                FileName = "save.rmc",
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true
            };
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                Program.filepath = fdlg.FileName; // Stores full path
                Program.rawsavedata = new string[27]; // create savedata array
                Program.convsavedata = new int[27]; // create convdata array
                Program.rawsavedata = File.ReadAllLines(Program.filepath);
                var success = convertToData(Program.rawsavedata);
                if (success == false) return false;
            }
            else
            {
                MessageBox.Show("Something went wrong. Check folder access and try again. (E01)", "Load File Error");
                return false;
            }
            return true;
        }

        static bool convertToData(string[] raw)
        {
            try
            {
                for (int i = 0; i < raw.Length; i++)
                {
                    int.TryParse(raw[i], out Program.convsavedata[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("File cannot be read. Please check for modifications, and try again. (E02)", "File Conversion Error");
                return false;
            }
            return true;
        }

        static bool convertToRaw()
        {
            try
            {
                for (int i = 0; i < Program.dirtysavedata.Length; i++)
                {
                    Program.rawsavedata[i] = Program.dirtysavedata[i].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("File conversion error - please report this on GitHub. (E04)","File Conversion Error");
                return false;
            }
            return true;
        }
    }
}
