using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Dynamic.Core;

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
            CustTable.Rows.Add(2061, "A&G U1 ", "San Francisco", "Index", 345, null, null, 0.665341,
                -3, -3, 0, 0, 21426.6264, 22168.6907, 906490, 93829, 22, 22, 1556, 12880);
            CustTable.Rows.Add(2061, "Philips", "San Francisco", "Index", 9631, 7955, 0.804108, 0.665341,
                -3, -3, 0, 0, 21426.6264, null, 906490, 93829, 22, 22, 1556, null);
            CustTable.Rows.Add(2061, "Boat  ", "Leeds", "Index", 1243, 7955, 0.804108, null,
                -3, -3,null, 0, 21426.6264, 22168.6907, 906490, 93829, 22, 22, 1556, 12880);
            CustTable.Rows.Add(2061, "Zara  ", "Berlin", "Index", 9631, null, 0.804108, 0.665341,
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
                        list = list.AsQueryable().OrderBy(column).ToList();
                    }
                    else
                    {
                        list = list.AsQueryable().OrderBy(string.Concat(column, " descending")).ToList();
                    }
                }
            }
            return list;
        }
        public static DataTable PrinDataTable(DataTable dt)
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
            return dt;
        }
        //public static List ConvertDtToList(DataTable dt)
        //{
        //    List<Student> studentList = new List<Student>();
        //    for (int i = 0; i<dt.Rows.Count; i++)
        //    {
        //        Student student = new Student();
        //        student.StudentId = Convert.ToInt32(dt.Rows[i]["StudentId"]);
        //        student.StudentName = dt.Rows[i]["StudentName"].ToString();
        //        student.Address = dt.Rows[i]["Address"].ToString();
        //        student.MobileNo = dt.Rows[i]["MobileNo"].ToString();
        //        studentList.Add(student);
        //    }
        //}
    }
}
