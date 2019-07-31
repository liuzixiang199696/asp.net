using System;
using System.Collections.Generic;
using System.Text;
using BLL;
using BLL.entity;
using BLL.repoistory;
using SRV;

public class SuggestService: BaseService
{
    private SuggestRepoistory _suggestRepoistory;
    private Suggest _suggest;
    private SuggestModel _SuggestModel;
    public List<Suggest> suggests { get; set; }
    public SuggestService(SuggestRepoistory suggestRepoistory, Suggest suggest, SuggestModel suggestModel)
    {
        _suggestRepoistory = suggestRepoistory;
        _suggest = suggest;
        _SuggestModel = suggestModel;
    }
    public void Publish(string title, string Content, DateTime dateTime, int autherid)
    {      
        _suggest.Title = title  ;
        _suggest.Content = Content  ;
        _suggest.PublishSuggestDateTime = dateTime  ;
        _suggest.AutherId= autherid;
        _suggest.Publish(_suggest);

    }
    public List<Suggest> GetSuggest()
    {
        suggests = _suggestRepoistory.GetSuggest();      
        return suggests;
    }

    public SuggestModel GetSuggestSingle(int id )
    {
        _SuggestModel.Id = id;
        _SuggestModel.Title = _suggestRepoistory.GetSuggestSingle(id).Title;
        _SuggestModel.SuggestContent = _suggestRepoistory.GetSuggestSingle(id).Content;
        _SuggestModel.PublishSuggestDateTime = _suggestRepoistory.GetSuggestSingle(id).PublishSuggestDateTime;

        return _SuggestModel;            
    }
}

