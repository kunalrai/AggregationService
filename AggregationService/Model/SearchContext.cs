using AggregationService.Implementation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace AggregationService.Model
{
    [DataContract(Namespace = Namespaces.Hotelpopcorn)]
   
    public class SearchContext
    {
        [DataMember]
        public int CurrentPageNumber
        {
            get;
            set;
        }

        [DataMember]
        public int TotalRecords
        {
            get;
            set;
        }

        [DataMember]
        public string SearchParameters
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

       

        public static string SerializeToXml(SearchContext searchContext)
        {
            if (searchContext == null)
                return "";

            var memoryStream = new MemoryStream();
            var seriaizer = new DataContractSerializer(typeof(SearchContext));

            seriaizer.WriteObject(memoryStream, searchContext);

            var bytes = memoryStream.GetBuffer();

            var encoding = new UTF8Encoding();

            var searchContextString = encoding.GetString(bytes);

            return searchContextString;
        }

        public static SearchContext DeserializeFromXml(string searchContext)
        {
            if (searchContext == null)
                return null;

            var reader = new StringReader(searchContext);
            XmlReader xmlReader = new XmlTextReader(reader);

            var seriaizer = new DataContractSerializer(typeof(SearchContext));
            object searchContextObject = seriaizer.ReadObject(xmlReader);

            if (searchContextObject == null)
                return null;

            return (SearchContext)searchContextObject;
        }

        public static SearchContext SerializeSearchContext(IEnumerable<SearchCondition> conditions, string[] selectfields, QueryOption queryOptions)
        {
            //TODO: Remove batchsize hardcoding

            //prepare searchcontext
            var searchContext = new SearchContext { BatchSize = 1000, CurrentPageNumber = 1 };

            var sb = new StringBuilder(8000);
            sb.Append("<searchContext><conditions>");
            if (conditions != null)
                foreach (var condition in conditions)
                {
                    sb.Append("<condition>");
                    sb.AppendFormat("<FieldName>{0}</FieldName>", condition.FieldName);
                    sb.AppendFormat("<Operation>{0}</Operation>", condition.Operation);
                    sb.AppendFormat("<Value>{0}</Value>", BaseApi.ToSafeXmlString(condition.Value));
                    sb.Append("</condition>");
                }

            sb.Append("</conditions><displayFields>");

            if (selectfields != null)
                foreach (string s in selectfields)
                    sb.AppendFormat("<displayField>{0}</displayField>", s.Trim());

            sb.Append("</displayFields>");


          

            sb.AppendFormat("<orderByField>{0}</orderByField>", queryOptions.OrderByFieldName);
            sb.Append("</searchContext>");
            searchContext.SearchParameters = sb.ToString();

            ////Record per page is always more than 0 and less then or equal to 1000.

            if (queryOptions.BatchSize > 0 && queryOptions.BatchSize <= 1000)
                searchContext.BatchSize = queryOptions.BatchSize;


           
            return searchContext;
        }

        public static void DeserializedSearchContext(string xml, ICollection<SearchCondition> conditions, ICollection<string> selectfields, ref string orderBy)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            if (doc.DocumentElement != null)
            {
                XmlNodeList nodeList = doc.DocumentElement.SelectNodes("conditions/condition");
                if (nodeList != null)
                    for (int index = 0; index < nodeList.Count; index++)
                    {
                        var condition = new SearchCondition
                        {
                            FieldName = nodeList[index].SelectSingleNode("FieldName").InnerText,
                            Operation = (Model.FieldOperation)Enum.Parse(typeof(FieldOperation), nodeList[index].SelectSingleNode("Operation").InnerText),
                            Value = BaseApi.ToOrignalString(nodeList[index].SelectSingleNode("Value").InnerText)
                        };
                        conditions.Add(condition);
                    }
                nodeList = doc.DocumentElement.SelectNodes("displayFields/displayField");
                if (nodeList != null)
                {
                    for (var index = 0; index < nodeList.Count; index++)
                    {
                        selectfields.Add(nodeList[index].InnerText);
                    }
                }
               
                

                nodeList = doc.DocumentElement.SelectNodes("orderByField");
               
                
            }
        }


    }
}
