using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var bdd = new bibliographieEntities())
            {
                foreach (Auteur unAuteur in bdd.Auteurs)
                {
                    lstTousLesAuteurs.Items.Add(unAuteur.Nom);
                }
            }       
        }
        private void Supprimer_Click(object sender, EventArgs e)
        {
            
            //for (int i = lstTousLesAuteurs.SelectedItems.Count - 1;i>= 0; i--){
            //    lstTousLesAuteurs.Items.Remove(lstTousLesAuteurs.SelectedItems[i]);
            //}
            //lstTousLesAuteurs.SelectedItems.Remove(lstTousLesAuteurs.SelectedItems);

        }
        private void Sauvegarder_Click(object sender, EventArgs e)
        {
            
        }
        private void MiseAJour_Click(object sender, EventArgs e)
        {
            if (this.Nom.Text != "")
            {
                lstTousLesAuteurs.Items.Add(this.Nom.Text);
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom", "Error", MessageBoxButtons.OK);
                this.Nom.Focus();
            }
        }
        private void lstTousLesAuteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void AuteurId2_Click(object sender, EventArgs e)
        {
            using (var bdd = new bibliographieEntities())
            {
                var unAuteur = bdd.Auteurs.Find(2);
                if (unAuteur != null)
                {
                    Nom.Text = unAuteur.Nom;
                    Prénom.Text = unAuteur.Prenom;
                    Ville.Text = unAuteur.ville;
                }
                else
                {
                    MessageBox.Show("Cet auteur n'est pas référencé !");
                }
            }
        }
        private void AuteurParis_Click(object sender, EventArgs e)
        {
            lstTousLesAuteurs.Items.Clear();
            using (var bdd = new bibliographieEntities())
            {
                var lesAuteurs = bdd.Auteurs.Where(
                         a => a.ville == "Paris-Fr");
                foreach (var unAuteur in lesAuteurs)
                {
                    lstTousLesAuteurs.Items.Add(unAuteur.Nom + "  " + unAuteur.Prenom);
                }
                
            }
        }
        private void AjouterAuteur_Click(object sender, EventArgs e)
        {
            if (this.Nom.Text != "")
            {
                using (var bdd = new bibliographieEntities())
                {
                    var unAuteur = new Auteur();
                    unAuteur.Nom = "HUGEL";
                    unAuteur.Prenom = "Maxime";
                    unAuteur.ville = "Ostwald";
                    bdd.Auteurs.Add(unAuteur);
                    bdd.SaveChanges();
                    MessageBox.Show("Insertion effectuée !");
                }

            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom", "Error", MessageBoxButtons.OK);
            }
                
        }
        private void ToutLesAuteurs_Click(object sender, EventArgs e)
        {

            lstTousLesAuteurs.Items.Clear();
            using (var bdd = new bibliographieEntities())
            {
                var lesAuteurs = bdd.Auteurs.OrderBy(a => a.Nom);
                
                foreach (var unAuteur in lesAuteurs)
                {
                    
                    lstTousLesAuteurs.Items.Add(unAuteur.Nom);
                }
            }
           
        }
        private void SupprimerAuteurs_Click(object sender, EventArgs e)
        {
            for (int i = lstTousLesAuteurs.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstTousLesAuteurs.Items.Remove(lstTousLesAuteurs.SelectedItems[i]);
            }
            //using (var bdd = new bibliographieEntities())
            //{
            //    var unAuteur = bdd.Auteurs.Find(13);
            //    bdd.Auteurs.Remove(unAuteur);
            //    bdd.SaveChanges();
            //    MessageBox.Show("Suppression effectuée !");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var bdd = new bibliographieEntities())
            {
                var lesLivres = bdd.Livres.Join(
                 bdd.Editeurs,
                 l => l.IdEditeur,
                 a => a.Id,
                 (l, a) => new { l, a });
                foreach (var unLivre in lesLivres)
                {
                    MessageBox.Show(unLivre.l.Titre + " - " + unLivre.a.Nom);
                }
            }

        }

        private void Nom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
