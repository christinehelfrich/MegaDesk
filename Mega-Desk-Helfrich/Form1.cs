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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

        private void addNewQuoteButton_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void searchQuotesButton_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();
        }

        private void viewQuotesButton_Click(object sender, EventArgs e)
        {

            var form4 = new Form4();
            form4.Show();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
