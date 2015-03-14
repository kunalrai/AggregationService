using AggregationService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AggregationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
     [ServiceContract(Namespace = Namespaces.Hotelpopcorn, SessionMode = SessionMode.Allowed)]
    public interface IAggregationServiceApi
    {
         [OperationContract]

         SearchResult Query(List<SearchCondition> condition, string commaSeperatedSelectfields, SearchOptions searchOptions);
          [OperationContract]
         SearchResult QueryNext(SearchResult queryResult);
         
        
    }




   
}
