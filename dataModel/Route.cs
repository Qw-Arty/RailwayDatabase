using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace railwayDatabase.dataModel
{
    [Table("route")]
    public class Route
    {
        [Column("route_id")]
        public int RouteId { get; set; }
        [Column("route_name")]
        public string RouteName { get; set; }
        [Column("departure_time_global")]
        public string DepartureTimeGlobal { get; set; }
        [Column("arrival_time_globale")]
        public string ArrivalTimeGlobale { get; set; }
        [ForeignKey("StationStart")]
        [Column("starting_station_global_id")]
        public int StartingStationGlobalId { get; set; }
        [ForeignKey("StationEnd")]
        [Column("end_station_global_id")]
        public int EndStationGlobalId { get; set; }

        public virtual Station StationStart { get; set; }
        public virtual Station StationEnd { get; set; }

        public virtual ICollection<PairsOfStations> PairsOfStations { get; set; }
        public virtual ICollection<Train> TrainsCollection { get; set; }
    }
}
