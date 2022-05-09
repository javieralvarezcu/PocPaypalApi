using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocPaypalApi.Model
{
    public class Transaction_Info
    {
        public string transaction_id { get; set; }
        public string transaction_event_code { get; set; }
        public string transaction_initiation_date { get; set; }
        public string transaction_updated_date { get; set; }
        public Transaction_Amount transaction_amount { get; set; }
        public string transaction_status { get; set; }
        public string transaction_subject { get; set; }
        public Ending_Balance ending_balance { get; set; }
        public Available_Balance available_balance { get; set; }
        public string protection_eligibility { get; set; }
        public string instrument_type { get; set; }
        public string instrument_sub_type { get; set; }
    }
}
