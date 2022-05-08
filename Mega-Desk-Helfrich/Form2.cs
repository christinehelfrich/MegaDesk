using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Desk_Helfrich
{
    public partial class Form2 : Form
    {
  
        public static Dictionary<string, Desk> allQuotes = new Dictionary<string, Desk>();

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        public void calculateQuote_Click(object sender, EventArgs e)
        {

            try
            {
                Convert.ToInt32(widthInput.Text);
                Convert.ToInt32(depthInput.Text);
                Convert.ToInt32(deskDrawers.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string firstName = firstNameEntry.Text;
            string lastName = lastNameEntry.Text;
            int depth = Convert.ToInt32(depthInput.Text);
            int width = Convert.ToInt32(widthInput.Text);
            int drawers = Convert.ToInt32(deskDrawers.Text);
            string material = materialInput.Text;
            string rushOrder = orderRush.Text;

            // if (firstName != "" || lastName != null || width != null || depth != null || drawers != null || material != null || rushOrder != null)
            if (firstName == string.Empty || lastName == string.Empty || width.ToString() == string.Empty || depth.ToString() == string.Empty || drawers.ToString() == string.Empty || material == string.Empty || rushOrder == string.Empty)
            {
     
                MessageBox.Show("Please fill out all fields");

            }
            /*
            else if (material != "oak" || material != "laminate" || material != "pine" || material != "rosewood" || material != "veneer")
            {

                MessageBox.Show("Material must be either oak, laminate, pine, rosewood, or veneer");

            }
            */
            else
            {
                int surfaceArea = 2 * (width * width + width * depth + depth * width);
                int drawersCost = drawers * 50;
                int materialCost = 0;
                if (material == "oak" || material == "Oak")
                {
                    materialCost = 200;
                }
                else if (material == "laminate" || material == "Laminate")
                {
                    materialCost = 100;
                }
                else if (material == "pine" || material == "Pine")
                {
                    materialCost = 50;
                }
                else if (material == "rosewood" || material == "Rosewood")
                {
                    materialCost = 300;
                }
                else if (material == "veneer" || material == "Veneer")
                {
                    materialCost = 125;
                }
                else
                {
                    MessageBox.Show("Material must be either oak, laminate, pine, rosewood, or veneer");
                }

                int orderCost = 0;

                if (rushOrder == "3")
                {
                    if (surfaceArea < 1000)
                    {
                        orderCost = 60;
                    }
                    else if (surfaceArea > 1000 && surfaceArea < 2000)
                    {
                        orderCost = 70;
                    }
                    else if (surfaceArea > 2000)
                    {
                        orderCost = 80;
                    }

                }
                else if (rushOrder == "5")
                {
                    if (surfaceArea < 1000)
                    {
                        orderCost = 40;
                    }
                    else if (surfaceArea > 1000 && surfaceArea < 2000)
                    {
                        orderCost = 50;
                    }
                    else if (surfaceArea > 2000)
                    {
                        orderCost = 60;
                    }

                }
                else if (rushOrder == "7")
                {
                    if (surfaceArea < 1000)
                    {
                        orderCost = 30;
                    }
                    else if (surfaceArea > 1000 && surfaceArea < 2000)
                    {
                        orderCost = 35;
                    }
                    else if (surfaceArea > 2000)
                    {
                        orderCost = 40;
                    }

                }
                else
                {
                    MessageBox.Show("Rush order options are either 3, 5, or 7");
                }

                int totalQuotePrice = drawersCost + materialCost + orderCost;





                totalPriceTextBox.Text = totalQuotePrice.ToString();

            }
        }

        private void firstNameEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void saveQuoteButton_Click(object sender, EventArgs e)
        {
            

            Desk d = new Desk(firstNameEntry.Text.ToString(), lastNameEntry.Text.ToString(), Convert.ToInt32(widthInput.Text), Convert.ToInt32(depthInput.Text), Convert.ToInt32(deskDrawers.Text), this.materialInput.Text.ToString());

            allQuotes.Add(lastNameEntry.Text.ToString(), d);
        }

        private void lastNameEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void widthInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void depthInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void deskDrawers_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderRush_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
