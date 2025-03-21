namespace Gestion_d_ecole
{
    partial class FormInscriptionUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomUtilisateurIns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordIns = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnregistrerIns = new System.Windows.Forms.Button();
            this.btnAnnulerIns = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewIns = new System.Windows.Forms.DataGridView();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIns)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formulaire d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vos coordonées :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom Utilisateur";
            // 
            // txtNomUtilisateurIns
            // 
            this.txtNomUtilisateurIns.Location = new System.Drawing.Point(24, 532);
            this.txtNomUtilisateurIns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomUtilisateurIns.Multiline = true;
            this.txtNomUtilisateurIns.Name = "txtNomUtilisateurIns";
            this.txtNomUtilisateurIns.Size = new System.Drawing.Size(368, 34);
            this.txtNomUtilisateurIns.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mot de Passe";
            // 
            // txtPasswordIns
            // 
            this.txtPasswordIns.Location = new System.Drawing.Point(473, 532);
            this.txtPasswordIns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordIns.Multiline = true;
            this.txtPasswordIns.Name = "txtPasswordIns";
            this.txtPasswordIns.Size = new System.Drawing.Size(335, 34);
            this.txtPasswordIns.TabIndex = 6;
            this.txtPasswordIns.TextChanged += new System.EventHandler(this.txtPasswordIns_TextChanged);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(931, 532);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelephone.Multiline = true;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(335, 34);
            this.txtTelephone.TabIndex = 8;
            this.txtTelephone.TextChanged += new System.EventHandler(this.txtTelephone_TextChanged);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Administrateur",
            "DE",
            "Agent"});
            this.cmbRole.Location = new System.Drawing.Point(931, 473);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(335, 24);
            this.cmbRole.TabIndex = 9;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            this.cmbRole.Validating += new System.ComponentModel.CancelEventHandler(this.cmbRole_Validating);
            this.cmbRole.Validated += new System.EventHandler(this.cmbRole_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(927, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(927, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telephone";
            // 
            // btnEnregistrerIns
            // 
            this.btnEnregistrerIns.BackColor = System.Drawing.Color.Blue;
            this.btnEnregistrerIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerIns.Location = new System.Drawing.Point(258, 582);
            this.btnEnregistrerIns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnregistrerIns.Name = "btnEnregistrerIns";
            this.btnEnregistrerIns.Size = new System.Drawing.Size(134, 39);
            this.btnEnregistrerIns.TabIndex = 12;
            this.btnEnregistrerIns.Text = "Enregister";
            this.btnEnregistrerIns.UseVisualStyleBackColor = false;
            this.btnEnregistrerIns.Click += new System.EventHandler(this.btnEnregistrerIns_Click);
            // 
            // btnAnnulerIns
            // 
            this.btnAnnulerIns.BackColor = System.Drawing.Color.Red;
            this.btnAnnulerIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerIns.Location = new System.Drawing.Point(24, 582);
            this.btnAnnulerIns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnulerIns.Name = "btnAnnulerIns";
            this.btnAnnulerIns.Size = new System.Drawing.Size(139, 39);
            this.btnAnnulerIns.TabIndex = 13;
            this.btnAnnulerIns.Text = "Annuler";
            this.btnAnnulerIns.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_d_ecole.Properties.Resources.ajouter_un_utilisateur;
            this.pictureBox1.Location = new System.Drawing.Point(972, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewIns
            // 
            this.dataGridViewIns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIns.Location = new System.Drawing.Point(24, 58);
            this.dataGridViewIns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewIns.Name = "dataGridViewIns";
            this.dataGridViewIns.RowHeadersWidth = 62;
            this.dataGridViewIns.RowTemplate.Height = 28;
            this.dataGridViewIns.Size = new System.Drawing.Size(943, 314);
            this.dataGridViewIns.TabIndex = 14;
            this.dataGridViewIns.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewIns_CellMouseDoubleClick);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.Honeydew;
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(101, 388);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(169, 42);
            this.btnRechercher.TabIndex = 15;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LawnGreen;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(690, 388);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(179, 42);
            this.btnModifier.TabIndex = 16;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(407, 388);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(165, 42);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // FormInscriptionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 630);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dataGridViewIns);
            this.Controls.Add(this.btnAnnulerIns);
            this.Controls.Add(this.btnEnregistrerIns);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtPasswordIns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomUtilisateurIns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormInscriptionUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page d\'inscription";
            this.Load += new System.EventHandler(this.FormInscriptionUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomUtilisateurIns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasswordIns;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnregistrerIns;
        private System.Windows.Forms.Button btnAnnulerIns;
        private System.Windows.Forms.DataGridView dataGridViewIns;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
    }
}