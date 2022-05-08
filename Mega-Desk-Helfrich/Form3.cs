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
    public partial class Form3 : Form
    {
        public static Dictionary<string, Desk> allQuotes = Form2.allQuotes;
        public Form3()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "First Name";
            dataGridView1.Columns[1].Name = "Last Name";
            dataGridView1.Columns[2].Name = "Desk Width";
            dataGridView1.Columns[3].Name = "Desk Depth";
            dataGridView1.Columns[4].Name = "Desk Drawers";
            dataGridView1.Columns[5].Name = "Desk Material";

            foreach (var quote in allQuotes)
            {
                string lastName = quote.Key;
                Desk desk = quote.Value;

                string[] row = new string[] { desk.firstName, desk.lastName, desk.width.ToString(), desk.depth.ToString(), desk.drawers.ToString(), desk.material };
                dataGridView1.Rows.Add(row);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            foreach(var quote in allQuotes)
            {
                Desk desk = quote.Value;
                string width = desk.width.ToString();

               
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (quote.Key == searchBoxInput.Text)
                    {
                        row.Selected = true;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }



            }
        }
    }
}
