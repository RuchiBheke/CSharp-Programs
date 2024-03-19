using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
namespace CSharpFundamentals.DataTables
{
    public static class DataTableSort
    {   
        public static DataTable DataTables()
        {
            DataTable CustTable = new DataTable("Customers");
            CustTable.Columns.Add("InvestorCompanyId", typeof(int)); //1
            CustTable.Columns.Add("InvestorCompanyName", typeof(String)); //2
            CustTable.Columns.Add("LocationName", typeof(String)); //3
            CustTable.Columns.Add("InstitutionalInvestorStyleName", typeof(String)); //4
            CustTable.Columns.Add("ClientValue1", typeof(long)); //5
            CustTable.Columns.Add("ClientValue2", typeof(long)); //6
            CustTable.Columns.Add("PercentIC1", typeof(decimal)); //7
            CustTable.Columns.Add("PercentIC2", typeof(decimal)); //8
            CustTable.Columns.Add("ArrowSecurity1", typeof(int)); //9
            CustTable.Columns.Add("ArrowSecurity2", typeof(int)); //10
            CustTable.Columns.Add("ArrowSegment1", typeof(int)); //11
            CustTable.Columns.Add("ArrowSegment2", typeof(int)); //12
            CustTable.Columns.Add("EstMarketSegmentvalue1", typeof(double)); //13
            CustTable.Columns.Add("EstMarketSegmentvalue2", typeof(double)); //14
            CustTable.Columns.Add("AvgHoldingvalue1", typeof(long)); //15
            CustTable.Columns.Add("AvgHoldingvalue2", typeof(long)); //16
            CustTable.Columns.Add("NumberOfHoldings1", typeof(int)); //17
            CustTable.Columns.Add("NumberOfHoldings2", typeof(int)); //18
            CustTable.Columns.Add("Shares1", typeof(long)); //19 
            CustTable.Columns.Add("Shares2", typeof(long)); //20
            CustTable.Rows.Add(2061, "BlackRock ", "San Francisco", "Index", null,null,null,null,
                null, null, null, null, null, null, null, null, null, null, null, null);
            CustTable.Rows.Add(2061, "Osiscris ", "Delhi", "Index", null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null);
            CustTable.Rows.Add(2061, "Vanguard", "Australia", "Index", null, 7955, 0.04108, 0.665341,
                -3, -3, 0, 0, null, 22168.6907, 906490, 93829, 22, 22, 1556, 12880);
            CustTable.Rows.Add(2061, "ICIC Bank", "Autralia", "Index", null, null, 0.34108, 0.85341,
                -45, -3, 0, 0, 42426.6264, 22168.6907, 978490, 93829, 21, 20, 1456, 8880);
            CustTable.Rows.Add(2061, "A&G U1 ", "San Francisco", "Index", 3, null, null, 0.665341,
                -3, -3, 0, 0, 21426.6264, 22168.6907, 906490, 93829, 22, 22, 1556, 12880);
            CustTable.Rows.Add(2061, "Philips", "San Francisco", "Index", 631, 7955, 0.804108, 0.665341,
                -3, -3, 0, 0, 21426.6264, null, 906490, 93829, 22, 22, 1556, null);
            CustTable.Rows.Add(2061, "Boat  ", "Leeds", "Index", 43, 7955, 0.804108, null,
                -3, -3,null, 0, 21426.6264, 22168.6907, 906490, 93829, 22, 22, 1556, 12880);
            CustTable.Rows.Add(2061, "Zara  ", "Berlin", "Index", 9, null, 0.804108, 0.665341,
                -3, -3, 0, 0, null, 22168.6907, 906490, 93829, null, 22, 1556, null);
            CustTable.Rows.Add(2061, "BlackFish ", "Chicago", "Index", 5631, 3155, 0.94108, 0.5341,
                -3, -3, 0, 0, 21426.6264, 22168.6907, 906490, 93829, 22, 22, 1556, 12880);
            CustTable.Rows.Add(2061, "BlackCat ", "Andheri", "Index", 9631, 7955, 0.804108, 0.665341,
                -3, -3, 0, 0, 9826.6264, 34168.6907, 746490, 93829, null, 22, 1556, 12880);
            CustTable.Rows.Add(2061, "BlackHorse", "Malad", "Index", 9631, 7955, 0.804108, 0.665341,
                null, -3, 0, 0, 21426.6264, 34768.6907, 86490, 93829, 22, null, 1556, 12880);
            CustTable.Rows.Add(2061, "BlackCatch ", "Virar", "Index", 9631, 7955, 0.804108, 0.665341,
                null, -3, 12, 0, 21426.6264, 22168.6907, 906490, 93829, null, 22, 1556, 12880);
            CustTable.Rows.Add(2061, "BlackWall ", "Vikhroli", "Index", 9631, 7955, 0.804108, 0.665341,
                -3, -3, 0, 0, 2926.6264, 22168.6907, 906490, 93829, 22, 22, 1556, 12880);
            CustTable.Rows.Add(2061, "BlackTiger ", "Panvel", "Index", 9631, 7955, 0.804108, 0.665341,
                -3, -3, 0, 0, 32426.6264, 22168.6907, 906490, 93829, 22, 22, 1556, 12880);
            return CustTable;
        }
        public static List<T> ToSort<T>( List<T> list, string sortvalue)
        {
            string[] sortBy = sortvalue?.Split(' ');
            if (sortBy?.Length > 1)
            {
                string direction = sortvalue.Split(' ')[1].ToUpper();
                string column = sortvalue.Split(' ')[0];
                if (list?.Count > 0)
                {
                    if (direction == "ASC")
                    {
                        list = list.AsQueryable().OrderBy(column == null? "1": "0", column).ToList();
                    }
                    else
                    {
                        list = list.AsQueryable().OrderBy(string.Concat(column, " descending")).ToList();
                    }
                }
            }
            return list;
        }
        //public static Expression<Func<InvestorData>, object> CreateOrderExpression()
        //{
        //    return x => x.column == null ? 1 : 0;
        //}
        public static void PrinDataTable(DataTable dt)
        {   
            foreach(DataColumn column in dt.Columns)
            {
                Console.Write(column.ColumnName + " ");
            }
            Console.WriteLine("\n");
            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item + "\t  "); 
                }
                Console.WriteLine("\n\n");
            }
        }
        public static void PrintList(List<InvestorData> invlist)
        {
            int i = 1;
             foreach(var item in invlist)
            {
                {
                    Console.WriteLine($"InvestorCompanyId: {item.InvestorCompanyId}, InvestorCompanyName: {item.InvestorCompanyName}, LocationName: {item.LocationName}," +
                        $"InstitutionalInvestorStyleName: {item.InstitutionalInvestorStyleName}, ClientValue1: {item.ClientValue1}, ClientValue2: {item.ClientValue2}, " +
                        $"ClientValue2: {item.ClientValue2}, PercentIC1: {item.PercentIC1}, PercentIC2: {item.PercentIC2}, ArrowSecurity1: {item.ArrowSecurity1}, ArrowSecurity2: {item.ArrowSecurity2}," +
                        $"EstMarketSegmentvalue1: {item.EstMarketSegmentvalue1}, EstMarketSegmentvalue2: {item.EstMarketSegmentvalue2}, AvgHoldingvalue1: {item.AvgHoldingvalue1}," +
                        $"AvgHoldingvalue2: {item.AvgHoldingvalue2}, NumberOfHoldings1: {item.NumberOfHoldings1}, NumberOfHoldings2: {item.NumberOfHoldings2}, Share1: {item.Shares1}, Share2: {item.Shares2}");
                    i++;
                }
                Console.WriteLine();
            }
        }
        public static List<InvestorData> ConvertDtToList(DataTable dt)
        {
            List<InvestorData> investorList = new List<InvestorData>();
            for (int i = 0; i<dt.Rows.Count; i++)
            {
                InvestorData investor = new InvestorData();
                investor.InvestorCompanyId  = dt.Rows[i]["InvestorCompanyId"].ToString();
                investor.InvestorCompanyName = dt.Rows[i]["InvestorCompanyName"].ToString();
                investor.LocationName = dt.Rows[i]["LocationName"].ToString();
                investor.InstitutionalInvestorStyleName = dt.Rows[i]["InstitutionalInvestorStyleName"].ToString();
                investor.ClientValue1 = ConvertToNullable<long>(dt.Rows[i]["ClientValue1"]);
                investor.ClientValue2 = ConvertToNullable<long>(dt.Rows[i]["ClientValue2"]);
                investor.PercentIC1 = ConvertToNullable<Decimal>(dt.Rows[i]["PercentIC1"]);
                investor.PercentIC2 = ConvertToNullable<Decimal>(dt.Rows[i]["PercentIC2"]);
                investor.ArrowSecurity1 = ConvertToNullable<int>(dt.Rows[i]["ArrowSecurity1"]);
                investor.ArrowSecurity2 = ConvertToNullable<int>(dt.Rows[i]["ArrowSecurity2"]);
                investor.ArrowSegment1 = ConvertToNullable<int>(dt.Rows[i]["ArrowSegment1"]);
                investor.ArrowSegment2 = ConvertToNullable<int>(dt.Rows[i]["ArrowSegment2"]);
                investor.EstMarketSegmentvalue1 = ConvertToNullable<Double>(dt.Rows[i]["EstMarketSegmentvalue1"]);
                investor.EstMarketSegmentvalue2 = ConvertToNullable<Double>(dt.Rows[i]["EstMarketSegmentvalue2"]);
                investor.AvgHoldingvalue1 = ConvertToNullable<long>(dt.Rows[i]["AvgHoldingvalue1"]);
                investor.AvgHoldingvalue2 = ConvertToNullable<long>(dt.Rows[i]["AvgHoldingvalue2"]);
                investor.NumberOfHoldings1 = ConvertToNullable<int>(dt.Rows[i]["NumberOfHoldings1"]);
                investor.NumberOfHoldings2 = ConvertToNullable<int>(dt.Rows[i]["NumberOfHoldings2"]);
                investor.Shares1 = ConvertToNullable<long>(dt.Rows[i]["Shares1"]);
                investor.Shares2 = ConvertToNullable<long>(dt.Rows[i]["Shares2"]);
                investorList.Add(investor);
            }
            return investorList;
        }
        public static T? ConvertToNullable<T>(object value) where T : struct
        {
            if(value ==null ||value == DBNull.Value)
            {
                return null;
            }
            try
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                return null;
            }
        }
        public static DataRow NullCheckLong(this DataRow value)
        {
            DataRow flag =  null == DBNull.Value ? null :value;
            return flag;
        }
        public static DataRow NullCheckDecimal(this DataRow value)
        {
            DataRow flag = null == DBNull.Value ? null : value;
            return flag;
        }
    }
}
