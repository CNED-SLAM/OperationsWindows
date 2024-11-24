using System;
using System.Windows.Forms;

namespace OperationsWindows
{
    /// <summary>
    /// Application de calcul
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Mise à blanc des 3 zones de texte et du label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtValeur1.Text = "";
            txtValeur2.Text = "";
            txtResultat.Text = "";
            lblOperation.Text = "";
        }

        /// <summary>
        /// Multiplication des 2 premières valeurs et résultat rangé dans la zone du bas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiplier_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultat.Text = (float.Parse(txtValeur1.Text) * float.Parse(txtValeur2.Text)).ToString();
                lblOperation.Text = "x";
            }
            catch { };
        }

        /// <summary>
        /// Pour quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Addition des 2 premières valeurs et résultat rangé dans la zone du bas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultat.Text = (float.Parse(txtValeur1.Text) + float.Parse(txtValeur2.Text)).ToString();
                lblOperation.Text = "+";
            }
            catch { };
        }

        /// <summary>
        /// Appel de la procédure qui annule l'opération suite à une nouvelle saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtValeur1_TextChanged(object sender, EventArgs e)
        {
            AnnuleOperation();
        }

        /// <summary>
        /// Appel de la procédure qui annule l'opération suite à une nouvelle saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtValeur2_TextChanged(object sender, EventArgs e)
        {
            AnnuleOperation();
        }

        /// <summary>
        /// Procédure non événementiel permettant de :
        /// - vider le résultat suite à une nouvelle saisie
        /// - vider le label de l'opération
        /// </summary>
        private void AnnuleOperation()
        {
            lblOperation.Text = "";
            txtResultat.Text = "";
        }




    }
}
