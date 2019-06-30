using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    class Pubish:IPublish
    {
        internal User Author { get; }
        internal string Title { get; }
        internal string Body { get; }
        internal DateTime _date { get; }
        public Pubish(User author, string title, string body, DateTime date)
        {
            Author = author;
            Title = title;
            Body = body;
            _date = date;
        }

        internal void Pubilc()
        {
        }
        internal void Agree()
        {
        }
        internal void Disagree()
        {
        }
        internal void Comment()
        {
        }

        public void Publish()
        {
            throw new NotImplementedException();
        }
    }

}
