using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.DataTables
{
    public class InvestorData
    {
        public string InvestorCompanyId { get; set; }
        public string InvestorCompanyName { get; set; }
        public string LocationName { get; set; }
        public string InstitutionalInvestorStyleName { get; set; }
        public long? ClientValue1 { get; set; }
        public long? ClientValue2 { get; set; }
        public decimal? PercentIC1 { get; set; }
        public decimal? PercentIC2 { get; set; }
        public int? ArrowSecurity1 { get; set; }
        public int? ArrowSecurity2 { get; set; }
        public int? ArrowSegment1 { get; set; }
        public int? ArrowSegment2 { get; set; }
        public double? EstMarketSegmentvalue1 { get; set; }
        public double? EstMarketSegmentvalue2 { get; set; }
        public long? AvgHoldingvalue1 { get; set; }
        public long? AvgHoldingvalue2 { get; set; }
        public int? NumberOfHoldings1 { get; set; }
        public int? NumberOfHoldings2 { get; set; }
        public long? Shares1 { get; set; }
        public long? Shares2 { get; set; }
    }
}
