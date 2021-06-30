using System;
using System.Windows.Forms;

namespace ProjetE4
{
    public partial class Form_connexion : Form
    {
        private Admin admin;
        private bdd Bdd;

        public Form_connexion()
        {
            InitializeComponent();
            Bdd = new bdd();

            tb_login.Focus();
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_login.Text != "" && tb_mdp.Text != "")
                {
                    string login = tb_login.Text;
                    string mdp = tb_mdp.Text;

                    //verifie si l'utilisateur a les bon logs
                    if (Bdd.Connexion(new Admin(login, mdp)))
                    {
                        // creation d'un admin
                        admin = new Admin(login, mdp);

                        // remet les variables à blanc
                        tb_login.Text = tb_mdp.Text = login = mdp = "";

                        // redirection sur le component accueil
                        Accueil accueil = new Accueil(admin);
                        accueil.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("login ou mot de passe incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez completer les champs !");
                }
            }
            catch (Exception ex)
            {
                if (Erreur.ErreurHttp())
                {
                    this.Close();
                }
            }
        }
    }
}
