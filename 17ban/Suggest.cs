using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    class Suggest : Common
    {
        public Suggest(User author, string title, string body, DateTime date) : base(author, title, body, date)
        {
            Author.suggest.Add(this);
        }
    }
}
