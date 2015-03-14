using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AggregationService.Model
{
    [DataContract(Namespace = Namespaces.Hotelpopcorn)]
    public class QueryOption
    {
        [DataMember]
        public string OrderByFieldName
        {
            get;
            set;
        }

        [DataMember]
        public int BatchSize
        {
            get;
            set;
        }
    }
}
