﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccommodationCommission> AccommodationCommissions { get; set; }
        public virtual DbSet<AccommodationLatLong> AccommodationLatLongs { get; set; }
        public virtual DbSet<AvailHotelCode> AvailHotelCodes { get; set; }
        public virtual DbSet<FileName> FileNames { get; set; }
        public virtual DbSet<GetHotelAvailInfo> GetHotelAvailInfoes { get; set; }
        public virtual DbSet<InsuranceCity> InsuranceCities { get; set; }
        public virtual DbSet<InsuranceCountry> InsuranceCountries { get; set; }
        public virtual DbSet<InsurancePlan> InsurancePlans { get; set; }
        public virtual DbSet<JsonData> JsonDatas { get; set; }
        public virtual DbSet<NamesTemp2> NamesTemp2 { get; set; }
        public virtual DbSet<PerEngCityName> PerEngCityNames { get; set; }
        public virtual DbSet<RailwayStation> RailwayStations { get; set; }
        public virtual DbSet<RailwayStationTemp> RailwayStationTemps { get; set; }
        public virtual DbSet<RailwayStationTemp2> RailwayStationTemp2 { get; set; }
        public virtual DbSet<Accommodation> Accommodations { get; set; }
        public virtual DbSet<AccommodationAirport> AccommodationAirports { get; set; }
        public virtual DbSet<AccommodationAttribute> AccommodationAttributes { get; set; }
        public virtual DbSet<AccommodationCommission1> AccommodationCommission1 { get; set; }
        public virtual DbSet<AccommodationDescription> AccommodationDescriptions { get; set; }
        public virtual DbSet<AccommodationItour> AccommodationItours { get; set; }
        public virtual DbSet<AccommodationItoursSupplier> AccommodationItoursSuppliers { get; set; }
        public virtual DbSet<AccommodationReview> AccommodationReviews { get; set; }
        public virtual DbSet<AccomodationImage> AccomodationImages { get; set; }
        public virtual DbSet<AccomodationRoomImage> AccomodationRoomImages { get; set; }
        public virtual DbSet<AccomodationSupplier> AccomodationSuppliers { get; set; }
        public virtual DbSet<AccomodationVoucher> AccomodationVouchers { get; set; }
        public virtual DbSet<AccomodatonContract> AccomodatonContracts { get; set; }
        public virtual DbSet<AccomodatonContractPassenger> AccomodatonContractPassengers { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AdvertisingInformation> AdvertisingInformations { get; set; }
        public virtual DbSet<Aircraft> Aircrafts { get; set; }
        public virtual DbSet<Airline> Airlines { get; set; }
        public virtual DbSet<AirlineSupplierConfig> AirlineSupplierConfigs { get; set; }
        public virtual DbSet<AirlineSupplierWhitelist> AirlineSupplierWhitelists { get; set; }
        public virtual DbSet<AirLineUnMap> AirLineUnMaps { get; set; }
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<AirportSupplier> AirportSuppliers { get; set; }
        public virtual DbSet<AirportSupplierConfig1> AirportSupplierConfig1 { get; set; }
        public virtual DbSet<AirPortUnMap> AirPortUnMaps { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<ArrivalDetail> ArrivalDetails { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BookingAirport> BookingAirports { get; set; }
        public virtual DbSet<CarFee> CarFees { get; set; }
        public virtual DbSet<CarSpecialEquipsAmount> CarSpecialEquipsAmounts { get; set; }
        public virtual DbSet<CarTax> CarTaxes { get; set; }
        public virtual DbSet<CarTotalFare> CarTotalFares { get; set; }
        public virtual DbSet<CarTrawelerSizeCode> CarTrawelerSizeCodes { get; set; }
        public virtual DbSet<Company1> Company1 { get; set; }
        public virtual DbSet<CompanyName> CompanyNames { get; set; }
        public virtual DbSet<CompanySupplierAccess> CompanySupplierAccesses { get; set; }
        public virtual DbSet<CompanyWhiteLabelConfig> CompanyWhiteLabelConfigs { get; set; }
        public virtual DbSet<Contacts1> Contacts1 { get; set; }
        public virtual DbSet<ContactU> ContactUs { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<ContractRefund> ContractRefunds { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CountryNationality> CountryNationalities { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<DevelopmentRequest> DevelopmentRequests { get; set; }
        public virtual DbSet<DevelopmentRequestDetail> DevelopmentRequestDetails { get; set; }
        public virtual DbSet<DevelopmentRequestFile> DevelopmentRequestFiles { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<EmailMarketing> EmailMarketings { get; set; }
        public virtual DbSet<Exchange> Exchanges { get; set; }
        public virtual DbSet<ExchangeDetail> ExchangeDetails { get; set; }
        public virtual DbSet<Facility> Facilities { get; set; }
        public virtual DbSet<FlightContract> FlightContracts { get; set; }
        public virtual DbSet<FlightContractPassenger> FlightContractPassengers { get; set; }
        public virtual DbSet<FlightDiscount> FlightDiscounts { get; set; }
        public virtual DbSet<FlightEticket> FlightEtickets { get; set; }
        public virtual DbSet<FlightIndex> FlightIndexes { get; set; }
        public virtual DbSet<FlightTicket> FlightTickets { get; set; }
        public virtual DbSet<FlightTicketArrival> FlightTicketArrivals { get; set; }
        public virtual DbSet<FlightTicketDeparture> FlightTicketDepartures { get; set; }
        public virtual DbSet<FlightTicketFareBreakdown> FlightTicketFareBreakdowns { get; set; }
        public virtual DbSet<FlightTicketInformation> FlightTicketInformations { get; set; }
        public virtual DbSet<FlightTicketNotArrival> FlightTicketNotArrivals { get; set; }
        public virtual DbSet<FlightTicketNotDeparture> FlightTicketNotDepartures { get; set; }
        public virtual DbSet<FlightTicketTaxesFareBreakdown> FlightTicketTaxesFareBreakdowns { get; set; }
        public virtual DbSet<Help> Helps { get; set; }
        public virtual DbSet<HotelIndex> HotelIndexes { get; set; }
        public virtual DbSet<Inbox1> Inbox1 { get; set; }
        public virtual DbSet<InsuranceContract> InsuranceContracts { get; set; }
        public virtual DbSet<InsuranceLocation> InsuranceLocations { get; set; }
        public virtual DbSet<InsuranceTicket> InsuranceTickets { get; set; }
        public virtual DbSet<Interest> Interests { get; set; }
        public virtual DbSet<IP> IPs { get; set; }
        public virtual DbSet<IssuanceData> IssuanceDatas { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Localize> Localizes { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationCnv> LocationCnvs { get; set; }
        public virtual DbSet<LocationHotelsBed> LocationHotelsBeds { get; set; }
        public virtual DbSet<LocationInfo> LocationInfoes { get; set; }
        public virtual DbSet<LocationMistakeName> LocationMistakeNames { get; set; }
        public virtual DbSet<LocationSupplier> LocationSuppliers { get; set; }
        public virtual DbSet<LocationType> LocationTypes { get; set; }
        public virtual DbSet<LoginLog> LoginLogs { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessagesMapped> MessagesMappeds { get; set; }
        public virtual DbSet<MistakeName> MistakeNames { get; set; }
        public virtual DbSet<Newsletter> Newsletters { get; set; }
        public virtual DbSet<PackagesIndex> PackagesIndexes { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentCard> PaymentCards { get; set; }
        public virtual DbSet<PaymentList> PaymentLists { get; set; }
        public virtual DbSet<PaymentTicket> PaymentTickets { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonNameList> PersonNameLists { get; set; }
        public virtual DbSet<Pickup> Pickups { get; set; }
        public virtual DbSet<PNR> PNRs { get; set; }
        public virtual DbSet<PNR_RPH> PNR_RPH { get; set; }
        public virtual DbSet<Privilege> Privileges { get; set; }
        public virtual DbSet<ProductExtension> ProductExtensions { get; set; }
        public virtual DbSet<Question_status> Question_status { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<RailwayContract> RailwayContracts { get; set; }
        public virtual DbSet<RailwayStation1> RailwayStation1 { get; set; }
        public virtual DbSet<RatePlan> RatePlans { get; set; }
        public virtual DbSet<RatePlanSupplier> RatePlanSuppliers { get; set; }
        public virtual DbSet<RequestLog> RequestLogs { get; set; }
        public virtual DbSet<RequestUser> RequestUsers { get; set; }
        public virtual DbSet<ReserveRefound> ReserveRefounds { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolePrivilege> RolePrivileges { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceContract> ServiceContracts { get; set; }
        public virtual DbSet<SessionItemX> SessionItemXes { get; set; }
        public virtual DbSet<SessionTimeItemX> SessionTimeItemXes { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<SpecialEquipPref> SpecialEquipPrefs { get; set; }
        public virtual DbSet<Suggestion> Suggestions { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Telephone> Telephones { get; set; }
        public virtual DbSet<TelephoneU> TelephoneUs { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Ticketing> Ticketings { get; set; }
        public virtual DbSet<TicketStatu> TicketStatus { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<Tpsa> Tpsas { get; set; }
        public virtual DbSet<TransferAddress> TransferAddresses { get; set; }
        public virtual DbSet<TransferContract> TransferContracts { get; set; }
        public virtual DbSet<TransferTelephone> TransferTelephones { get; set; }
        public virtual DbSet<Tutorial> Tutorials { get; set; }
        public virtual DbSet<UnMapped> UnMappeds { get; set; }
        public virtual DbSet<User1> User1 { get; set; }
        public virtual DbSet<UserLog> UserLogs { get; set; }
        public virtual DbSet<UserPictureDic> UserPictureDics { get; set; }
        public virtual DbSet<VoucherRoom> VoucherRooms { get; set; }
        public virtual DbSet<Wallet> Wallets { get; set; }
        public virtual DbSet<WeatherForcast> WeatherForcasts { get; set; }
        public virtual DbSet<WeatherLocationSearch> WeatherLocationSearches { get; set; }
        public virtual DbSet<WebSite> WebSites { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
        public virtual DbSet<Accommodation_970527> Accommodation_970527 { get; set; }
        public virtual DbSet<AccommodationAirport_970527> AccommodationAirport_970527 { get; set; }
        public virtual DbSet<AccommodationLocation_970527> AccommodationLocation_970527 { get; set; }
        public virtual DbSet<AccommodationLocation960612> AccommodationLocation960612 { get; set; }
        public virtual DbSet<AccommodationMap3> AccommodationMap3 { get; set; }
        public virtual DbSet<AccomodationSupplier_970527> AccomodationSupplier_970527 { get; set; }
        public virtual DbSet<AccomodationSupplier960616> AccomodationSupplier960616 { get; set; }
        public virtual DbSet<AirportSupplier961110> AirportSupplier961110 { get; set; }
        public virtual DbSet<AirportSupplierConfig> AirportSupplierConfigs { get; set; }
        public virtual DbSet<AirportSupplierConfig_970317> AirportSupplierConfig_970317 { get; set; }
        public virtual DbSet<BookingHotelTemp> BookingHotelTemps { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ExchangeDetails_970317> ExchangeDetails_970317 { get; set; }
        public virtual DbSet<Inbox> Inboxes { get; set; }
        public virtual DbSet<Inbox2> Inbox2 { get; set; }
        public virtual DbSet<Location_970527> Location_970527 { get; set; }
        public virtual DbSet<Location960627> Location960627 { get; set; }
        public virtual DbSet<LocationMistakeName_970516> LocationMistakeName_970516 { get; set; }
        public virtual DbSet<Pages_970424> Pages_970424 { get; set; }
        public virtual DbSet<Privilege_970414> Privilege_970414 { get; set; }
        public virtual DbSet<RailwayStation_970306> RailwayStation_970306 { get; set; }
        public virtual DbSet<RailwayStation_970309> RailwayStation_970309 { get; set; }
        public virtual DbSet<Role_970414> Role_970414 { get; set; }
        public virtual DbSet<RolePrivilege_970414> RolePrivilege_970414 { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<AirportSupplierConfig961220> AirportSupplierConfig961220 { get; set; }
        public virtual DbSet<AirportSupplierConfig970121> AirportSupplierConfig970121 { get; set; }
        public virtual DbSet<Location961114> Location961114 { get; set; }
        public virtual DbSet<LocationMistakeName_970528> LocationMistakeName_970528 { get; set; }
        public virtual DbSet<LocationMistakeName961114> LocationMistakeName961114 { get; set; }
        public virtual DbSet<Pages_970513> Pages_970513 { get; set; }
        public virtual DbSet<Privilege_970421> Privilege_970421 { get; set; }
        public virtual DbSet<Privilege_970508> Privilege_970508 { get; set; }
        public virtual DbSet<RolePrivilege_970421> RolePrivilege_970421 { get; set; }
        public virtual DbSet<ServiceLocation> ServiceLocations { get; set; }
        public virtual DbSet<TimeZone> TimeZones { get; set; }
        public virtual DbSet<UserRole961221> UserRole961221 { get; set; }
    }
}
