using AggregationService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AggregationService.Implementation
{
    public class HotelSearch :BaseApi
    {
        public SearchResult Query(List<SearchCondition> condition, string commaSeperatedSelectfields, SearchOptions searchOptions)
        {
            return null;  
        }

        public SearchResult QueryNext(SearchResult result)
        {
            return null;
        }
    }
}
