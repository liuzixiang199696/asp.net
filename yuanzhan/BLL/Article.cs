using BLL.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
  public  class Article: Entity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishSuggestDateTime { get; set; }
         public string DiscriminatorType { get; set; }
    }
}
