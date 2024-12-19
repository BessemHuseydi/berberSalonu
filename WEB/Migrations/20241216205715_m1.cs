using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Service",
                table: "Randevular");

            migrationBuilder.AddColumn<int>(
                name: "HizmetId",
                table: "Randevular",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 1,
                column: "HizmetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 2,
                column: "HizmetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 3,
                column: "HizmetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 4,
                column: "HizmetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 5,
                column: "HizmetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 6,
                column: "HizmetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 7,
                column: "HizmetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 8,
                column: "HizmetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 9,
                column: "HizmetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 10,
                column: "HizmetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGcgQePWG1oKhIRxPC+0MgW2HMgvcAg2XkB8uGRiC8rJE/zgKTUupNJZLJ/QNx9rqw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEgaCd6rRR5cfZJznVnsw/hcOjSVmf8pcpZZA3mOJn5ei32JW+W1ipLISlZjhX0onA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFeD8b+0LAx/KG2gwRIj56ra2dDrPq5ZTjHeAeF4jOdbpu94DvBnVoHcdhulqtxRrg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKgWzhvb7y8Z7mFZzDMd497aSr8LZq4L76BAaC6Io5295O2M0zy8TbVauiMI/hvGWA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEF5fU+NkLU51g9s4kpR71nLjMIbf23a6sBXGuLQ0H62CYruX1LNRA97fgopYPbNr/w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGq/+qGBIRZcm2x+1wSf8AAh4I1D2x34KEf6NVqDohcLiVTlFW7KUvXI7HY0x680VA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJbAmY5sn5VwiDjmnbjqh24S6H8coERSWHSqbCn2Fq47Ho6nufkm0JLXHjMVCXHfiA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAfuqZIrNk5vs8lut4C5o7Y3vDXfcx0PaxsNjd29gsXQkaZ9L9w6Ha9hSzRiIUKmuw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGib6z6Kogb3W/HDdb3lSbFogtmxjcr/NigxT3pRLaBsue/N2eRgecNf2XRMnzGOKg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAeWKjxCCPq2wX9Xc6sAbGLIP2+Y+RIexk4yFOc8xylJ688i2Utf6QuiLfUmcLY1Kw==");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_HizmetId",
                table: "Randevular",
                column: "HizmetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevular_Hizmetler_HizmetId",
                table: "Randevular",
                column: "HizmetId",
                principalTable: "Hizmetler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevular_Hizmetler_HizmetId",
                table: "Randevular");

            migrationBuilder.DropIndex(
                name: "IX_Randevular_HizmetId",
                table: "Randevular");

            migrationBuilder.DropColumn(
                name: "HizmetId",
                table: "Randevular");

            migrationBuilder.AddColumn<string>(
                name: "Service",
                table: "Randevular",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 1,
                column: "Service",
                value: "Saç Kesimi");

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 2,
                column: "Service",
                value: "Manikür");

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 3,
                column: "Service",
                value: "Pedikür");

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 4,
                column: "Service",
                value: "Cilt Bakımı");

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 5,
                column: "Service",
                value: "Saç Boyama");

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 6,
                column: "Service",
                value: "Sakal Kesimi");

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 7,
                column: "Service",
                value: "Masaj");

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 8,
                column: "Service",
                value: "Yüz Temizleme");

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 9,
                column: "Service",
                value: "Saç Kesimi");

            migrationBuilder.UpdateData(
                table: "Randevular",
                keyColumn: "Id",
                keyValue: 10,
                column: "Service",
                value: "Manikür");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJodGf5Kkttd8dfw3bmNPQT5xb1TRchUrf1UCyfK+2usxD5PxiZ3gTwDiLEh021dHg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEN7PFUqRrtFwoG4GQjRvjmfvulDgDMzyXOwjXXIoZEgYu9UoArPldvsuRvxBTLM9Pw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGMf2oRO5mWuDUrDW3KX2petP9Bnkt2Oeqnf0OWaAygKvTnWirOkPVNWLD05j3yV2Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELUrIItCV3mzOjw9suxrGlniTTjvjwQ9OsYzWvBjB/6Rhdy6YtoRfrC7XYRaeFdRmw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMMRyA+AMBxJvfb9B4lQhUdq8E675xj7dqQ1bOppuU8it+5tFScBppdKf4eyV6BjyQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEItGbVldXz4GQjmKA5aQlscHJlngXeWW7GoKBHijB57t2/fY9UsVpRTepZWNJNyCew==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEL8gB76+wNd5/qtzDuo5WUsRIiX/85idT+4+Vxq/W4LW8SYMcL2HYZ8xddJbhX/xCQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOyFKGBTMoOWHgG+E3iePDmCwg+AyOuZ9YLwof3OGBXkajvSOiynWeMuPJF1aLwVNg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDmT9f5zn90HoXsUBXvZAQzZwImB28OJexjyKSGwH5xBSTXuPBD0oJhGwfyu0OQ0xA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEF/AM7wJ8VQSriQ02xuXNrVj59RWXAOvwkkys8sWJx5BGyPFbs7NSOCPhx1SjQ2jUw==");
        }
    }
}
