namespace Online_Entrance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seeddata : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [FullName], [SchoolName], [SeeSymbolNumber], [Gpa], [Dob], [ContactNumber], [Address], [GuardianName], [GuardianContact], [Faculty], [RegisteredDate], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1512ce2b-2b9e-49d0-be47-6dcd57e4ded9', N'Aayush Sapkota', N'Sunrise', N'123456', N'4', N'1998-11-05', N'9825476583', N'Gaindakot', N'Tulasi Prasad Sapkota', N'9855082941', N'ComputerScience', N'2023-12-18 11:03:30', N'aayush@online.com', 0, N'AN+hL3cM4a+DlRLT91x6suLp79HymGFREKzi5daclo/+MQm9XRTkRIm0XVryVCo7BQ==', N'6d6a4afb-5131-4c69-931a-4c7e71475610', NULL, 0, 0, NULL, 1, 0, N'aayush@online.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [FullName], [SchoolName], [SeeSymbolNumber], [Gpa], [Dob], [ContactNumber], [Address], [GuardianName], [GuardianContact], [Faculty], [RegisteredDate], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'191e3e60-8321-43c7-9577-0db03c3b5cec', N'Admin', N'admin', N'admin', N'admin', N'2020-10-20', N'admin', N'admin', N'admin', N'admin', N'ComputerScience', N'2023-12-18 11:23:48', N'admin@online.com', 0, N'ACX+6yiFBnx7Wq1DHjyvtj+ioAm/zJq0XqCELdQZrma+WCaaLscdAGDIF3ak3GE0yA==', N'6e7e929d-2cc2-4a58-851e-9e7a176e30d6', NULL, 0, 0, NULL, 1, 0, N'admin@online.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f9e3802b-6a3e-44b3-af1e-dc4b53c8fd04', N'CanManageQuestions')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'191e3e60-8321-43c7-9577-0db03c3b5cec', N'f9e3802b-6a3e-44b3-af1e-dc4b53c8fd04')

");
        }
        
        public override void Down()
        {
        }
    }
}
