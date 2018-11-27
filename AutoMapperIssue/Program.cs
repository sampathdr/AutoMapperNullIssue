using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutoMapperIssue.Data;
using AutoMapperIssue.Data.Profiles;
using AutoMapperIssue.Models;
using AutoMapperIssue.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoMapperIssue
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Mapper.Initialize(cfg =>
      {
        cfg.AllowNullCollections = true;
        cfg.AllowNullDestinationValues = true;
        cfg.AddProfile(new CustomProfile());
      });

      //var configuration = new MapperConfiguration(cfg =>
      //{
      //  cfg.AllowNullCollections = true;
      //  cfg.AllowNullDestinationValues = true;
      //  cfg.AddProfile(new CustomProfile());
      //});
      //var executionPlan = configuration.BuildExecutionPlan(typeof(User), typeof(UserViewModel));

      //EfContext context = new EfContext();

      //var exp = context.Users.ProjectTo<UserViewModel>().Expression;

      //var Users = context.Users.ProjectTo<UserViewModel>().ToList();


      using (EfContext context2 = new EfContext())
      {
        var Users2 = context2.Users.Select(dtoUser =>
          new UserViewModel()
          {
            Region = ((dtoUser == null
                        || dtoUser.RegAddress == null
                        || dtoUser.RegAddress.Country == null
                        || dtoUser.RegAddress.Country.Region == null) ? null
                        : dtoUser.RegAddress.Country.Region) == null ? null :
            new RegionViewModel()
            {
              Id = ((dtoUser == null 
                      || dtoUser.RegAddress == null 
                      || dtoUser.RegAddress.Country == null 
                      || dtoUser.RegAddress.Country.Region == null) ? null : 
                      dtoUser.RegAddress.Country.Region).Id
            }
          }
          ).ToList();
      }
    }
  }
}
