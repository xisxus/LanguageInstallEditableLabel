using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LanguageInstall.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LanguageLists",
                columns: new[] { "ID", "LanguageCode", "LanguageName" },
                values: new object[,]
                {
                    { 1, "en", "English" },
                    { 2, "es", "Spanish" },
                    { 3, "fr", "French" },
                    { 4, "de", "German" },
                    { 5, "zh", "Chinese" },
                    { 6, "ja", "Japanese" },
                    { 7, "ko", "Korean" },
                    { 8, "ar", "Arabic" },
                    { 9, "hi", "Hindi" },
                    { 10, "ru", "Russian" },
                    { 11, "pt", "Portuguese" },
                    { 12, "it", "Italian" },
                    { 13, "nl", "Dutch" },
                    { 14, "sv", "Swedish" },
                    { 15, "no", "Norwegian" },
                    { 16, "da", "Danish" },
                    { 17, "fi", "Finnish" },
                    { 18, "pl", "Polish" },
                    { 19, "tr", "Turkish" },
                    { 20, "th", "Thai" },
                    { 21, "vi", "Vietnamese" },
                    { 22, "ms", "Malay" },
                    { 23, "id", "Indonesian" },
                    { 24, "el", "Greek" },
                    { 25, "he", "Hebrew" },
                    { 26, "ur", "Urdu" },
                    { 27, "bn", "Bengali" },
                    { 28, "ta", "Tamil" },
                    { 29, "te", "Telugu" },
                    { 30, "fa", "Persian" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LanguageLists",
                keyColumn: "ID",
                keyValue: 30);
        }
    }
}
