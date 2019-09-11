using Microsoft.EntityFrameworkCore;

namespace Sheleski.Roobug.Geo.EntityFrameworkCore
{
    public static class ModelBuilderExtensions
    {
        public static void UseGeo(this ModelBuilder modelBuilder)
        {
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<City>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<CityIpAddres>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<Continent>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<Country>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<CountryNeighbor>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<County>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<State>());
        }
    }
}
