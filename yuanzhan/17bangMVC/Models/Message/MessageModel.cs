using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _17bangMVC.Models.Register
{
    public class MessageModel
    {
        public IList<MessageItemModel> Messages { get; set; }

    }
    public class MessageItemModel
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Content { get; set; }
        public bool Selecteed { get; set; }

    }
}