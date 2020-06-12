using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketBallCardTrackerWeb.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public int CardCollectionId { get; set; }
        public string Season { get; set; }
        public string Box { get; set; }
        public string Insert { get; set; }
        public string Player { get; set; }
        public string Serial { get; set; }
        public string Parallel { get; set; }
        public int? NumberedTo { get; set; }
        public int? ActualNumber { get; set; }
        public string Seller { get; set; }
        public int Quantity { get; set; }
        public string IMGUrl { get; set; }
    }
}
