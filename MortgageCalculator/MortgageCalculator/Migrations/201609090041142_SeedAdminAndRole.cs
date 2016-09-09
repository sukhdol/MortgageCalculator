namespace MortgageCalculator.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedAdminAndRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'84157c54-c701-43cf-a0d7-5319aabc80c1', N'admin@linus7.com', 0, N'ACrv/w8VccUn/OUsuEWrtPA3HGQB0cYTjobqZz3J/5KhTtICDZUFXYGKGdeuqxlGXQ==', N'0e32a538-d249-4d62-a7d1-5ab77aa6f34f', NULL, 0, 0, NULL, 1, 0, N'admin@linus7.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'33b577bd-6dba-4115-91d2-36876e292db1', N'CanManageLoans')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'84157c54-c701-43cf-a0d7-5319aabc80c1', N'33b577bd-6dba-4115-91d2-36876e292db1')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
