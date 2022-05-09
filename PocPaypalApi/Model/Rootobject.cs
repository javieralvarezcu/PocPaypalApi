using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocPaypalApi.Model
{
    public class Rootobject
    {
        public Transaction_Details[] transaction_details { get; set; }
        public string account_number { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string last_refreshed_datetime { get; set; }
        public int page { get; set; }
        public int total_items { get; set; }
        public int total_pages { get; set; }
        public Link[] links { get; set; }
    }
}
