using Sitecore.Pipelines.Search;
using System.Diagnostics;

namespace Foundation.ContentSearchCounters.Processors
{


    public class ContentSearchCountersPostProcessor
    {
        public virtual void Process(SearchArgs args)
        {
            Counters.ContentSearchCounters.RunningSearches.Value--;
            object stw;
            if (args.CustomData.TryGetValue("BeginSearch",out stw))
            {

                Stopwatch sw = (Stopwatch)stw;
                Counters.ContentSearchCounters.AverageSearchTime.AddMeasurement(sw.ElapsedMilliseconds);
                sw.Stop();
            }
        }
    }
}