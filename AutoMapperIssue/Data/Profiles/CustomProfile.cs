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
        .ForMember(m => m.Name, opt => opt.MapFrom(p => p.Name));

      CreateMap<LkupNationality, NationalityViewModel>(MemberList.None)
      .ForMember(m => m.Name, opt => opt.MapFrom(p => p.Name))
      .ForMember(m => m.Region, opt => opt.MapFrom(p => p.Region.Name));

      CreateMap<Address, AddressViewModel>(MemberList.None)
        .ForMember(m => m.Country, opt => opt.MapFrom(p => p.Country));

      CreateMap<User, UserViewModel>(MemberList.None)
        .ForMember(m => m.Region, opt => opt.MapFrom(p => p.RegAddressId.HasValue ? p.RegAddress.Country.Region : p.Nationality.Region));

      //Note: This mapping is working without any issue...
      //CreateMap<User, UserViewModel>(MemberList.None)
      //  .ForMember(m => m.Region, opt => opt.MapFrom(p => p.Nationality.Region));
    }
  }
}
