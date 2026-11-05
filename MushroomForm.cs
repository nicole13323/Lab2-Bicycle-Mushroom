using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MushroomForm : Form
    {
        public MushroomForm()
        {
            InitializeComponent();
        }

        private bool Ask(string question)
        {
            return MessageBox.Show(question, "Question", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes;
        }

        // Decision tree (at most 3 questions):
        // Ring?  yes -> Convex cup?  no  -> Coprin chevelu
        //                            yes -> Forest? yes -> Amanite tue-mouche
        //                                           no  -> Agaric jaunissant
        //        no  -> Convex cup?  yes -> Pied bleu
        //                            no  -> Gills? yes -> Girolle
        //                                          no  -> Cepe de bordeaux
        private void btnStart_Click(object sender, EventArgs e)
        {
            string result;

            if (Ask("Does your mushroom have a ring?"))
            {
                if (!Ask("Does your mushroom have a convex cup?"))
                    result = "Coprin chevelu";
                else if (Ask("Does your mushroom grow in a forest?"))
                    result = "Amanite tue-mouche";
                else
                    result = "Agaric jaunissant";
            }
            else
            {
                if (Ask("Does your mushroom have a convex cup?"))
                    result = "Pied bleu";
                else if (Ask("Does your mushroom have gills?"))
                    result = "Girolle";
                else
                    result = "Cepe de bordeaux";
            }

            MessageBox.Show("Your mushroom is: " + result, "Result",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void lblInfo_Click(object sender, EventArgs e) { }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            string result;

            if (Ask("Does your mushroom have a ring?"))
            {
                if (!Ask("Does your mushroom have a convex cup?"))
                    result = "Coprin chevelu";
                else if (Ask("Does your mushroom grow in a forest?"))
                    result = "Amanite tue-mouche";
                else
                    result = "Agaric jaunissant";
            }
            else
            {
                if (Ask("Does your mushroom have a convex cup?"))
                    result = "Pied bleu";
                else if (Ask("Does your mushroom have gills?"))
                    result = "Girolle";
                else
                    result = "Cepe de bordeaux";
            }

            MessageBox.Show("Your mushroom is: " + result, "Result",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}