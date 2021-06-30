using System;
using System.Collections.Generic;
using CryptSharp;

using MySql.Data.MySqlClient;

namespace ProjetE4
{
    class bdd
    {
        private MySqlConnection connection;

        /// <summary>
        /// Connection à la BDD
        /// </summary>
        public bdd()
        {
            //creation de la connection
            string connectionString = "SERVER=127.0.0.1; DATABASE=gsb; UID=root; PASSWORD=";
            connection = new MySqlConnection(connectionString);
        }

        #region Connexion

        /// <summary>
        /// Connection en temps que adminitrateur
        /// </summary>
        /// <param name="admin">Objet Admin</param>
        /// <returns></returns>
        public bool Connexion(Admin admin)
        {
            string MDP_hacher;

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            // requete sql
            cmd.CommandText = "SELECT COUNT(*) FROM visiteur WHERE login_visiteur = @login AND type_visiteur = 'A'";

            cmd.Prepare();

            // ajout de la valeur dans la requete
            cmd.Parameters.AddWithValue("@login", admin.Login);

            cmd.ExecuteNonQuery();

            //recupere la valeur du count(*) de la requete sql
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            // Verifie que le compte existe
            if (count == 1)
            {
                // recuperation du MDP haché
                cmd.CommandText = "SELECT pwd_visiteur FROM visiteur WHERE login_visiteur = @login";

                cmd.Prepare();

                cmd.ExecuteNonQuery();


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MDP_hacher = reader.GetString(0);

                        // verifie la compatibilité de la signature avec le MDP entre
                        if (Crypter.CheckPassword(admin.Mdp, MDP_hacher))
                        {
                            break;
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }
                }

                // si la compatibilité est correct
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        #endregion

        #region Medicament

        /// <summary>
        /// Liste des familles de medicament
        /// </summary>
        /// <returns></returns>
        public List<Famille> ListeFamille()
        {
            List<Famille> liste = new List<Famille>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM famille ORDER BY lib_famille";

            cmd.Prepare();

            cmd.ExecuteNonQuery();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetString(0);
                    var nom = reader.GetString(1);

                    liste.Add(new Famille(id, nom));
                }
            }

            connection.Close();

            return liste;
        }

