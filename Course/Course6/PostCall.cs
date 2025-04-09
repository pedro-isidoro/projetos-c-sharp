﻿using System;
using System.Collections.Generic;
using Course6.PostEntities;

namespace Course6
{
    internal class PostCall
    {
        public void Call()
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("How that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night!");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
