using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.entity.Articled
{
   public class Message
    { 
        public int Id { get; set; }
        public string Context { get; set; }
        public DateTime PublishMessageTime { get; set; }
        public int UserId { get; set; }
    }
}
