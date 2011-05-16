using System;
using System.Configuration;
using System.Net;
using Interfaces;
using Logic.Model;

namespace Logic
{
    internal delegate Uri SearchPeer(ISearchCriteria c, int depth);

    [Serializable]
    public class SearchCriteria : ISearchCriteria
    {
        #region Implementation of ISearchCriteria

        public SearchType Type { get; internal set; }

        public string Value { get; internal set; }

        #endregion

        public SearchCriteria(SearchType type, string value)
        {
            Type = type;
            Value = value;
        }
    }

    public class LocalIndexer : IIndexer<ISearchCriteria>
    {
        #region Implementation of IIndexer

        private readonly MusicDatabase _dataBase;

        public LocalIndexer(MusicDatabase data)
        {
            _dataBase = data;
        }

        public Uri SearchFor(ISearchCriteria criteria)
        {
            if (_dataBase.HasAlbum(criteria.Value))
            {
                IPAddress ip = null;

                foreach(var i in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
                {
                    if(!i.IsIPv6LinkLocal)
                    {
                        ip = i;
                        break;
                    }
                }

                return new Uri(string.Format("http://{0}:{1}/{2}", "localhost", ConfigurationManager.AppSettings["port"], Peer.Self.Name));
            }

           return null;
        }

        #endregion
    }
}