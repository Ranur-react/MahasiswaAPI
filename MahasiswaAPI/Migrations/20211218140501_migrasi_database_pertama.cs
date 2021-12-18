using Microsoft.EntityFrameworkCore.Migrations;

namespace MahasiswaAPI.Migrations
{
    public partial class migrasi_database_pertama : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_M_Mahasiswa",
                columns: table => new
                {
                    Nobp = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nohp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JenisKelamin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_M_Mahasiswa", x => x.Nobp);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_M_Mahasiswa");
        }
    }
}
