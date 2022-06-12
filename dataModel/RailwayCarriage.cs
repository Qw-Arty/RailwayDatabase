using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace railwayDatabase.dataModel
{
    [Table("railway_carriage")]
    public class RailwayCarriage
    {
        [Column("railway_carriage_id")]
        public int RailwayCarriageId { get; set; }
        [ForeignKey("Train")]
        [Column("train_id")]
        public int TrainId { get; set; }
        [Column("railway_carriage_room")]
        public int RailwayCarriageRoom { get; set; }

        public virtual Train Train { get; set; }
        public virtual ICollection<Place> Places { get; set; }
    }
}
