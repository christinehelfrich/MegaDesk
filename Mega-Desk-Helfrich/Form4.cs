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
    public partial class Form4 : Form
    {
        public static Dictionary<string, Desk> allQuotes = Form2.allQuotes;

        public Form4()
        {



            InitializeComponent();

            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "First Name";
            dataGridView1.Columns[1].Name = "Last Name";
            dataGridView1.Columns[2].Name = "Date of Quote";
            dataGridView1.Columns[3].Name = "Total Quote Price";
            dataGridView1.Columns[4].Name = "Desk Width";
            dataGridView1.Columns[5].Name = "Desk Depth";
            dataGridView1.Columns[6].Name = "Desk Drawers";
            dataGridView1.Columns[7].Name = "Desk Material";
            dataGridView1.Columns[8].Name = "Rush Order Number";

            foreach (var quote in allQuotes)
            {
                string lastName = quote.Key;
                Desk desk = quote.Value;

                string[] row = new string[] { desk.firstName, desk.lastName, desk.dateNow, desk.totalPrice, desk.width.ToString(), desk.depth.ToString(), desk.drawers.ToString(), desk.material, desk.rushOrder };
                dataGridView1.Rows.Add(row);
            }
        }

        private void viewQuotesBox_SelectedIndexChanged(object sender, EventArgs e)
        {



        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewData_Click(object sender, EventArgs e)
        {


        }
    }
}
