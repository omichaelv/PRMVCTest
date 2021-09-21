using Microsoft.EntityFrameworkCore.Migrations;

namespace PRMVCTest.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into AspNetRoles (Id,Name,NormalizedName,ConcurrencyStamp) Values (1,'Admin','ADMIN','e78c1e62-9bc1-46f1-8158-a8e54d6a8c98')");
            migrationBuilder.Sql("Insert into AspNetRoles (Id,Name,NormalizedName,ConcurrencyStamp) Values (2,'User','USER','e78c1e62-9bc1-46f1-8168-a8e54d6a8c98')");
            migrationBuilder.Sql("Insert into AspNetUsers (Id,UserName,NormalizedUserName,Email,NormalizedEmail,PasswordHash,SecurityStamp,ConcurrencyStamp,AccessFailedCount,EmailConfirmed,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled) Values (1,'mxplay','MXPLAY','mxplay@hotmail.com','MXPLAY@HOTMAIL.COM','AQAAAAEAACcQAAAAEIx4YwvzOwY685oNcx/a2c8mA0bqGyqXeJr6UQd6M1h/LsHhHK8b/LZ0CRD2LkHmgQ==','FB66KYDKS2ECSJY2D2DOEBXK3LRUOD4O','9af5c56d-9a9b-4ad1-9c74-467bf9923545',0,0,0,0,0,0)");

            migrationBuilder.Sql("Insert into AspNetUserRoles (UserId,RoleId) Values (1,1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
