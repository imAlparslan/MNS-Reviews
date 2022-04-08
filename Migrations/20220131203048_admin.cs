using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

#nullable disable

namespace MNS_Reviews.Migrations
{
    public partial class admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SET IDENTITY_INSERT[users] ON");
            sb.AppendLine("INSERT INTO users(Id, Name, Email, Password, UserType,IsActive,imgUrl, CreatedDate)");
            sb.AppendLine("VALUES(");
            sb.AppendLine("0");
            sb.AppendLine(",'Admin Account'");
            sb.AppendLine(",'a1@hotmail.com'");
            sb.AppendLine(",'a1'");
            sb.AppendLine(",'Admin'");
            sb.AppendLine(",'1'");
            sb.AppendLine(",'~/images/admin-pp.png'");
            sb.AppendLine($",'2022-01-26 14:41:49.6633936'");
            sb.AppendLine(")");
            sb.AppendLine("SET IDENTITY_INSERT[users] OFF");

            migrationBuilder.Sql(sb.ToString());


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
