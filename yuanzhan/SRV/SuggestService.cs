using System;
using System.Collections.Generic;
using System.Text;
using BLL;
using BLL.Repoistory;

public class SuggestService
{
    public void Publish(string title, string Content, DateTime dateTime)
    {
        Suggest suggest = new Suggest
        {
            SuggestTitle = title,
            SuggestContent = Content,
            PublishSuggestDateTime = dateTime
        };
        suggest.Publish(suggest);

    }
}
