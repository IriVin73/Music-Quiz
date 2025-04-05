using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_MusicQuiz
{
    public partial class StartMenu : Form
    {//attributes
        private string selectedCategory;
       // private int SongNo = 0;
        public StartMenu()
        {//constructor
            InitializeComponent();//draw components
            SetUpForm();//default settings
        }

        private void SetUpForm()
        {//default form settings - background and size
            this.Text = "Music Quiz Menu";
            this.Height = 450;//set size
            this.Width = 800;
            BackgroundImage = Image.FromFile(@"backgrounds\bg.jpeg");//set background
            BackgroundImageLayout = ImageLayout.Stretch;
            btnStartQuiz.Enabled = false;
        }

        private void CategorySelected(object sender, EventArgs e)
        {//validate category selection and store it in a variable
            //UPDATE THE CODE SO THAT THE SELECTED CATEGORY VALUE IS EQUAL
            //TO THE VALUE SELECTED FROM THE LIST BOX
            //ENABLE THE START BUTTON
            selectedCategory = Convert.ToString(lstCategories.SelectedItem);
            btnStartQuiz.Enabled = true;
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            //CREATE A NEW QUIZ OBJECT (MAKE SURE THAT PASS IN THE SELECTED CATEGORY)
            //USE THE SHOW DIALOG METHOD TO OPEN THE NEW QUIZ OBJECT
            //CLOSE THE CURRENT FORM
            Quiz n =new Quiz(Convert.ToString(selectedCategory));
            n.ShowDialog();
            this.Close();
        }
    }
}
