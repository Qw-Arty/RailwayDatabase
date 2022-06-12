using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace railwayDatabase.dataModel
{
    [Table("train")]
    public class Train
    {
        [Column("train_id")]
        public int TrainId { get; set; }
        [Column("train_type")]
        public string TrainType { get; set; }
        [Column("train_name")]
        public string TrainName { get; set; }
        public virtual ICollection<Route> CollextionRoutes { get; set; }
        public virtual ICollection<RailwayCarriage> RailwayCarriages { get; set; }
    }
}
