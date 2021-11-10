using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDelegate.Relation
{
    class Ticket
    {
        public int Id { get; set; }
        public Poster Poster { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public DateTime SellDate { get; set; }
    }
}
