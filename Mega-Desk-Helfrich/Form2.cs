using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace Mega_Desk_Helfrich
{
    public partial class Form2 : Form
    {
  
        public static Dictionary<string, Desk> allQuotes = new Dictionary<string, Desk>();

        public Form2()
        {
            InitializeComponent();
            List<string> materialsList = new List<string> { "Laminate", "Oak", "Rosewood", "Veneer", "Pine", "TESTTTT" };
            materialComboBox.DataSource = materialsList;

            
            List<string> rushOrderList = new List<string> { "3", "5", "7" };
            rushOrderComboBox.DataSource = rushOrderList;
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

        public string[] getRushOrder()
        {       
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\chris\OneDrive\Documents\School\semester9\.netdev\Mega-Desk-Helfrich\Mega-Desk-Helfrich\TextFile1.txt");
            return text;
        }

        public void calculateQuote_Click(object sender, EventArgs e)
        {
         

            string firstName = firstNameEntry.Text;
            string lastName = lastNameEntry.Text;
            string depthIn = depthInput.Text;
            string widthIn = widthInput.Text;
            string drawersIn = deskDrawers.Text;
            string material = materialComboBox.Text;
            string rushOrder = rushOrderComboBox.Text;

            

            int depth;
            int width;
            int drawers;
            bool parseSuccessDepth = int.TryParse(depthIn, out depth);
            bool parseSuccessWidth = int.TryParse(widthIn, out width);
            bool parseSuccessDrawers = int.TryParse(drawersIn, out drawers);

            if (!parseSuccessDepth)
            {
                MessageBox.Show($"Your input for Depth was not a number. Try again.");
            }
            if (!parseSuccessWidth)
            {
                MessageBox.Show($"Your input for Width was not a number. Try again.");
            }
            if (!parseSuccessDrawers)
            {
                MessageBox.Show($"Your input for Depth was not a number. Try again.");
            }

            // if (firstName != "" || lastName != null || width != null || depth != null || drawers != null || material != null || rushOrder != null)
            if (firstName == string.Empty || lastName == string.Empty || width.ToString() == string.Empty || depth.ToString() == string.Empty || drawers.ToString() == string.Empty || material == string.Empty || rushOrder == string.Empty)
            {
     
                MessageBox.Show("Please fill out all fields");

            }

            if(width > 96 || width < 24)
            {
                MessageBox.Show("Width must be minimum 24 inches and maximum 96 inches");
            }
            if (depth > 48 || depth < 12)
            {
                MessageBox.Show("Depth must be minimum 12 inches and maximum 48 inches");
            }
            if (drawers > 7 || width < 0)
            {
                MessageBox.Show("Zero to seven drawers maximum");
            }

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

                string[] orderPriceList = getRushOrder();

                int orderCost = 0;

                if (rushOrder == "3")
                {
                    if (surfaceArea < 1000)
                    {
                        orderCost = Int32.Parse(orderPriceList[0]);
                    }
                    else if (surfaceArea > 1000 && surfaceArea < 2000)
                    {
                        orderCost = Int32.Parse(orderPriceList[1]);
                    }
                    else if (surfaceArea > 2000)
                    {
                        orderCost = Int32.Parse(orderPriceList[2]);
                    }

                }
                else if (rushOrder == "5")
                {
                    if (surfaceArea < 1000)
                    {
                        orderCost = Int32.Parse(orderPriceList[3]);
                    }
                    else if (surfaceArea > 1000 && surfaceArea < 2000)
                    {
                        orderCost = Int32.Parse(orderPriceList[4]);
                    }
                    else if (surfaceArea > 2000)
                    {
                        orderCost = Int32.Parse(orderPriceList[5]);
                    }

                }
                else if (rushOrder == "7")
                {
                    if (surfaceArea < 1000)
                    {
                        orderCost = Int32.Parse(orderPriceList[6]);
                    }
                    else if (surfaceArea > 1000 && surfaceArea < 2000)
                    {
                        orderCost = Int32.Parse(orderPriceList[7]);
                    }
                    else if (surfaceArea > 2000)
                    {
                        orderCost = Int32.Parse(orderPriceList[8]);
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
            DateTime now = DateTime.Now;
            string dateNow = now.ToString("g");


            Desk d = new Desk(firstNameEntry.Text.ToString(), lastNameEntry.Text.ToString(), dateNow, totalPriceTextBox.Text.ToString(), Convert.ToInt32(widthInput.Text), Convert.ToInt32(depthInput.Text), Convert.ToInt32(deskDrawers.Text), this.materialComboBox.Text.ToString(), rushOrderComboBox.Text.ToString());

            allQuotes.Add(lastNameEntry.Text.ToString(), d);

            string output = JsonConvert.SerializeObject(d);
            string path = @"C:\Users\chris\OneDrive\Documents\School\semester9\.netdev\Mega-Desk-Helfrich\Mega-Desk-Helfrich\quotes.json";
            File.AppendAllText(path, output);
            



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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deskDepth_Click(object sender, EventArgs e)
        {

        }

        private void rushOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
