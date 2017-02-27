using Sitecore.Pipelines.Search;
using System.Diagnostics;

namespace Foundation.ContentSearchCounters.Processors
{


    public class ContentSearchCountersPreProcessor
    {
        public virtual void Process(SearchArgs args)
        {
            ContentSearchCounters.Counters.ContentSearchCounters.TotalSearches.Value++;
            Counters.ContentSearchCounters.RunningSearches.Value++;
            Stopwatch stw = new Stopwatch();
            stw.Start();
            args.CustomData.Add("BeginSearch", stw);
        }
    }
}