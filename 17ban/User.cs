using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    class User
    {
        internal string Name { get; }
        internal IList<Article> Articles { get; set; }
        internal IList<Comment> comment { get; set; }
        internal IList<Suggest> suggest { get; set; }
        internal IList<Problem> problem { get; set; }
        public User(string name)
        {
            Name = name;
        }

       
    }
}
