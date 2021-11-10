using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDelegate.Relation
{
    class Poster
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Movie Movie { get; set; }
    }
}
