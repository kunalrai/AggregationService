using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AggregationServiceTest
{
    [TestClass]
    public class SearchUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Query()
        {
            //var sc = new SearchCondition { FieldName = "Name", Operation = FieldOperation.Like, Value = "New" };

            //var searchConditions = new List<SearchCondition> { sc };
            //var selectFields = new[] { "Name" };

            //QueryResult q = this.client.Query(
            //        
            //       
            //        searchConditions.ToArray(),
            //        selectFields,
            //        new QueryOptions { BatchSize = 100, BatchSizeSpecified = true, OrderByFieldName = "ID" });
            //PrintResult(q);
        }

        [TestMethod]
        public void PagingTest()
        {
            //var sc = new SearchCondition { FieldName = "Name", Operation = FieldOperation.Like, Value = "New" };

            //var searchConditions = new List<SearchCondition> { sc };
            //var selectFields = new[] { "Name" };

            //QueryResult q = this.client.Query(
            //        
            //       
            //        searchConditions.ToArray(),
            //        selectFields,
            //        new QueryOptions { BatchSize = 100, BatchSizeSpecified = true, OrderByFieldName = "ID" });
            //PrintResult(q);
            //while (!q.IsDone)
            //{
            //    q = this.client.QueryNext( q);
            //    PrintResult(q);
            //}
        }
    }
}
