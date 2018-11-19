USE [AutoMapperIssueDB]
GO
SET IDENTITY_INSERT [dbo].[LkupRegions] ON 
GO
INSERT [dbo].[LkupRegions] ([Id], [Name], [DeletedDate], [EmailRecipients]) VALUES (1, N'Asia', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[LkupRegions] OFF
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([Id], [Name], [DeletedDate], [RegionId], [Code], [SortOrder]) VALUES (2, N'SriLanka', NULL, 1, N'SL', 0)
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[LkupNationalities] ON 
GO
INSERT [dbo].[LkupNationalities] ([Id], [Name], [DeletedDate], [RegionId], [Language], [SortOrder]) VALUES (2, N'SriLankan', NULL, 1, NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[LkupNationalities] OFF
GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 
GO
INSERT [dbo].[Addresses] ([Street], [City], [State], [CountryId], [ZipCode], [Id]) VALUES (N'Street 01', N'City 01', N'State 01', 2, N'20100', 1)
GO
INSERT [dbo].[Addresses] ([Street], [City], [State], [CountryId], [ZipCode], [Id]) VALUES (N'Street 02', N'City 02', N'State 02', 2, N'30100', 2)
GO
SET IDENTITY_INSERT [dbo].[Addresses] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([Id], [Email], [FirstName], [LastName], [NationalityId], [RegAddressId], [MailAddressId]) VALUES (1, N'user@email.com', N'fName', N'lName', 2, 1, 2)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
