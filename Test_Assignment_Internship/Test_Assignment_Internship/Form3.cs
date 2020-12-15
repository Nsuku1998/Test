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
    public partial class Form3 : Form
    {
        

        public Form3()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

       
        private void Form3_Load(object sender, EventArgs e)
        {
            //connect to database
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=OSCAR\MSSQLSERVER01;Initial Catalog=AssignmentSurvey;User ID=sa;Password=Oscarngobeni26@";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            //view data in datagridview
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM UsersDetail", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, "UsersDetail");
            dataGridView1.DataSource = ds.Tables["UsersDetail"].DefaultView;
            dataGridView1.Columns[0].HeaderText = "";

            

            //display number of survey taken
            double noOfRows = 0;
            noOfRows = dataGridView1.RowCount -1;
            totalsurvey.Text = (noOfRows.ToString());

            //calculating sum total of age rows
            int i; double sum = 0;
            for (i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }

            //calculating avg total of age rows 
            double countRow = dataGridView1.Rows.Count -1;
            double avg = sum / countRow;
            avg = Math.Round(avg, 1);
            AvgAge.Text = avg.ToString();


            //Calculating Oldest person who participated in survey 
            AgeMax.Text = (from DataGridViewRow row in dataGridView1.Rows
                           where row.Cells[5].FormattedValue.ToString() != string.Empty
                           select Convert.ToInt32(row.Cells[5].FormattedValue)).Max().ToString();

            //Calculating Youngest person who participated in survey
            AgeMin.Text = (from DataGridViewRow row in dataGridView1.Rows
                           where row.Cells[5].FormattedValue.ToString() != string.Empty
                           select Convert.ToInt32(row.Cells[5].FormattedValue)).Min().ToString();



            //calculate % of people who likes pizza
            double PizzaP;
            int Pizzacount = this.dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["favourite_food"].Value == "Pizza");
            PizzaP = Pizzacount / noOfRows * 100;
            PizzaP = Math.Round(PizzaP, 1);
            this.pizza.Text = PizzaP.ToString() + "%";

            //calculate % of people who likes Pasta
            double PastaP;
            int Pastacount = this.dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["favourite_food"].Value == "Pasta");
            PastaP = Pastacount / noOfRows*100;
            PastaP = Math.Round(PastaP, 1);
            this.Pasta.Text = PastaP.ToString() + "%";

            //calculate % of people who likes Pap and Wors
            double PapandWors;
            int Papcount = this.dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["favourite_food"].Value == "Pap and Wors");
            PapandWors = Papcount / noOfRows*100;
            PapandWors = Math.Round(PapandWors, 1);
            this.Pap.Text = PastaP.ToString() + "%";




            SqlCommand command;
            //Count how many %of I like to eat out
            //SqlCommand command;
            string q = "SELECT COUNT(like_to_eat)FROM UsersDetail WHERE like_to_eat='Strongly Agree' OR like_to_eat='agree' OR like_to_eat='Neutral'";

            command = new SqlCommand(q, cnn);
            //Read from database
            Int32 rows_eat_out = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            double eat_out_Pecentange = 0;
            //calculate the percentage of people who likes pizza
            eat_out_Pecentange = rows_eat_out / noOfRows ;
            eat_out_Pecentange = Math.Round(eat_out_Pecentange, 1);
            eat.Text = eat_out_Pecentange.ToString() ;


            //Count how many %of I like to watch movies
            //SqlCommand command;
            string Qr = "SELECT COUNT(like_Movies)FROM UsersDetail WHERE like_Movies='Strongly Agree' OR like_Movies='agree'";

            command = new SqlCommand(Qr, cnn);
            //Read from database
            Int32 rows_movies = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            double movies_Pecentange = 0;
            //calculate the percentage of  I like to watch movies
            movies_Pecentange = rows_movies / noOfRows ;
            movies_Pecentange = Math.Round(movies_Pecentange, 1);
            movies.Text = movies_Pecentange.ToString() ;


            //Count how many %of I like to watch TV
            //SqlCommand commandQr;
            string Qry = "SELECT COUNT(like_TV)FROM UsersDetail WHERE like_TV='Strongly Agree' OR like_TV='agree' ";

            command = new SqlCommand(Qry, cnn);
            //Read from database
            Int32 rows_tv = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            double tv_Pecentange = 0;
            //calculate the percentage of I like to watch TV
            tv_Pecentange = rows_tv / noOfRows ;
            tv_Pecentange = Math.Round(tv_Pecentange, 1);
            tv.Text = tv_Pecentange.ToString() ;


            //Count how many %of I like to listen to the radio
            //SqlCommand command;
            string Qrys = "SELECT COUNT(like_radio)FROM UsersDetail WHERE like_radio='Strongly Agree' OR like_radio='agree'";

            command = new SqlCommand(Qrys, cnn);
            //Read from database
            Int32 rows_radio = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            double radio_Pecentange = 0;
            //calculate the percentage of I like to listen to the radio
            radio_Pecentange = rows_radio / noOfRows ;
            radio_Pecentange = Math.Round(radio_Pecentange, 1);
            radio.Text = radio_Pecentange.ToString() ;


            

            cnn.Close();
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
