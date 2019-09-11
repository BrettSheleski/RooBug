using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Geo.EntityFrameworkCore
{
    public partial class ModelEntityBuilders
    {
        public static string Schema
        {
            get => "geo";
        }

        public static void BuildModelEntity(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("city", Schema).HasKey(nameof(City.CityId));

            builder.Property(p => p.AsciiName).HasColumnName("ascii_name").HasMaxLength(200).IsRequired();
            builder.Property(p => p.CityId).HasColumnName("city_id").IsRequired();
            builder.Property(p => p.CountryCode).HasColumnName("country_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.Elevation).HasColumnName("elevation").IsRequired();
            builder.Property(p => p.GeonameId).HasColumnName("geoname_id").IsRequired();
            builder.Property(p => p.IsActive).HasColumnName("is_active").IsRequired();
            builder.Property(p => p.Latitude).HasColumnName("latitude").IsRequired();
            builder.Property(p => p.Longitude).HasColumnName("longitude").IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(200).IsRequired();
            builder.Property(p => p.Population).HasColumnName("population").IsRequired();
            builder.Property(p => p.StateId).HasColumnName("state_id").IsRequired();
            builder.Property(p => p.Timezone).HasColumnName("timezone").HasMaxLength(50).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<CityIpAddres> builder)
        {
            builder.ToTable("city_ip_address", Schema).HasKey(nameof(CityIpAddres.CityIpAddressId));

            builder.Property(p => p.CityId).HasColumnName("city_id").IsRequired();
            builder.Property(p => p.CityIpAddressId).HasColumnName("city_ip_address_id").IsRequired();
            builder.Property(p => p.IpAddressEnd).HasColumnName("ip_address_end").HasMaxLength(15).IsRequired();
            builder.Property(p => p.IpAddressEndNumeric).HasColumnName("ip_address_end_numeric").IsRequired();
            builder.Property(p => p.IpAddressStart).HasColumnName("ip_address_start").HasMaxLength(15).IsRequired();
            builder.Property(p => p.IpAddressStartNumeric).HasColumnName("ip_address_start_numeric").IsRequired();
            builder.Property(p => p.Network).HasColumnName("network").HasMaxLength(19).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<Continent> builder)
        {
            builder.ToTable("continent", Schema).HasKey(nameof(Continent.ContinentCode)); ;

            builder.Property(p => p.ContinentCode).HasColumnName("continent_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.GeonameId).HasColumnName("geoname_id").IsRequired();
            builder.Property(p => p.IsActive).HasColumnName("is_active").IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(100).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("country", Schema).HasKey(nameof(Country.CountryCode));

            builder.Property(p => p.AreaSqKm).HasColumnName("area_sq_km").IsRequired();
            builder.Property(p => p.Capital).HasColumnName("capital").HasMaxLength(100).IsRequired();
            builder.Property(p => p.ContinentCode).HasColumnName("continent_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.CountryCode).HasColumnName("country_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.CurrencyCode).HasColumnName("currency_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.CurrencyName).HasColumnName("currency_name").HasMaxLength(10).IsRequired();
            builder.Property(p => p.FipsCode).HasColumnName("fips_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.FormalName).HasColumnName("formal_name").HasMaxLength(250).IsRequired();
            builder.Property(p => p.GeonameId).HasColumnName("geoname_id").IsRequired();
            builder.Property(p => p.IsActive).HasColumnName("is_active").IsRequired();
            builder.Property(p => p.Iso3Code).HasColumnName("iso3_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.IsoNumericCode).HasColumnName("iso_numeric_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.Latitude).HasColumnName("latitude").IsRequired();
            builder.Property(p => p.Longitude).HasColumnName("longitude").IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
            builder.Property(p => p.Phone).HasColumnName("phone").HasMaxLength(10).IsRequired();
            builder.Property(p => p.Population).HasColumnName("population").IsRequired();
            builder.Property(p => p.PostalCodeFormat).HasColumnName("postal_code_format").HasMaxLength(100).IsRequired();
            builder.Property(p => p.PostalCodeRegex).HasColumnName("postal_code_regex").HasMaxLength(250).IsRequired();
            builder.Property(p => p.Tld).HasColumnName("tld").HasMaxLength(10).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<CountryNeighbor> builder)
        {
            builder.ToTable("country_neighbor", Schema).HasKey(nameof(CountryNeighbor.CountryCode), nameof(CountryNeighbor.NeighborCountryCode));

            builder.Property(p => p.CountryCode).HasColumnName("country_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.NeighborCountryCode).HasColumnName("neighbor_country_code").HasMaxLength(10).IsRequired();
        }

        public static void BuildModelEntity(EntityTypeBuilder<County> builder)
        {
            builder.ToTable("county", Schema).HasKey(nameof(County.CountyId));

            builder.Property(p => p.AsciiName).HasColumnName("ascii_name").HasMaxLength(200).IsRequired();
            builder.Property(p => p.CountryCode).HasColumnName("country_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.CountyId).HasColumnName("county_id").IsRequired();
            builder.Property(p => p.Elevation).HasColumnName("elevation").IsRequired();
            builder.Property(p => p.GeonameId).HasColumnName("geoname_id").IsRequired();
            builder.Property(p => p.IsActive).HasColumnName("is_active").IsRequired();
            builder.Property(p => p.Latitude).HasColumnName("latitude").IsRequired();
            builder.Property(p => p.Longitude).HasColumnName("longitude").IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(200).IsRequired();
            builder.Property(p => p.Population).HasColumnName("population").IsRequired();
            builder.Property(p => p.StateId).HasColumnName("state_id").IsRequired();
            builder.Property(p => p.Timezone).HasColumnName("timezone").HasMaxLength(50).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("state", Schema).HasKey(nameof(State.StateId));

            builder.Property(p => p.AsciiName).HasColumnName("ascii_name").HasMaxLength(200).IsRequired();
            builder.Property(p => p.CountryCode).HasColumnName("country_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.Elevation).HasColumnName("elevation").IsRequired();
            builder.Property(p => p.GeonameId).HasColumnName("geoname_id").IsRequired();
            builder.Property(p => p.IsActive).HasColumnName("is_active").IsRequired();
            builder.Property(p => p.Latitude).HasColumnName("latitude").IsRequired();
            builder.Property(p => p.Longitude).HasColumnName("longitude").IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(200).IsRequired();
            builder.Property(p => p.Population).HasColumnName("population").IsRequired();
            builder.Property(p => p.StateCode).HasColumnName("state_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.StateId).HasColumnName("state_id").IsRequired();

        }
    }
}
