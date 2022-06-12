using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace railwayDatabase.dataModel
{
    [Table("pairs_of_stations")]
    public class PairsOfStations
    {
        [Column("pairs_of_stations_id")]
        public int PairsOfStationsId { get; set; }
        [ForeignKey("Route")]
        [Column("route_id")]
        public int RouteId { get; set; }
        [ForeignKey("StationStart")]
        [Column("starting_station_id")]
        public int StartingStationId { get; set; }
        [ForeignKey("StationEnd")]
        [Column("end_station_id")]
        public int EndStationId { get; set; }


        [Column("departure_time")]
        public string DepartureTime { get; set; }
        [Column("arrival_time")]
        public string ArrivalTime { get; set; }
        [Column("flag_starting_station")]
        public bool FlagStartingStation { get; set; }
        [Column("flag_end_station")]
        public bool FlagEndStation { get; set; }

        public virtual Route Route { get; set; }

        public virtual Station StationStart { get; set; }
        public virtual Station StationEnd { get; set; }


    }
}
