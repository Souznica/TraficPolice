//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TraficPolice
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TrafficPoliceEntities : DbContext
    {
        public TrafficPoliceEntities()
            : base("name=TrafficPoliceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        private static TrafficPoliceEntities _context;
        public static TrafficPoliceEntities GetContext()
        {
            if( _context == null )
                _context = new TrafficPoliceEntities();
            return _context;
        }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<DriversCars> DriversCars { get; set; }
        public virtual DbSet<Incident> Incident { get; set; }
        public virtual DbSet<IncidentsVolations> IncidentsVolations { get; set; }
        public virtual DbSet<Inspector> Inspector { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Violation> Violation { get; set; }
    }
}
