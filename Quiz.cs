using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_MusicQuiz
{
    public partial class Quiz : Form
    {
        private string selectedCategory;
        private List<String> backgroundImages = new List<String>();
        private List<Song> quizSongs = new List<Song>();
        private Song selectedSong;
        private int SongNo = 0;
        private int incorrect = 0;
        private int score = 0;
        
  
        public Quiz(string category)
        {
            this.Visible = false;
            InitializeComponent();
            this.selectedCategory = category;
            SetUpForm(IdentifyQuizType());
            ReadQuestions();
            selectQuestion();
            askQuestion();
        }

        public int IdentifyQuizType()
        {
            int imageNo = 0;
            switch (selectedCategory)
            {
                case "Country Music":
                    imageNo = 0;
                    break;
                case "Christmas Music":
                    imageNo = 4;
                    break;
                case "Indie Rock Music":
                    imageNo = 1;
                    break;
                case "Pop Music":
                    imageNo = 2;
                    break;
                case "RnB Music":
                    imageNo = 3;
                    break;
            }
            return imageNo;
        }

        private void SetUpForm(int backgroundNo)
        {//default form settings - background and size
            this.Text = selectedCategory+" Quiz";
            this.Height = 450;//set size
            this.Width = 850;
            lblHeading.Text = "The "+ selectedCategory + " Quiz";
            // load the backrouind files to the list 
            backgroundImages = Directory.GetFiles("backgrounds", "*.jpg").ToList();
            this.BackgroundImage = Image.FromFile(backgroundImages[backgroundNo]);
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private string getPath(string fileName)
        {//Function to identify the path and filename for the notebook file
            //UPDATE THE CODE TO USE THE DIRECTORY.GETCURRENTDIRECTORY TO IDENTIFY THE PATH
            //CONCATONATE PATH WITH THE FILE NAME AND STORE IN A STRING
            //RETURN THE STRING
            string path = Directory.GetCurrentDirectory();
            string filename = path + @"\" + fileName;
            return filename;
        }

        private void ReadQuestions()
        {// procedure to read all songs that match the selected category from the file and add to a list, 
            TextReader TextFile = new StreamReader(getPath("Songs.csv"));
            //read all values from file into list of items.
            string data;
            string[] songData = new string[3];
            //UPDATE THE CODE TO READ EACH LINE FROM FILE
            //IF THE LINE'S CURRENT CATEGORY MATCHES THE SELECTEDCATORY THEN#
            //ADD TO THE LIST OF QUIZSONGS
            while ((data = TextFile.ReadLine()) != null)
            {
                songData = data.Split(',');
                if (songData[2] == selectedCategory)
                {
                    quizSongs.Add(new Song(songData[0], songData[1], songData[2]));
                }
            }
            TextFile.Close();
        }

        private void selectQuestion()
        {//select a random question from the list, then remove it so it can't be asked again
            //UPDATE THIS CODE SO THAT A SONG IS SELECTED FROM THE LIST OF  QUIZSONGS 
            //AND STORED IN THE SELECTED SONG OBJECT VARIABLE
            //THE SONG THEN NEEDS TO BE REMOVED FROM THE QUIZSONGS LIST
            Random rnd = new Random();
            int x = rnd.Next(0, quizSongs.Count);
            selectedSong = quizSongs[x];
            quizSongs.RemoveAt(x);
        }

        private void askQuestion()
        {//ask question and check answer, update score and question number
            //UPDATE THIS CODE SO THAT:
            //THE NUMBER OF SONGS ARE UPDATED AND THE SONG LABEL IS UPDATED
            //THE ARTIST LABEL IS UPDATED (HINT: YOU WILL NEED TO USE THE SONG GETTER)
            //UPDATE THE TITLE LABLE TO DISPLAY THE INITIALS (HINT: YOU WILL NEED TO USE THE SONG CLASS CREATEQUESTION METHOD)
            //MAKE THE CHECK ANSWER BUTTON VISIBLE
            SongNo = quizSongs.Count;
            lblSongNo.Text = SongNo.ToString();
            lblArtist.Text = selectedSong.getArtist();
            lblTitle.Text = selectedSong.createQuestion();
            btnCheckAnswer.Visible = true;
        }

        private void AnswerClicked(object sender, EventArgs e)
        {//click event for text box
            txtAnswer.Text = "";
            txtAnswer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheckAnswer.Visible = true;
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            btnCheckAnswer.Visible = false;
            lblResult.Visible = true;

            //update the number of questions
            SongNo++;

            //check if answer is correct
            //UPDATE THE CODE SO THAT IT
            //CHECKS IF THE ANSWER ENTERED INTO THE TEXT BOX MATCHES THE 
            //OBJECTS SONG TITLE ATTRIBUTE VALUE (USE GETTERS FOR THIS)
            //IF IT DOES, CHANGE THE LBL RESULTS COLOR TO GREEN AND THE TEXT TO CORRECT ALSO UPDATE THE SCORE
            //IF NOT, UPDATE THE INCORRECT VARIABLE, CHANGE LBLRESULTS COLOR TO RED AND DISPLAY THE CORRECT TITLE

            if (txtAnswer.Text == selectedSong.getTitle())
            {
                lblResult.BackColor = Color.Green;
                lblResult.Text = "Correct!";
                score += 1;
            }
            else
            {
                lblResult.BackColor= Color.Red;
                lblResult.Text = selectedSong.getTitle();
                incorrect += 1;
            }
            btnNextSong.Visible = true;
        }

        private void NextSong(object sender, EventArgs e)
        {
            btnNextSong.Visible = false;
            //UPDATE CODE SO THAT IF SONG NO IS GREATER THAN 10 AND INCORRECT IS LESS THAN 3
            //THE SELECT QUESION METHOD IS CALLED
            //THE ASK QUESTION METHOD IS CALLE
            //OTHERWISE THE THE LABEL RESULT TEXT SHOWS THE FINALS SCORE

            if (SongNo > 10 && incorrect < 3)
            {
                selectQuestion();
                askQuestion();
            }
            else
            {
                lblResult.BackColor = Color.Transparent;
                lblResult.Text = $"Your score is {score.ToString()}";
            }
        }


    }
}
