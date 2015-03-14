using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;

namespace AggregationService.Model
{
    [DataContract(Namespace = Namespaces.Hotelpopcorn)]
    public enum FieldOperation
    {
        [EnumMember]
        Equal = 0,

        [EnumMember]
        Like =1,

        [EnumMember]
        NotEqual = 2
    }
}
