namespace TestORM
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTousLesAuteurs = new System.Windows.Forms.ListBox();
            this.MiseAJour = new System.Windows.Forms.Button();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Prénom = new System.Windows.Forms.TextBox();
            this.Ville = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SupprimerAuteurs = new System.Windows.Forms.Button();
            this.ToutLesAuteurs = new System.Windows.Forms.Button();
            this.AjouterAuteur = new System.Windows.Forms.Button();
            this.AuteurParis = new System.Windows.Forms.Button();
            this.AuteurId2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.Location = new System.Drawing.Point(320, 43);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(155, 30);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Les Auteurs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ville";
            // 
            // lstTousLesAuteurs
            // 
            this.lstTousLesAuteurs.FormattingEnabled = true;
            this.lstTousLesAuteurs.Location = new System.Drawing.Point(68, 194);
            this.lstTousLesAuteurs.Name = "lstTousLesAuteurs";
            this.lstTousLesAuteurs.Size = new System.Drawing.Size(334, 121);
            this.lstTousLesAuteurs.TabIndex = 4;
            this.lstTousLesAuteurs.SelectedIndexChanged += new System.EventHandler(this.lstTousLesAuteurs_SelectedIndexChanged);
            // 
            // MiseAJour
            // 
            this.MiseAJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiseAJour.Location = new System.Drawing.Point(574, 271);
            this.MiseAJour.Name = "MiseAJour";
            this.MiseAJour.Size = new System.Drawing.Size(99, 44);
            this.MiseAJour.TabIndex = 6;
            this.MiseAJour.Text = "Mise à jour";
            this.MiseAJour.UseVisualStyleBackColor = true;
            this.MiseAJour.Click += new System.EventHandler(this.MiseAJour_Click);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(162, 35);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(240, 20);
            this.Nom.TabIndex = 8;
            this.Nom.TextChanged += new System.EventHandler(this.Nom_TextChanged);
            // 
            // Prénom
            // 
            this.Prénom.Location = new System.Drawing.Point(162, 94);
            this.Prénom.Name = "Prénom";
            this.Prénom.Size = new System.Drawing.Size(240, 20);
            this.Prénom.TabIndex = 9;
            // 
            // Ville
            // 
            this.Ville.Location = new System.Drawing.Point(162, 151);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(240, 20);
            this.Ville.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.Titre);
            this.groupBox1.Location = new System.Drawing.Point(0, -13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 115);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Coral;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.SupprimerAuteurs);
            this.groupBox2.Controls.Add(this.ToutLesAuteurs);
            this.groupBox2.Controls.Add(this.AjouterAuteur);
            this.groupBox2.Controls.Add(this.AuteurParis);
            this.groupBox2.Controls.Add(this.AuteurId2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Ville);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Prénom);
            this.groupBox2.Controls.Add(this.lstTousLesAuteurs);
            this.groupBox2.Controls.Add(this.Nom);
            this.groupBox2.Controls.Add(this.MiseAJour);
            this.groupBox2.Location = new System.Drawing.Point(0, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 368);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 23);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SupprimerAuteurs
            // 
            this.SupprimerAuteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerAuteurs.Location = new System.Drawing.Point(469, 213);
            this.SupprimerAuteurs.Name = "SupprimerAuteurs";
            this.SupprimerAuteurs.Size = new System.Drawing.Size(99, 42);
            this.SupprimerAuteurs.TabIndex = 15;
            this.SupprimerAuteurs.Text = "Supprimer un auteur";
            this.SupprimerAuteurs.UseVisualStyleBackColor = true;
            this.SupprimerAuteurs.Click += new System.EventHandler(this.SupprimerAuteurs_Click);
            // 
            // ToutLesAuteurs
            // 
            this.ToutLesAuteurs.Location = new System.Drawing.Point(68, 320);
            this.ToutLesAuteurs.Name = "ToutLesAuteurs";
            this.ToutLesAuteurs.Size = new System.Drawing.Size(98, 24);
            this.ToutLesAuteurs.TabIndex = 14;
            this.ToutLesAuteurs.Text = "Tout les auteurs";
            this.ToutLesAuteurs.UseVisualStyleBackColor = true;
            this.ToutLesAuteurs.Click += new System.EventHandler(this.ToutLesAuteurs_Click);
            // 
            // AjouterAuteur
            // 
            this.AjouterAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterAuteur.Location = new System.Drawing.Point(469, 129);
            this.AjouterAuteur.Name = "AjouterAuteur";
            this.AjouterAuteur.Size = new System.Drawing.Size(99, 42);
            this.AjouterAuteur.TabIndex = 13;
            this.AjouterAuteur.Text = "Ajouter un auteur";
            this.AjouterAuteur.UseVisualStyleBackColor = true;
            this.AjouterAuteur.Click += new System.EventHandler(this.AjouterAuteur_Click);
            // 
            // AuteurParis
            // 
            this.AuteurParis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuteurParis.Location = new System.Drawing.Point(574, 213);
            this.AuteurParis.Name = "AuteurParis";
            this.AuteurParis.Size = new System.Drawing.Size(99, 42);
            this.AuteurParis.TabIndex = 12;
            this.AuteurParis.Text = "Les auteurs de Paris";
            this.AuteurParis.UseVisualStyleBackColor = true;
            this.AuteurParis.Click += new System.EventHandler(this.AuteurParis_Click);
            // 
            // AuteurId2
            // 
            this.AuteurId2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuteurId2.Location = new System.Drawing.Point(469, 271);
            this.AuteurId2.Name = "AuteurId2";
            this.AuteurId2.Size = new System.Drawing.Size(99, 44);
            this.AuteurId2.TabIndex = 11;
            this.AuteurId2.Text = "Auteur avec id = 2 ";
            this.AuteurId2.UseVisualStyleBackColor = true;
            this.AuteurId2.Click += new System.EventHandler(this.AuteurId2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 455);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTousLesAuteurs;
        private System.Windows.Forms.Button MiseAJour;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Prénom;
        private System.Windows.Forms.TextBox Ville;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AuteurId2;
        private System.Windows.Forms.Button AuteurParis;
        private System.Windows.Forms.Button AjouterAuteur;
        private System.Windows.Forms.Button ToutLesAuteurs;
        private System.Windows.Forms.Button SupprimerAuteurs;
        private System.Windows.Forms.Button button1;
    }
}

