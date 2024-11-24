namespace OperationsWindows
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtValeur1 = new System.Windows.Forms.TextBox();
            this.txtValeur2 = new System.Windows.Forms.TextBox();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.btnMultiplier = new System.Windows.Forms.Button();
            this.lblOperation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(132, 12);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(46, 46);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "+";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtValeur1
            // 
            this.txtValeur1.Location = new System.Drawing.Point(26, 12);
            this.txtValeur1.Name = "txtValeur1";
            this.txtValeur1.Size = new System.Drawing.Size(100, 20);
            this.txtValeur1.TabIndex = 1;
            this.txtValeur1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur1.TextChanged += new System.EventHandler(this.txtValeur1_TextChanged);
            // 
            // txtValeur2
            // 
            this.txtValeur2.Location = new System.Drawing.Point(26, 38);
            this.txtValeur2.Name = "txtValeur2";
            this.txtValeur2.Size = new System.Drawing.Size(100, 20);
            this.txtValeur2.TabIndex = 2;
            this.txtValeur2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur2.TextChanged += new System.EventHandler(this.txtValeur2_TextChanged);
            // 
            // txtResultat
            // 
            this.txtResultat.Enabled = false;
            this.txtResultat.Location = new System.Drawing.Point(26, 90);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(100, 20);
            this.txtResultat.TabIndex = 3;
            this.txtResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMultiplier
            // 
            this.btnMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplier.Location = new System.Drawing.Point(132, 64);
            this.btnMultiplier.Name = "btnMultiplier";
            this.btnMultiplier.Size = new System.Drawing.Size(46, 46);
            this.btnMultiplier.TabIndex = 4;
            this.btnMultiplier.Text = "x";
            this.btnMultiplier.UseVisualStyleBackColor = true;
            this.btnMultiplier.Click += new System.EventHandler(this.btnMultiplier_Click);
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(2, 32);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(23, 26);
            this.lblOperation.TabIndex = 5;
            this.lblOperation.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Image = global::OperationsWindows.Properties.Resources.quitter;
            this.btnQuitter.Location = new System.Drawing.Point(195, 64);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(46, 46);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Image = global::OperationsWindows.Properties.Resources.gomme;
            this.btnEffacer.Location = new System.Drawing.Point(195, 12);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(46, 46);
            this.btnEffacer.TabIndex = 7;
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 122);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.btnMultiplier);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.txtValeur2);
            this.Controls.Add(this.txtValeur1);
            this.Controls.Add(this.btnAjouter);
            this.Name = "Form1";
            this.Text = "Opérations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtValeur1;
        private System.Windows.Forms.TextBox txtValeur2;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Button btnMultiplier;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnQuitter;
    }
}

