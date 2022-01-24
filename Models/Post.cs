using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MNS_Reviews.Models
{

    public class Post 
    {
        public int PostId { get; set; }
        public string title { get; set; } 
        public string text { get; set; }
        public DateTime CreatedTimestamp { get; set; }

        /*
        public Post(string title, string text)
        {
            this.title = title;
            this.text = text;
        }
        */


        public override string ToString()
        {

            return "ID: " + PostId + " " +
             "Title: " + title + " " +
             "Text: " + text + " ";
        }

    }


    
}