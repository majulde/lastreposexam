namespace Gestion_d_ecole
{
    partial class FormRapport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtnomrecherch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboclasse = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label2 = new System.Windows.Forms.Label();
            this.btngenerlisteetudiant = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(613, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtnomrecherch
            // 
            this.txtnomrecherch.Location = new System.Drawing.Point(420, 29);
            this.txtnomrecherch.Name = "txtnomrecherch";
            this.txtnomrecherch.Size = new System.Drawing.Size(219, 22);
            this.txtnomrecherch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOM : ";
            // 
            // comboclasse
            // 
            this.comboclasse.FormattingEnabled = true;
            this.comboclasse.Location = new System.Drawing.Point(119, 29);
            this.comboclasse.Name = "comboclasse";
            this.comboclasse.Size = new System.Drawing.Size(146, 24);
            this.comboclasse.TabIndex = 3;
            this.comboclasse.SelectedIndexChanged += new System.EventHandler(this.comboclasse_SelectedIndexChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Classe : ";
            // 
            // btngenerlisteetudiant
            // 
            this.btngenerlisteetudiant.Location = new System.Drawing.Point(660, 223);
            this.btngenerlisteetudiant.Name = "btngenerlisteetudiant";
            this.btngenerlisteetudiant.Size = new System.Drawing.Size(155, 43);
            this.btngenerlisteetudiant.TabIndex = 5;
            this.btngenerlisteetudiant.Text = "Gener liste etudiant";
            this.btngenerlisteetudiant.UseVisualStyleBackColor = true;
            this.btngenerlisteetudiant.Click += new System.EventHandler(this.btngenerlisteetudiant_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(857, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // FormRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 613);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btngenerlisteetudiant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboclasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnomrecherch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRapport";
            this.Text = "FormRapport";
            this.Load += new System.EventHandler(this.FormRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtnomrecherch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboclasse;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btngenerlisteetudiant;
    }
}