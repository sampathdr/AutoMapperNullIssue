using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutoMapperIssue.Data;
using AutoMapperIssue.Data.Profiles;
using AutoMapperIssue.ViewModel;
using System;
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
        cfg.AddProfile(new CustomProfile());
      });

      EfContext context = new EfContext();
      var Users = context.Users.ProjectTo<UserViewModel>().ToList();
    }
  }
}
