using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AggregationService.Model
{
    [DataContract(Namespace = Namespaces.Hotelpopcorn)]
    public class SearchCondition
    {
        [DataMember(IsRequired = true)]
        public string FieldName
        {
            get;
            set;
        }

        [DataMember(IsRequired = true)]
        public FieldOperation Operation
        {
            get;
            set;
        }

        [DataMember(IsRequired = true)]
        public string Value
        {
            get;
            set;
        }
    }
}
