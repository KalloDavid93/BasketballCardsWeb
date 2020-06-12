using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketBallCardTrackerWeb.Models
{
    public class Collection
    {
        public int CollectionId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
    }
}
