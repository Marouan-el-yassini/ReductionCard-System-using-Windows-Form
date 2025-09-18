using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReductionCardSystem
{
    public partial class Facture : Form
    {
        private Rreduction _reduction;
        public Facture(Rreduction reduction)
        {
            InitializeComponent();
            _reduction = reduction;


        }

        private void info_Click(object sender, EventArgs e)
        {


        }

        private void Facture_Load(object sender, EventArgs e)
        {
            info.Text = $"Nom : {_reduction.Name}\r\n" +
                   $"Âge : {_reduction.Age}\r\n" +
                   $"Produit : {_reduction.Product}\r\n" +
                   $"Prix initial : {_reduction.Price} DH\r\n" +
                   $"Prix après réduction : {_reduction.redu()} DH";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichier texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            saveFileDialog.FileName = "Facture.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Écrire le contenu du Label dans le fichier
                    System.IO.File.WriteAllText(saveFileDialog.FileName,info.Text);
                    MessageBox.Show("Facture téléchargée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
                }
            }
        }
    }
}
