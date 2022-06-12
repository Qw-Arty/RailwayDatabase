using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace railwayDatabase.dataModel
{
    [Table("place")]
    public class Place
    {
        [Column("place_id")]
        public int PlaceId { get; set; }
        [ForeignKey("RailwayCarriage")]
        [Column("railway_carriage_id")]
        public int RailwayCarriageId { get; set; }
        [Column("place_location")]
        public string PlaceLocation { get; set; }
        [Column("place_type")]
        public string PlaceType { get; set; }
        [Column("place_price")]
        public double PlacePrice { get; set; }
        [Column("place_avail")]
        public bool PlaceAvail { get; set; }

        public virtual RailwayCarriage RailwayCarriage { get; set; }
    }
}
