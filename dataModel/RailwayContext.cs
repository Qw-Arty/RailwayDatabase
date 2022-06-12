

using System.Data.Entity;

namespace railwayDatabase.dataModel
{

    public class RailwayContext : DbContext

    {
        private static RailwayContext _context;
        // Контекст настроен для использования строки подключения "RailwayContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "railwayDatabase.dataModel.RailwayContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "RailwayContext" 
        // в файле конфигурации приложения.
        public RailwayContext()
            : base("name=PostgreSql")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<Route>()
        .HasMany(c => c.TrainsCollection)
        .WithMany(p => p.CollextionRoutes)
        .Map(m =>
        {
            // Ссылка на промежуточную таблицу
            m.ToTable("train_route");

            // Настройка внешних ключей промежуточной таблицы
            m.MapLeftKey("route_id"); 
            m.MapRightKey("train_id");
        });
            base.OnModelCreating(modelBuilder);
        }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Train> Trains { get; set; }
        //public virtual DbSet<TrainRoute> TrainRoutes { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<RailwayCarriage> RailwayCarriages { get; set; }
        public virtual DbSet<PairsOfStations> PairsOfStationses { get; set; }

        public static RailwayContext GetContext()
        {
            if (_context == null)
            {
                _context = new RailwayContext();
            }
            return _context;
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}