using AutoMapper;
using AutoMapperIssue.Models;
using AutoMapperIssue.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperIssue.Data.Profiles
{
  public class CustomProfile : Profile
  {
    public CustomProfile()
    {
      CreateMap<LkupRegion, RegionViewModel>(MemberList.None)
        .ForMember(m => m.Id, opt => opt.MapFrom(p => p.Id))
        .ForMember(m => m.Name, opt => opt.Ignore());// MapFrom(p => p != null ? p.Name: string.Empty));

      CreateMap<LkupNationality, NationalityViewModel>(MemberList.None)
      .ForMember(m => m.Name, opt => opt.MapFrom(p => p.Name))
      .ForMember(m => m.Region, opt => opt.MapFrom(p => p.Region != null ? p.Region.Name : string.Empty));

      CreateMap<Address, AddressViewModel>(MemberList.None)
        .ForMember(m => m.Country, opt => opt.MapFrom(p => p.Country));

      CreateMap<Country, CountryViewModel>(MemberList.None)
      .ForMember(m => m.Name, opt => opt.MapFrom(p => p.Name))
      .ForMember(m => m.Region, opt => opt.MapFrom(p => p.Region));

      CreateMap<User, UserViewModel>(MemberList.None)
        .ForMember(m => m.Region, opt => opt.MapFrom(p =>
          (p == null || p.RegAddress == null || p.RegAddress.Country == null || p.RegAddress.Country.Region == null) ? default(LkupRegion) : p.RegAddress.Country.Region));

      //CreateMap<User, UserViewModel>(MemberList.None)
      //  .ForMember(m => m.Region, opt => opt.MapFrom(p =>
      //    (p != null && p.RegAddress != null && p.RegAddress.Country != null) ? p.RegAddress.Country.Region :
      //    ((p != null && p.Nationality != null && p.Nationality.Region != null) ? p.Nationality.Region : default(LkupRegion))));

      //.ForMember(m => m.Region, opt => opt.MapFrom(p => p.RegAddressId.HasValue && p.RegAddress.CountryId.HasValue? p.RegAddress.Country.Region : (p.Nationality != null && p.Nationality.RegionId.HasValue ? p.Nationality.Region : default(LkupRegion))));

      //Note: This mapping is working without any issue...
      //CreateMap<User, UserViewModel>(MemberList.None)
      //  .ForMember(m => m.Region, opt => opt.MapFrom(p => p.Nationality.Region));
    }
  }
}
