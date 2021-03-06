using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace View.UserControlHelpers
{
    public class UCHelpers
    {
        public static bool PraznoPoljeValidacija(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.BackColor = Color.Red;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }
        public static bool EmailValidacija(TextBox txt, Label label)
        {
            string email = txt.Text.Trim();

            if (!string.IsNullOrEmpty(email))
            {
                bool imarazmake = email.Contains(" ");

                int indexZnaka = email.LastIndexOf('@');

                if (indexZnaka > 0 && !imarazmake)
                {
                    string posleZnaka = email.Substring(indexZnaka + 1);

                    int indexTackePosleZnaka = posleZnaka.LastIndexOf('.');

                    if (indexTackePosleZnaka > 0 && posleZnaka.Substring(indexTackePosleZnaka).Length > 1)
                        return true;
                }
            }
            label.Text = "Neispravan format email-a!";
            return false;
        }
        public static bool VlastiteImeniceValidacija(TextBox txt, Label label)
        {

            if (char.IsLower(txt.Text[0]))
            {
                label.Text = "Početno slovo mora biti veliko!";
                return false;
            }
            else if (!txt.Text.All(char.IsLetter))
            {
                label.Text = "Dozvoljen je unos samo slova!";
                return false;
            }
            for (int i = 1; i < txt.Text.Length; i++)
            {
                if (char.IsUpper(txt.Text[i]))
                {
                    label.Text = "Sva slova osim početnog moraju biti mala!";
                    return false;
                }
            }
            txt.BackColor = Color.White;
            return true;
        }
        public static bool CenaValidacija(TextBox txt, Label label)
        {
            if (txt.Text.Contains("."))
            {
                label.Text = "Cena je ceo broj u evrima!";
                return false;
            }
            try
            {
                double broj = double.Parse(txt.Text);
                if (broj < 0)
                {
                    label.Text = "Cena mora biti pozitivna!";
                    return false;
                }
                return true;
            }
            catch (Exception)
            {

                label.Text = "Morate uneti broj!";
                return false;
            }
        }
        public static bool DatumValidacija(TextBox dtp, Label label)
        {
            if (!DateTime.TryParseExact(dtp.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("datume morate uneti u dd.MM.yyyy formatu");
                return false;
            }
            return true;
        }
        public static bool ComboBoxValidacija(ComboBox cmb, Label label)
        {
            if (cmb.SelectedItem == null)
            {
                label.Text = "Izaberite vrednost iz padajuće liste";
                return false;
            }
            //if (cmb.Items.Count == 0)
            //{
            //    label.Text = "Izaberite vrednost iz padajuće liste";
            //    return false;
            //}
            //if (cmb.DataSource == null)
            //{
            //    label.Text = "Izaberite vrednost iz padajuće liste";
            //    return false;
            //}
            return true;

        }
        public static bool TelefonValidacija(TextBox txt, Label label)
        {
            if (!txt.Text.All(char.IsDigit))
            {
                label.Text = "Može sadržati samo cifre!";
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }
    }
}