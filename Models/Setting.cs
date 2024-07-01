using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSystem.Models
{
    internal class Setting
    {
        public String Month { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SCDRange { get; set; }
        public int Leaves { get; set; }
        public decimal Tax { get; set; }
        public int Holiday { get; set; }

        public Setting(String month, DateTime beginDate, DateTime endDate, int sCDRange, int leaves, decimal tax, int holiday)
        {
            Month = month;
            BeginDate = beginDate;
            EndDate = endDate;
            SCDRange = sCDRange;
            Leaves = leaves;
            Tax = tax;
            Holiday = holiday;
        }
        public Setting()
        { }
    }

}
