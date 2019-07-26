using BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
   public class SuggestModel
    {
        public int Id { get; set; }
        public string Title { get; set; }             
        public string SuggestContent { get; set; }
        public DateTime PublishSuggestDateTime { get; set; }
    }
}
