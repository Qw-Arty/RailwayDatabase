using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace railwayDatabase.dataModel
{
    [Table("station")]
    public class Station
    {
        [Column("station_id")]
        public int StationId { get; set; }
        [Column("station_name")]
        public string StationName { get; set; }
        [Column("station_locality")]
        public string StationLocality { get; set; }
    }
}
