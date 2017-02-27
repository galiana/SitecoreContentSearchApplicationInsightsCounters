
using Sitecore.Diagnostics.PerformanceCounters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foundation.ContentSearchCounters.Counters
{
    public static class ContentSearchCounters
    {
        static ContentSearchCounters()
        {
            TotalSearches = new AbsoluteCounter("Total Searches", "Sitecore.ContentSearch.Search");
            RunningSearches = new AbsoluteCounter("Running Searches", "Sitecore.ContentSearch.Search");
            AverageSearchTime = new AverageCounter("Average Search Time", "Sitecore.ContentSearch.Search");
        }
        public static AbsoluteCounter TotalSearches
        {
            get;
            private set;
        }
        public static AbsoluteCounter RunningSearches
        {
            get;
            private set;
        }
        public static AverageCounter AverageSearchTime
        {
            get;
            private set;
        }
    }
}