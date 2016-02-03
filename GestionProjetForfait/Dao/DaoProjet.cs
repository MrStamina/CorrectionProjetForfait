using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

// NameSpaces ajoutés
using System.Data.SqlClient;
using System.Data;
// Pour lecture fichier config (il faut ajouter la reference au projet)
using System.Configuration;

using GestionProjetForfait.Exceptions;

// =========================================================================================================//
// Les informations de connexion sont obtenues à partir du fichier de config                                //
// J'ai utilisé une procédure stockée ADDProjet et UPDProjet                                                //
// L'affectation des parametres de la commande a été refactorisée ==> création de la méthode AffectParamCde //
// L'affectation du parametre codeprojet n'a pas été factorisée : en entrée pour update,en sortie pour add  //
// L'affectation du type de projet n'est faite qu'en ajout                                                  //
// Ne pas passer le parametre contact ou mailContact à la procédure stockée si pas saisis                   //
// Ils doivent être définis avec une valeur par défaut NULL dans la procédure stockée                       //
// =========================================================================================================//

namespace GestionProjetForfait.Dao
{

    using GestionProjetForfait.Metier;
    class DaoProjet
    {
        private static SqlConnection GetConnection()
        {
            // creation de la connection
            SqlConnection sqlConnect = new SqlConnection();
            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["ConGesProjet"];
            // affectation de la chaine de connection extraite
            if (oConfig == null) // chaine de connexion non trouvée
                throw new DaoExceptionFinAppli("La base est inaccessible, l'appplication va se fermer, recommencez ultérieurement: \n" + "La chaine de connexion est introuvable");
            else
            {
                sqlConnect.ConnectionString = oConfig.ConnectionString;
                try
                {
                    // Ouvre la connection.
                    sqlConnect.Open();
                    return sqlConnect;
                }
                catch (SqlException se)
                {
                    throw new DaoExceptionFinAppli("La base est inaccessible, l'appplication va se fermer, recommencez ultérieurement : \n" + se.Message, se);
                }
            }

        }
        public static List<Qualification> GetAllQualifications()
        {
            List<Qualification> Qualifications = new List<Qualification>();
            // création connection
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    //initialiser la connection de la commande
                    sqlCde.Connection = sqlConnect;
                    // chargement des qualifications
                    String strSql = "Select idQualif, libelleQualif, pvjournalier from dbo.Qualification";
                    sqlCde.CommandText = strSql;
                    // Exécution de la commande
                    try
                    {
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            Qualification oQualif = new Qualification(Convert.ToSByte(sqlRdr[0]), sqlRdr.GetString(1), sqlRdr.GetDecimal(2));
                            Qualifications.Add(oQualif);
                        }
                        sqlRdr.Close();
                        return Qualifications;
                    }
                    catch (SqlException se)
                    {
                        throw new DaoExceptionFinAppli("Lecture des qualifications impossible, l'application va se fermer: \n" + se.Message, se);
                    }
                }
            }
        }
        public static List<Collaborateur> GetAllChefs()
        {
            List<Collaborateur> Chefs = new List<Collaborateur>();
            // création connection
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    //initialiser la connection de la commande
                    sqlCde.Connection = sqlConnect;
                    // chargement des collaborateurs + leur qualif
                    String strSql = "select idColl, nomColl, prenomColl, dembauche, prJournalier , c.idqualif "
                                     + "from dbo.collaborateur c "
                                     + " where c.idqualif=1";
                    sqlCde.CommandText = strSql;
                    // Exécution de la commande
                    try
                    {
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            // date embauche peut être null :
                            // non utilisé , utilisation opérateur ternaire dans le constructeur
                            //DateTime? dt = null;
                            //if (!sqlRdr.IsDBNull(3)) dt = sqlRdr.GetDateTime(3);

                            Collaborateur oCollab = new Collaborateur(sqlRdr.GetInt32(0), sqlRdr.GetString(1), sqlRdr.GetString(2), sqlRdr.IsDBNull(3)? (DateTime?)null : sqlRdr.GetDateTime(3),
                                            sqlRdr.GetDecimal(4), new Qualification() { CodeQualif = Convert.ToSByte(sqlRdr[5]) });
                            Chefs.Add(oCollab);
                        }
                        sqlRdr.Close();
                        return Chefs;
                    }
                    catch (SqlException se)
                    {
                        throw new DaoExceptionFinAppli("Lecture des collaborateurs impossible, l'application va se fermer: \n" + se.Message, se);
                    }
                }
            }
        }
        public static List<Client> GetAllClients()
        {
            List<Client> Clients = new List<Client>();
            // création connection
            using (SqlConnection sqlConnect = GetConnection())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    //initialiser la connection de la commande
                    sqlCde.Connection = sqlConnect;
                    // chargement des qualifications
                    String strSql = "Select idClient, raisonsociale , adresse1, adresse2,cp, ville, telephone,mail from dbo.Client";
                    sqlCde.CommandText = strSql;

                    // Exécution de la commande
                    try
                    {
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            // non utilisé : pour les string on preferera sqlRdr[3].ToString() qui évite de tester le null
                            //string adr = String.Empty;
                            //if (!sqlRdr.IsDBNull(3)) adr = sqlRdr.GetString(3);
                            // idem pour le mail
                            Client oClient = new Client(sqlRdr.GetInt32(0), sqlRdr.GetString(1), sqlRdr.GetString(2), sqlRdr[3].ToString(), sqlRdr.GetString(4), sqlRdr.GetString(5), sqlRdr.GetString(6), sqlRdr[7].ToString());
                            Clients.Add(oClient);
                        }
                        sqlRdr.Close();
                        return Clients;
                    }
                    catch (SqlException se)
                    {
                        throw new DaoExceptionFinAppli("Lecture des clients impossible, l'application va se fermer: \n" + se.Message, se);
                    }
                }
            }
        }
        public static List<Projet> GetAllProjetForfaits()
        {
            List<Projet> Projets = new List<Projet>();
            // création connection
            using (SqlConnection sqlConnect = GetConnection())
            {

                // projet forfait
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    //initialiser la connection de la commande
                    sqlCde.Connection = sqlConnect;
                    // chargement des qualifications
                    String strSql = "GetAllProjetForfaits";
                    sqlCde.CommandText = strSql;
                    sqlCde.CommandType = CommandType.StoredProcedure;

                    // Exécution de la commande
                    try
                    {
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            // mt contrat et Penalite : jamais null pour les forfaits
                            
                            // Champs null possibles : contact client et mailcontact gérés par ToString()
                            // Affectation Penalite
                            //Penalite pen = Penalite.Non;
                            //if (sqlRdr.GetBoolean(8) == true) pen = Penalite.Oui;
                            // non utilisé , utilisation opérateur ternaire dans le constructeur

                            // Création objet
                            ProjetForfait oProjetForfait = new ProjetForfait(sqlRdr.GetInt32(0), sqlRdr.GetString(1), sqlRdr.GetDateTime(2), sqlRdr.GetDateTime(3), new Client() { CodeClient = sqlRdr.GetInt32(6) },
                               sqlRdr[4].ToString(), sqlRdr[5].ToString(), sqlRdr.GetDecimal(7), sqlRdr.GetBoolean(8)? Penalite.Oui: Penalite.Non, new Collaborateur() { CodeColl = sqlRdr.GetInt32(9) });
                            // ajout liste
                            Projets.Add(oProjetForfait);
                        }
                        sqlRdr.Close();

                        return Projets;
                    }
                    catch (SqlException se)
                    {
                        throw new DaoExceptionFinAppli("Lecture des projets forfait impossible, l'application va se fermer: \n" + se.Message, se);
                    }
                }
            }
        }

        public static int AddProjet(Projet pr)
        {
            // création connection
            using (SqlConnection sqlConnect = GetConnection())
            {
                // projet forfait
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    //initialiser la connection de la commande
                    sqlCde.Connection = sqlConnect;
                    string strSql = "AddProjet";
                    sqlCde.CommandText = strSql;

                    // Affectation des parametres à la commande
                    AffectParamCde(pr, sqlCde);
                    // ajout du parametre typeprojet (uniquement en add)
                    sqlCde.Parameters.Add(new SqlParameter("@idTypeP", SqlDbType.TinyInt)).Value = 1;

                    // ajout du code projet en sortie 
                    SqlParameter pOut = new SqlParameter("@idProjet", SqlDbType.Int);
                    pOut.Direction = ParameterDirection.Output;
                    sqlCde.Parameters.Add(pOut);
                    
                    // exécution de la requete
                    //========================
                    try
                    {
                        int n = sqlCde.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("L'opération n'a pas été réalisée");
                        return (int)pOut.Value;
                    }
                    catch (SqlException se)
                    {
                        throw new DaoExceptionAfficheMessage("L'opération n'a pas été réalisée: \n" + se.Message, se);
                    }
                }
            }
        }

        private static void AffectParamCde(Projet pr, SqlCommand sqlCde)
        {
            sqlCde.CommandType = CommandType.StoredProcedure;
            sqlCde.Parameters.Clear();
            // affectation des parametres communs 
            sqlCde.Parameters.Add(new SqlParameter("@idClient", SqlDbType.Int)).Value = pr.LeClient.CodeClient;
            sqlCde.Parameters.Add(new SqlParameter("@nomprojet", SqlDbType.VarChar, 30)).Value = pr.NomProjet;
            sqlCde.Parameters.Add(new SqlParameter("@ddebut", SqlDbType.Date)).Value = pr.DDebut;
            sqlCde.Parameters.Add(new SqlParameter("@dfin", SqlDbType.Date)).Value = pr.DFin;
            if (pr.Contact != string.Empty)
                sqlCde.Parameters.Add(new SqlParameter("@contactclient", SqlDbType.VarChar, 30)).Value = pr.Contact;
            if (pr.MailContact != string.Empty)
                sqlCde.Parameters.Add(new SqlParameter("@mailcontact", SqlDbType.VarChar, 30)).Value = pr.MailContact;
            // affectation des parametres particuliers
            Type t = pr.GetType();
            if (t.Name == "ProjetForfait")
            {
                sqlCde.Parameters.Add(new SqlParameter("@mtcontrat", SqlDbType.Money)).Value = ((ProjetForfait)pr).MontantContrat;
                sqlCde.Parameters.Add(new SqlParameter("@penaliteouinon", SqlDbType.Bit)).Value = ((ProjetForfait)pr).PenaliteOuiNon;
                sqlCde.Parameters.Add(new SqlParameter("@idcoll", SqlDbType.Int)).Value = ((ProjetForfait)pr).ChefDeProjet.CodeColl;
            }
            else
            {
                sqlCde.Parameters.Add(new SqlParameter("@tarifjournalier", SqlDbType.Money)).Value = ((ProjetRegie)pr).TarifJournalier;
                sqlCde.Parameters.Add(new SqlParameter("@idQualif", SqlDbType.TinyInt)).Value = ((ProjetRegie)pr).Qualification.CodeQualif;
            }
        }

        public static void UpdProjet(Projet pr)
        {
            // création connection
            using (SqlConnection sqlConnect = GetConnection())
            {
                // projet forfait
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    //initialiser la connection de la commande
                    sqlCde.Connection = sqlConnect;
                    string strSql = "UpdProjet";
                    sqlCde.CommandText = strSql;

                    // Affectation des parametres à la commande
                    AffectParamCde(pr, sqlCde);

                    // ajout du code projet en entrée
                    sqlCde.Parameters.Add(new SqlParameter("@idprojet", SqlDbType.Int)).Value = pr.CodeProjet;

                    // exécution de la requete
                    //========================
                    try
                    {
                        int n = sqlCde.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("L'opération n'a pas été réalisée");
                    }
                    catch (SqlException se)
                    {
                        throw new DaoExceptionAfficheMessage("La mise à jour n'a pas été réalisée: \n" + se.Message);
                    }
                }
            }
        }

        public static bool DelProjet(Projet pr)
        {
            // création connection
            using (SqlConnection sqlConnect = GetConnection())
            {
                // projet forfait
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    //initialiser la connection de la commande
                    sqlCde.Connection = sqlConnect;
                    string strSql = "DelProjet";
                    sqlCde.CommandText = strSql;
                    sqlCde.CommandType = CommandType.StoredProcedure;

                    // affectation du parametre idprojet à la procédure stockée
                    sqlCde.Parameters.Clear();
                    sqlCde.Parameters.Add(new SqlParameter("@idProjet", SqlDbType.Int)).Value = pr.CodeProjet;
                    try
                    {

                        int n = sqlCde.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("L'opération n'a pas été réalisée");
                        return true;
                    }
                    catch (SqlException se)
                    {
                        throw new DaoExceptionAfficheMessage("L'opération de suppression n'a pas été réalisée: \n" + se.Message, se);
                    }
                }
            }
        }

        // Les prévisions
        //================

        public static List<Prevision> GetPrevisionByProjet(int idProjet)
        {
            List<Prevision> Previsions = new List<Prevision>();
            // création connection
            using (SqlConnection sqlConnect = GetConnection())
            {

                // projet forfait
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    //initialiser la connection de la commande
                    sqlCde.Connection = sqlConnect;
                    // chargement des qualifications
                    String strSql = "GetPrevisionByProjet";
                    sqlCde.CommandText = strSql;
                    sqlCde.CommandType = CommandType.StoredProcedure;
                    sqlCde.Parameters.Add(new SqlParameter("@idProjet", SqlDbType.Int)).Value = idProjet;

                    // Exécution de la commande
                    try
                    {
                        SqlDataReader sqlRdr = sqlCde.ExecuteReader();
                        while (sqlRdr.Read())
                        {
                            // Création objet
                            Prevision oPrev = new Prevision()
                            {
                                CodePrev = sqlRdr.GetInt32(0),
                                CodeProjet = sqlRdr.GetInt32(1),
                                LaQualif = new Qualification() { CodeQualif = Convert.ToSByte(sqlRdr[2]) },
                                NbJours = sqlRdr.GetInt16(3)
                            };
                            // ajout liste
                            Previsions.Add(oPrev);
                        }
                        sqlRdr.Close();

                        return Previsions;
                    }
                    catch (SqlException se)
                    {
                        throw new DaoExceptionFinAppli("Lecture des previsions impossible, l'application va se fermer: \n" + se.Message, se);
                    }
                }
            }
        }

        public static bool DelPrevision(Prevision pr)
        {
            // création connection
            using (SqlConnection sqlConnect = GetConnection())
            {
                // projet forfait
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    //initialiser la connection de la commande
                    sqlCde.Connection = sqlConnect;
                    string strSql = "DelPrevision";
                    sqlCde.CommandText = strSql;
                    sqlCde.CommandType = CommandType.StoredProcedure;

                    // affectation du parametre idprojet à la procédure stockée
                    sqlCde.Parameters.Clear();
                    sqlCde.Parameters.Add(new SqlParameter("@idPrevision", SqlDbType.Int)).Value = pr.CodePrev;
                    try
                    {

                        int n = sqlCde.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("L'opération n'a pas été réalisée");
                        return true;
                    }
                    catch (SqlException se)
                    {
                        throw new DaoExceptionAfficheMessage("L'opération de suppression n'a pas été réalisée: \n" + se.Message, se);
                    }
                }
            }
        }

        public static bool UpdPrevision(Prevision pr)
        {
            // création connection
            using (SqlConnection sqlConnect = GetConnection())
            {
                // projet forfait
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    //initialiser la connection de la commande
                    sqlCde.Connection = sqlConnect;
                    string strSql = "UpdPrevision";
                    sqlCde.CommandText = strSql;
                    sqlCde.CommandType = CommandType.StoredProcedure;

                    // affectation du parametre idprojet à la procédure stockée
                    sqlCde.Parameters.Clear();
                    sqlCde.Parameters.Add(new SqlParameter("@idPrevision", SqlDbType.Int)).Value = pr.CodePrev;
                    sqlCde.Parameters.Add(new SqlParameter("@idQualif", SqlDbType.TinyInt)).Value = pr.LaQualif.CodeQualif;
                    sqlCde.Parameters.Add(new SqlParameter("@nbjours", SqlDbType.Int)).Value = pr.NbJours;

                    try
                    {

                        int n = sqlCde.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("L'opération n'a pas été réalisée");
                        return true;
                    }
                    catch (SqlException se)
                    {
                        throw new DaoExceptionAfficheMessage("L'opération de suppression n'a pas été réalisée: \n" + se.Message, se);
                    }
                }
            }
        }
        public static int AddPrevision(Prevision pr)
        {
            // création connection
            using (SqlConnection sqlConnect = GetConnection())
            {
                // projet forfait
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    //initialiser la connection de la commande
                    sqlCde.Connection = sqlConnect;
                    sqlCde.CommandType = CommandType.StoredProcedure;
                    string strSql = "AddPrevision";
                    sqlCde.CommandText = strSql;

                    sqlCde.Parameters.Add(new SqlParameter("@idProjet", SqlDbType.Int)).Value = pr.CodeProjet;
                    sqlCde.Parameters.Add(new SqlParameter("@idQualif", SqlDbType.TinyInt)).Value = pr.LaQualif.CodeQualif;
                    sqlCde.Parameters.Add(new SqlParameter("@nbjours", SqlDbType.Int)).Value = pr.NbJours;

                    // ajout du code prevision en sortie 
                    SqlParameter pOut = new SqlParameter("@idPrev", SqlDbType.Int);
                    pOut.Direction = ParameterDirection.Output;
                    sqlCde.Parameters.Add(pOut);

                    // exécution de la requete
                    //========================
                    try
                    {
                        int n = sqlCde.ExecuteNonQuery();
                        if (n != 1)
                            throw new DaoExceptionAfficheMessage("L'opération n'a pas été réalisée");
                        return (int)pOut.Value;
                    }
                    catch (SqlException se)
                    {
                        throw new DaoExceptionAfficheMessage("L'opération n'a pas été réalisée: \n" + se.Message, se);
                    }
                }
            }
        }
    }
}
