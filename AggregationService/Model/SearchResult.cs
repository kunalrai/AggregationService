using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AggregationService.Model
{
    [DataContract(Namespace = Namespaces.Hotelpopcorn)]
    public class SearchResult
    {
        [DataMember]
        public SearchContext SearchContext
        {
            get;
            set;
        }

        [DataMember]
        public bool IsDone
        {
            get;
            set;
        }
    }
}
