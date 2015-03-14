using AggregationService.Implementation;
using AggregationService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace AggregationService
{
    [ServiceBehavior(Namespace = Namespaces.Hotelpopcorn, ConcurrencyMode = ConcurrencyMode.Multiple)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.NotAllowed)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AggregationServiceApi : IAggregationServiceApi
    {
        public SearchResult Query(List<SearchCondition> condition, string commaSeperatedSelectfields, SearchOptions searchOptions)
        {
            return new HotelSearch().Query(condition, commaSeperatedSelectfields, searchOptions);
        }

        public SearchResult QueryNext(SearchResult queryResult)
        {
            return new HotelSearch().QueryNext(queryResult);
        }
    }
}
