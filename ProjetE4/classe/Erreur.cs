
using System.Windows.Forms;

namespace ProjetE4
{
    public static class Erreur
    {
        public static bool ErreurHttp()
        {
            DialogResult res = MessageBox.Show("Erreur: Vous n'etes pas connecté à internet,  veuillez réessayer plus tard", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (res == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
