using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Assignment_Internship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Fill_out_survey_Click(object sender, EventArgs e)
        {
            //Changing Screen 1 to Screen 2
            Form2 change = new Form2();
            change.Show();
        }
        
        private void View_survey_results_Click(object sender, EventArgs e)
        {
            //Changing Screen 1 to Screen 3
            Form3 change = new Form3();
            change.Show();

        }
    }
}
