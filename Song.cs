using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP_MusicQuiz
{
    class Song
    {
        private string title;
        private string artist;
        private string category;

        public Song(string newTitle, string newArtist, string newCategory)
        {
            this.title = newTitle;
            this.artist = newArtist;
            this.category = newCategory;
        }

        //getters
        public string getTitle() { return this.title; }
        public string getArtist() { return this.artist; }
        public string getCategory() { return this.category; }

        public string createQuestion()
        {
            //get the first letter of each word in the title
            string initials = Convert.ToString(this.title[0]);

            for (int i = 1; i < this.title.Length; i++)
            {
                char letter = this.title[i];
                if (this.title[i].Equals(' '))
                {

                    initials += " " + this.title[i + 1];
                }
            }
            ////return a string of each initial
            return initials.ToUpper();
        }
    }
}
