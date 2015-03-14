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
            //TODO: parse search condition 
            //TODO: check the select fields for output
            //TODO: get the data according to batchsize
            //TODO: Set SearchResult.IsDone fase if data is more than 100 pages or more than batch size.

            return null;  
        }

        public SearchResult QueryNext(SearchResult result)
        {
            //TODO: Get the next page data according to page size.
            //TODO: Set search context here where store the totalpage,currentpage , search-criteria

            return null;
        }
    }
}
