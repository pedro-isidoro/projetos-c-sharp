using System;
using System.Collections.Generic;
using System.Text;
using Course6.PostEntities;

namespace Course6.PostEntities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();


        public Post()
        {
        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public override string ToString()
        {
            //usando stringBuilder - Ele faz a montagem dele de forma eficiente, edepois só pega
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }

        public void AddComment(Comment comment) { 
            Comments.Add(comment);
        }
        
        public void RemoveComment(Comment comment) { 
            Comments.Remove(comment);
        }
    }
}