        /// <summary>
        /// Liste des medicaments
        /// </summary>
        /// <returns></returns>
        public List<MedicamentClass> ListeMedicament()
        {
            List<MedicamentClass> liste = new List<MedicamentClass>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM medicament M JOIN famille F ON M.id_famille = F.id_famille ORDER BY nom_commercial";

            cmd.Prepare();

            cmd.ExecuteNonQuery();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetString(0);
                    var depotL = reader.GetString(2);
                    var nom = reader.GetString(3);
                    var prix = reader.GetString(6);
                    var famille = reader.GetString(8);

                    liste.Add(new MedicamentClass(id, depotL, nom, prix, famille));
                }
            }
            connection.Close();

            return liste;
        }

        /// <summary>
        /// Liste des medicaments qui sont dans la famille demande
        /// </summary>
        /// <param name="idFam">Famille de medicament</param>
        /// <returns></returns>
        public List<MedicamentClass> ListeFiltrePar(string idFam)
        {
            List<MedicamentClass> liste = new List<MedicamentClass>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM medicament M JOIN famille F ON M.id_famille = F.id_famille WHERE F.id_famille = @idFam ORDER BY nom_commercial";

            cmd.Prepare();

            cmd.Parameters.AddWithValue("@idFam", idFam);

            cmd.ExecuteNonQuery();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetString(0);
                    var depotL = reader.GetString(2);
                    var nom = reader.GetString(3);
                    var prix = reader.GetString(6);
                    var famille = reader.GetString(8);

                    liste.Add(new MedicamentClass(id, depotL, nom, prix, famille));
                }
            }
            connection.Close();

            return liste;
        }

        /// <summary>
        /// Donne les informations sur un medicament
        /// </summary>
        /// <param name="idMedic">Id du medicament choisi</param>
        /// <returns></returns>
        public MedicamentInfos InfosMedic(string idMedic)
        {
            MedicamentInfos medic = new MedicamentInfos();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM medicament WHERE id_medicament = @idMedic";

            cmd.Prepare();

            cmd.Parameters.AddWithValue("@idMedic", idMedic);

            cmd.ExecuteNonQuery();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var effets = reader.GetString(4);
                    var contreIndication = reader.GetString(5);

                    medic.Effets = effets;
                    medic.ContreIndication = contreIndication;
                }
            }
            connection.Close();

            return medic;
        }

        /// <summary>
        /// Liste les composants du medicament
        /// </summary>
        /// <param name="idMedic">id du medicament choisi</param>
        /// <returns></returns>
        public List<CompositionMedicament> ListeCompoMedic(string idMedic)
        {
            List<CompositionMedicament> liste = new List<CompositionMedicament>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM constituer C JOIN composant CO ON C.id_composant = CO.id_composant WHERE id_medicament = @idMedic";

            cmd.Prepare();

            cmd.Parameters.AddWithValue("@idMedic", idMedic);

            cmd.ExecuteNonQuery();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var idComposant = reader.GetString(0);
                    var nomComposant = reader.GetString(4);

                    liste.Add(new CompositionMedicament(idComposant, nomComposant));
                }
            }

            connection.Close();
            return liste;
        }

        /// <summary>
        /// Supprime le composer du medicament
        /// </summary>
        /// <param name="idComposer">id du composer à supprimer des composants du medicament</param>
        /// <param name="idMedic">id du medicament selectionne</param>
        public void SuppComposerMedic(string idComposer, string idMedic)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "DELETE FROM constituer WHERE id_medicament = @idMedic AND id_composant = @idComposer";

            cmd.Prepare();

            cmd.Parameters.AddWithValue("@idMedic", idMedic);
            cmd.Parameters.AddWithValue("@idComposer", idComposer);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Modifie les informations du medicament
        /// </summary>
        /// <param name="id">id du medicament</param>
        /// <param name="idFam">id de la famille du medicament</param>
        /// <param name="nom">nom du medicament</param>
        /// <param name="contreIndi">contre indication du medicament</param>
        /// <param name="effets">Les effets du medicament</param>
        /// <param name="prix">Le prix d'echantillon du medicament</param>
        /// <param name="qte">La quantité du medicament</param>
        public void ModifierInfosMedic(string id, string idFam, string nom, string contreIndi, string effets, string prix, string qte)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "UPDATE offrir O JOIN medicament M ON O.id_medicament = M.id_medicament JOIN famille F ON F.id_famille = M.id_famille SET M.id_famille = @idFam, nom_commercial = @nom, prix_echantillon = @prix, qte_offerte = @qte, effets =@effets, contre_indication = @contreIndi WHERE O.id_medicament = @idMedic";

            cmd.Prepare();

            cmd.Parameters.AddWithValue("@idMedic", id);
            cmd.Parameters.AddWithValue("@idFam", idFam);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@contreIndi", contreIndi);
            cmd.Parameters.AddWithValue("@effets", effets);
            cmd.Parameters.AddWithValue("@prix", prix);
            cmd.Parameters.AddWithValue("@qte", qte);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// Modifie un composer du medicament
        /// </summary>
        /// <param name="idComposer">id du composer selectionne</param>
        /// <param name="idMedic">id du medicament selectionne</param>
        public void ModifierComposerMedic(string idComposer, string idNouveauComposer, string idMedic)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "UPDATE constituer SET id_composant = @idNouveauCompo WHERE id_medicament = @idMedic AND id_composant = @idCompo";

            cmd.Prepare();

            cmd.Parameters.AddWithValue("@idCompo", idComposer);
            cmd.Parameters.AddWithValue("@idNouveauCompo", idNouveauComposer);
            cmd.Parameters.AddWithValue("@idMedic", idMedic);

            cmd.ExecuteNonQuery();
            connection.Close();
        }


        #endregion

        #region Medicament offert
        /// <summary>
        /// Liste des medicaments offert
        /// </summary>
        /// <returns></returns>
        public List<MedicamentOffert> ListeMedicamentOffert()
        {
            List<MedicamentOffert> liste = new List<MedicamentOffert>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT O.id_medicament, nom_commercial, qte_offerte, depot_legal FROM offrir O JOIN medicament M ON O.id_medicament = M.id_medicament ORDER BY nom_commercial";

            cmd.Prepare();

            cmd.ExecuteNonQuery();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetString(0);
                    var nom = reader.GetString(1);
                    var qte = reader.GetString(2);
                    var depot = reader.GetString(3);

                    liste.Add(new MedicamentOffert(id, nom, qte, depot));
                }
            }

            connection.Close();
            return liste;
        }

        /// <summary>
        /// Donne les informations sur un medicament offert
        /// </summary>
        /// <param name="idMedic">id du medicament offert</param>
        /// <returns></returns>
        public MedicamentOffertInfos ListeInfosMedicOffert(string idMedic)
        {
            MedicamentOffertInfos medic = new MedicamentOffertInfos();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT O.id_medicament, qte_offerte, nom_commercial, effets, contre_indication, prix_echantillon, M.id_famille, lib_famille FROM offrir O JOIN medicament M ON O.id_medicament = M.id_medicament JOIN famille F ON F.id_famille = M.id_famille WHERE O.id_medicament = @idMedic";

            cmd.Prepare();

            cmd.Parameters.AddWithValue("@idMedic", idMedic);

            cmd.ExecuteNonQuery();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetString(0);
                    var qte = reader.GetString(1);
                    var nom = reader.GetString(2);
                    var effets = reader.GetString(3);
                    var contreIndication = reader.GetString(4);
                    var prix = reader.GetString(5);
                    var idFamille = reader.GetString(6);
                    var nomFamille = reader.GetString(7);

                    medic.InfosMedic(id, nom, effets, contreIndication, qte, prix, idFamille, nomFamille);
                }
            }
            connection.Close();

            return medic;
        }

        /// <summary>
        /// Supprime un medicament offert
        /// </summary>
        /// <param name="idMedicOffert">id du medicament offert</param>
        public void SuppMedicOffert(string idMedicOffert)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "DELETE FROM offrir WHERE id_medicament = @idMedicOffert";

            cmd.Prepare();

            cmd.Parameters.AddWithValue("@idMedicOffer", idMedicOffert);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
        #endregion

        #region Composant

        /// <summary>
        /// Liste des composants
        /// </summary>
        /// <returns></returns>
        public List<Composant> ListeComposant()
        {
            List<Composant> liste = new List<Composant>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM composant ORDER BY lib_composant";

            cmd.Prepare();

            cmd.ExecuteNonQuery();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var idComposant = reader.GetString(0);
                    var nomComposant = reader.GetString(1);

                    liste.Add(new Composant(idComposant, nomComposant));
                }
            }

            connection.Close();
            return liste;
        }

        /// <summary>
        /// Ajouter un composant
        /// </summary>
        /// <param name="nomComposant">nom du composant</param>
        public void AjoutComposant(string nomComposant)
        {

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO composant(lib_composant) VALUES (@nomComposant)";

            //protection contre les injection SQL
            cmd.Prepare();

            //affectation de la varialbe passer en parametre
            cmd.Parameters.AddWithValue("@nomComposant", nomComposant);

            //execution de la requete SQL
            cmd.ExecuteNonQuery();

            //fermeture de la connection a la BDD
            connection.Close();
        }

        #endregion

        #region Rapport de visiste

        /// <summary>
        /// Liste des rapports de visite
        /// </summary>
        /// <returns></returns>
        public List<Rapport_visite> listRapport()
        {
            List<Rapport_visite> listeRapport = new List<Rapport_visite>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM rapport_visite JOIN praticien ON rapport_visite.id_praticien = praticien.id_praticien JOIN visiteur ON visiteur.id_visiteur = rapport_visite.id_visiteur;";

            cmd.Prepare();

            cmd.ExecuteNonQuery();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var date = reader.GetString(3);
                    var bilan = reader.GetString(4);
                    var motif = reader.GetString(5);
                    var nom_praticien = reader.GetString(8);
                    var prenom_praticien = reader.GetString(9);
                    var coef = reader.GetString(13);
                    var nom_visiteur = reader.GetString(17);
                    var prenom_visteur = reader.GetString(18);

                    listeRapport.Add(new Rapport_visite(date, nom_praticien, prenom_praticien, coef, nom_visiteur, prenom_visteur, motif, bilan));
                }
            }

            connection.Close();

            return listeRapport;
        }

        /// <summary>
        /// Liste les rapport du praticien
        /// </summary>
        /// <param name="nomPraticien">Nom du praticien</param>
        /// <returns></returns>
        public List<Rapport_visite> ListeRapport(string nomPraticien)
        {
            List<Rapport_visite> liste = new List<Rapport_visite>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM rapport_visite JOIN praticien ON rapport_visite.id_praticien = praticien.id_praticien JOIN visiteur ON visiteur.id_visiteur = rapport_visite.id_visiteur WHERE nom_praticien LIKE @nom";

            cmd.Prepare();

            cmd.Parameters.AddWithValue("@nom", "%" + nomPraticien + "%");

            cmd.ExecuteNonQuery();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var date = reader.GetString(3);
                    var bilan = reader.GetString(4);
                    var motif = reader.GetString(5);
                    var nom_praticien = reader.GetString(8);
                    var prenom_praticien = reader.GetString(9);
                    var coef = reader.GetString(13);
                    var nom_visiteur = reader.GetString(17);
                    var prenom_visteur = reader.GetString(18);

                    liste.Add(new Rapport_visite(date, nom_praticien, prenom_praticien, coef, nom_visiteur, prenom_visteur, motif, bilan));
                }
            }

            connection.Close();

            return liste;
        }

        /// <summary>
        /// Liste des rapports d'une date
        /// </summary>
        /// <param name="date">date format Date</param>
        /// <returns></returns>
        public List<Rapport_visite> ListeRapportDate(DateTime date)
        {
            List<Rapport_visite> liste = new List<Rapport_visite>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM rapport_visite JOIN praticien ON rapport_visite.id_praticien = praticien.id_praticien JOIN visiteur ON visiteur.id_visiteur = rapport_visite.id_visiteur WHERE date_rapport = @date";

            cmd.Prepare();

            cmd.Parameters.AddWithValue("@date", date.Date);

            cmd.ExecuteNonQuery();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var dateR = reader.GetString(3);
                    var bilan = reader.GetString(4);
                    var motif = reader.GetString(5);
                    var nom_praticien = reader.GetString(8);
                    var prenom_praticien = reader.GetString(9);
                    var coef = reader.GetString(13);
                    var nom_visiteur = reader.GetString(17);
                    var prenom_visteur = reader.GetString(18);

                    liste.Add(new Rapport_visite(dateR, nom_praticien, prenom_praticien, coef, nom_visiteur, prenom_visteur, motif, bilan));
                }
            }

            connection.Close();

            return liste;
        }

        /// <summary>
        /// Ajouter un rapport de visite
        /// </summary>
        /// <param name="idPrat">id du praticien</param>
        /// <param name="idVisi">id du visiteur</param>
        /// <param name="motif">motif</param>
        /// <param name="bilan">bilan</param>
        public void AjoutRapport(string idPrat, string idVisi, string motif, string bilan)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "INSERT INTO rapport_visite (id_praticien, id_visiteur, date_rapport, bilan, motif) VALUES (@idPrat, @idVisi, @date, @bilan, @motif)";

            cmd.Prepare();

            DateTime date = DateTime.Today;

            //affectation de la varialbe passer en parametre
            cmd.Parameters.AddWithValue("@idPrat", idPrat);
            cmd.Parameters.AddWithValue("@idVisi", idVisi);
            cmd.Parameters.AddWithValue("@motif", motif);
            cmd.Parameters.AddWithValue("@bilan", bilan);
            cmd.Parameters.AddWithValue("@date", date);

            cmd.ExecuteNonQuery();

            connection.Close();

        }

        /// <summary>
        /// Liste de tous les praticiens
        /// </summary>
        /// <returns></returns>
        public List<Praticien> ListePratiicien()
        {
            List<Praticien> liste = new List<Praticien>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM praticien";

            cmd.Prepare();

            cmd.ExecuteNonQuery();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetString(0);
                    var nom = reader.GetString(2);
                    var prenom = reader.GetString(3);

                    liste.Add(new Praticien(id, nom, prenom));
                }
            }
            connection.Close();
            return liste;
        }

        /// <summary>
        /// Liste des visiteurs
        /// </summary>
        /// <returns></returns>
        public List<Visiteur> ListeVisiteur()
        {
            List<Visiteur> liste = new List<Visiteur>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM visiteur ORDER BY nom_visiteur";

            cmd.Prepare();

            cmd.ExecuteNonQuery();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetString(0);
                    var nom = reader.GetString(3);
                    var prenom = reader.GetString(4);

                    liste.Add(new Visiteur(id, nom, prenom));
                }
            }

            connection.Close();
            return liste;
        }
        #endregion

    }
}
