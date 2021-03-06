﻿using System;

namespace Interfaces
{
    [Serializable]
    public enum SearchType
    {
        Artist,
        Album,
        Year,
        Format,
        Title
    }


    public interface ISearchCriteria
    {
        SearchType Type { get; }
        string Value { get; }
       
    }

    public interface IIndexer<in T>
    {
        Uri SearchFor(T criteria);
    }
}
