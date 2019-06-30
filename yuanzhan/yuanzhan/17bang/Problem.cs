using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    class Problem : Pubish//求助
    {
        public int Reward { get; set; }
        public Problem(User author, string title, string body, DateTime date) : base(author, title, body, date)
        {
            Author.problem.Add(this);
        }
    }
}
