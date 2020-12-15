using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_Assignment_Internship
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        //
        string like_to_eat = string.Empty;
        string like_Movies = string.Empty;
        string like_TV = string.Empty;
        string like_radio = string.Empty;

        private void submit_Click(object sender, EventArgs e)
        {
            //connect to database
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=OSCAR\MSSQLSERVER01;Initial Catalog=AssignmentSurvey;User ID=sa;Password=Oscarngobeni26@";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            


            
            //declaring and assigning textboxes and checkbox to store it in the database
            string surname = surname_txt.Text;
            string firstname = first_name_txt.Text;
            string Contact_number = contact_number_txt.Text;
            string birthDate = date_txt.Text;
            string age = age_txt.Text;
            string favourite_food = "";

            //Save checked food chosen to the database by user
            foreach (var checkedItem in this.chk_liked_food.CheckedItems)
            {

                favourite_food += checkedItem.ToString() + ",";

            }
            favourite_food = favourite_food.TrimEnd(',');

            //storing details entered by user to the database 
            SqlCommand cmd = new SqlCommand("detail_insert", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@Contact_number", Contact_number);
            cmd.Parameters.AddWithValue("@birthDate", birthDate);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@favourite_food", favourite_food);
            //storing radio button entered by user to the database 
            cmd.Parameters.AddWithValue("@like_to_eat", like_to_eat);
            cmd.Parameters.AddWithValue("@like_Movies", like_Movies);
            cmd.Parameters.AddWithValue("@like_TV", like_TV);
            cmd.Parameters.AddWithValue("@like_radio", like_radio);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Insert successfully");

            Form2 change = new Form2();
            change.Show();

            cnn.Close();
        }
        //Radio button to store data in 5 columns (Strongly Agree (1) Agree (2) Neutral (3) Disagree (4) Strongly disagree)
        private void SA_like_to_eat_CheckedChanged(object sender, EventArgs e)
        {
            like_to_eat = "Strongly Agree";
        }

        private void Agree_like_to_eat_CheckedChanged(object sender, EventArgs e)
        {
            like_to_eat = "Agree";
        }

        private void N_like_to_eat_CheckedChanged(object sender, EventArgs e)
        {
            like_to_eat = "Neutral";
        }

        private void D_like_to_eat_CheckedChanged(object sender, EventArgs e)
        {
            like_to_eat = "Disagree";
        }

        private void SD_like_to_eat_CheckedChanged(object sender, EventArgs e)
        {
            like_to_eat = "Strongly Disagree";
        }

        private void SA_watch_movie_CheckedChanged(object sender, EventArgs e)
        {
            like_Movies = "Strongly Agree";
        }

        private void A_watch_movie_CheckedChanged(object sender, EventArgs e)
        {
            like_Movies = "Agree";
        }

        private void N_watch_movie_CheckedChanged(object sender, EventArgs e)
        {
            like_Movies = "Neutral";
        }

        private void D_watch_movie_CheckedChanged(object sender, EventArgs e)
        {
            like_Movies = "Disagree";
        }

        private void SD_watch_movie_CheckedChanged(object sender, EventArgs e)
        {
            like_Movies = "Strongly Disagree";
        }

        private void SA_watch_TV_CheckedChanged(object sender, EventArgs e)
        {
            like_TV = "Strongly Agree";
        }

        private void A_watch_TV_CheckedChanged(object sender, EventArgs e)
        {
            like_TV = "Agree";
        }

        private void N_watch_TV_CheckedChanged(object sender, EventArgs e)
        {
            like_TV = "Neutral";
        }

        private void D_watch_TV_CheckedChanged(object sender, EventArgs e)
        {
            like_TV = "Disagree";
        }

        private void SD_watch_TV_CheckedChanged(object sender, EventArgs e)
        {
            like_TV = "Strongly Disagree";
        }

        private void SA_listen_radio_CheckedChanged(object sender, EventArgs e)
        {
            like_radio = "Strongly Agree";
        }

        private void A_listen_radio_CheckedChanged(object sender, EventArgs e)
        {
            like_radio = "Agree";
        }

        private void N_listen_radio_CheckedChanged(object sender, EventArgs e)
        {
            like_radio = "Neutral";
        }

        private void D_listen_radio_CheckedChanged(object sender, EventArgs e)
        {
            like_radio = "Disagree";
        }

        private void SD_listen_radio_CheckedChanged(object sender, EventArgs e)
        {
            like_radio = "Strongly Disagree";
        }

        
    }
}
