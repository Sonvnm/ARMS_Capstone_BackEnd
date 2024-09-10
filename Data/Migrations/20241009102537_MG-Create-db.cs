using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGCreatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campus",
                columns: table => new
                {
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CampusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingMotto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Achievements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhyChooseUs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campus", x => x.CampusId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    AvatarURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isAccountActive = table.Column<bool>(type: "bit", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogCategory",
                columns: table => new
                {
                    BlogCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategory", x => x.BlogCategoryId);
                    table.ForeignKey(
                        name: "FK_BlogCategory_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Major",
                columns: table => new
                {
                    MajorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MajorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MajorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    TimeStudy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isVocationalSchool = table.Column<bool>(type: "bit", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major", x => x.MajorID);
                    table.ForeignKey(
                        name: "FK_Major_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Slider",
                columns: table => new
                {
                    SliderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider", x => x.SliderId);
                    table.ForeignKey(
                        name: "FK_Slider_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Account_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.UserId, x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_Blog_BlogCategory_BlogCategoryId",
                        column: x => x.BlogCategoryId,
                        principalTable: "BlogCategory",
                        principalColumn: "BlogCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentConsultation",
                columns: table => new
                {
                    StudentConsultationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkFB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateReceive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MajorID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentConsultation", x => x.StudentConsultationId);
                    table.ForeignKey(
                        name: "FK_StudentConsultation_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                    table.ForeignKey(
                        name: "FK_StudentConsultation_Major_MajorID",
                        column: x => x.MajorID,
                        principalTable: "Major",
                        principalColumn: "MajorID");
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MajorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfCredits = table.Column<int>(type: "int", nullable: false),
                    SemesterNumber = table.Column<int>(type: "int", nullable: false),
                    StudyTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => new { x.SubjectCode, x.MajorID });
                    table.ForeignKey(
                        name: "FK_Subject_Major_MajorID",
                        column: x => x.MajorID,
                        principalTable: "Major",
                        principalColumn: "MajorID");
                });

            migrationBuilder.InsertData(
                table: "Campus",
                columns: new[] { "CampusId", "Achievements", "Address", "CampusName", "History", "PhoneNumber", "TrainingMotto", "WhyChooseUs" },
                values: new object[,]
                {
                    { "Cantho", "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Toà nhà FPT Polytechnic, đường số 22, phường Thường Thạnh,quận Cái Răng, TP Cần Thơ", "Cần Thơ", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "0983881100", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." },
                    { "Danang", "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "219 Nguyễn Sinh Sắc, phường Hoà Minh, quận Liên Chiểu, TP Đà Nẵng", "Đà Nẵng", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "02363710999", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." },
                    { "Hanoi", "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Cổng số 1, Tòa nhà FPT Polytechnic, 13 phố Trịnh Văn Bô, phường Phương Canh, quận Nam Từ Liêm, TP Hà NộiKm12 Cầu Diễn, Phường Phúc Diễn, Quận Bắc Từ Liêm, Hà Nội", "Hà Nội", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "02485820808", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." },
                    { "HCM", "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Tòa nhà QTSC9 (toà T), đường Tô Ký, phường Tân Chánh Hiệp, quận 12, TP HCM.778/B1 Nguyễn Kiệm, phường 04, quận Phú Nhuận, TP HCM", "Tp HCM", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "02866866486", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." },
                    { "Thanhhoa", "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Tòa Beta, Tổ hợp giáo dục FPT, Đại lộ Võ Nguyên Giáp, phường Quảng Thành, TP Thanh Hóa", "Thanh Hoá", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "0913785213", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), "d92e12bd-9f1f-48b3-bb61-f7f45edf30df", "Admin", "ADMIN" },
                    { new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"), "a9a7b239-005a-4b5b-9862-2819f4c3db7b", "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "AccessFailedCount", "AvatarURL", "CampusId", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "Fullname", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isAccountActive" },
                values: new object[] { new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), 0, null, "Hanoi", "c78ba1cd-9e53-43e8-aba5-66686a6ac1cc", null, "AdminHaNoi@gmail.com", true, "Admin Hanoi", null, false, null, "ADMINHANOI@GMAIL.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAELka5EX1xJvLQJX7cZ7IIeFzmtWnL/qdqsotXa4z9+EU0GjTQBSoMUAFg9ONjgkMgw==", null, null, false, "6612a027-ce7f-4095-a768-4467c9d39702", false, "Administrator", false });

            migrationBuilder.InsertData(
                table: "BlogCategory",
                columns: new[] { "BlogCategoryId", "BlogCategoryName", "CampusId" },
                values: new object[,]
                {
                    { 1, "Tuyển sinh", "Hanoi" },
                    { 2, "Hoạt động của sinh viên", "Hanoi" },
                    { 3, "Sự kiện", "Hanoi" },
                    { 4, "Tuyển sinh", "Danang" },
                    { 5, "Hoạt động của sinh viên", "Danang" },
                    { 6, "Sự kiện", "Danang" },
                    { 7, "Tuyển sinh", "Cantho" },
                    { 8, "Hoạt động của sinh viên", "Cantho" },
                    { 9, "Sự kiện", "Cantho" },
                    { 10, "Tuyển sinh", "HCM" },
                    { 11, "Hoạt động của sinh viên", "HCM" },
                    { 12, "Sự kiện", "HCM" },
                    { 13, "Tuyển sinh", "Thanhhoa" },
                    { 14, "Hoạt động của sinh viên", "Thanhhoa" },
                    { 15, "Sự kiện", "Thanhhoa" }
                });

            migrationBuilder.InsertData(
                table: "Major",
                columns: new[] { "MajorID", "CampusId", "Description", "MajorCode", "MajorName", "Status", "Target", "TimeStudy", "isVocationalSchool" },
                values: new object[,]
                {
                    { "HAO", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Kiểm toán", true, 200, "2 năm", false },
                    { "HBS", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Chăm sóc da và massage", true, 200, "2 năm", true },
                    { "HBT", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Phum xăm thẩm mỹ", true, 200, "2 năm", true },
                    { "HEA", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7220201", "Ngôn ngữ anh", true, 200, "2 năm", false },
                    { "HFO", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Kỹ thuật chế biến món ăn", true, 200, "2 năm", true },
                    { "HGE", "Hanoi", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Lập trình game", true, 200, "2 năm", false },
                    { "HHM", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7340101", "Quản trị khách sạn", true, 200, "24 năm", false },
                    { "HJA", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7220209", "Ngôn ngữ nhật", true, 200, "2 năm", false },
                    { "HKA", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7220210", "Ngôn ngữ hàn", true, 200, "24 năm", false },
                    { "HME", "Hanoi", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Lập trình mobile", true, 200, "2 năm", false },
                    { "HRM", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7340101", "Quản trị nhà hàng", true, 200, "24 năm", false },
                    { "HSM", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7340101", "Marketing", true, 200, "2 năm", false },
                    { "HSO", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Thư ký văn phòng", true, 200, "24 năm", false },
                    { "HTE", "Hanoi", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Kiểm thử", true, 200, "2 năm", false },
                    { "HWE", "Hanoi", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Lập trình web", true, 200, "2 năm", false },
                    { "SAO", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Kiểm toán", true, 200, "2 năm", false },
                    { "SBS", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Chăm sóc da và massage", true, 200, "2 năm", true },
                    { "SBT", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Phum xăm thẩm mỹ", true, 200, "2 năm", true },
                    { "SEA", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7220201", "Ngôn ngữ anh", true, 200, "2 năm", false },
                    { "SFO", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Kỹ thuật chế biến món ăn", true, 200, "2 năm", true },
                    { "SGE", "HCM", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Lập trình game", true, 200, "2 năm", false },
                    { "SHM", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7340101", "Quản trị khách sạn", true, 200, "24 năm", false },
                    { "SJA", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7220209", "Ngôn ngữ nhật", true, 200, "2 năm", false },
                    { "SKA", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7220210", "Ngôn ngữ hàn", true, 200, "24 năm", false },
                    { "SME", "HCM", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Lập trình mobile", true, 200, "2 năm", false },
                    { "SRM", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7340101", "Quản trị nhà hàng", true, 200, "24 năm", false }
                });

            migrationBuilder.InsertData(
                table: "Major",
                columns: new[] { "MajorID", "CampusId", "Description", "MajorCode", "MajorName", "Status", "Target", "TimeStudy", "isVocationalSchool" },
                values: new object[,]
                {
                    { "SSM", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7340101", "Marketing", true, 200, "2 năm", false },
                    { "SSO", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Thư ký văn phòng", true, 200, "24 năm", false },
                    { "STE", "HCM", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Kiểm thử", true, 200, "2 năm", false },
                    { "SWE", "HCM", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Lập trình web", true, 200, "2 năm", false }
                });

            migrationBuilder.InsertData(
                table: "Slider",
                columns: new[] { "SliderId", "CampusId", "Img" },
                values: new object[,]
                {
                    { 1, "Hanoi", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce" },
                    { 2, "Hanoi", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d" },
                    { 4, "Danang", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce" },
                    { 5, "Danang", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d" },
                    { 7, "HCM", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce" },
                    { 8, "HCM", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d" },
                    { 10, "Cantho", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce" },
                    { 11, "Cantho", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d" },
                    { 13, "Thanhhoa", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce" },
                    { 14, "Thanhhoa", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d" }
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogCategoryId", "Content", "DateCreate", "Description", "Title" },
                values: new object[,]
                {
                    { 1, 3, "Trăng tròn đã vươn cao tại Hoà Lạc, Rằm tháng Tám đã gần đi qua, các Cóc “ngoan xinh iu” của FPTU đã đi chơi Trung thu về chưa? \r\n🥮 Trung thu là dịp để chúng ta ngồi lại bên nhau, hàn huyên với gia đình, bạn bè và những người thân yêu. Hãy cùng tận hưởng Tết Trung Thu bên bánh dẻo, bánh nướng và thả mình vào ánh trăng lung linh để cảm nhận những khoảnh khắc tuyệt diệu, đáng quý này nhé!\r\n✨ Nhân dịp Tết Trung thu, xin gửi những lời chúc tốt đẹp nhất đến thầy cô, anh chị cán bộ trường Đại học FPT, cùng các bạn sinh viên thân yêu! Chúc mọi người một mùa trăng an yên hơn sau những ảnh hưởng lớn của bão vừa qua.\r\n 📌 VÀ ĐỪNG QUÊN lên dây cót, bật chế độ sẵn sàng đón chờ những sự kiện “cực kỳ hoành tráng” đang tới gần. Kết nối, khám phá và trải nghiệm hết mình trong kỳ fall này bạn nhé!", new DateTime(2024, 10, 9, 17, 25, 36, 987, DateTimeKind.Local).AddTicks(808), "Trăng tròn đã vươn cao tại Hoà Lạc, Rằm tháng Tám đã gần đi qua, các Cóc “ngoan xinh iu” của FPTU đã đi chơi Trung thu về chưa?", "Trăng tròn đã vươn cao tại Hoà Lạc" },
                    { 2, 3, "[𝐊𝐈𝐂𝐊 𝐎𝐅𝐅] - 𝐉𝐈𝐌𝐁𝐎 𝐔𝐍𝐈𝐓𝐘 𝐅𝐄𝐒𝐓\r\n🏞 Tại vùng đất Hola Campus, nơi mà tinh thần học tập, sáng tạo nghệ thuật và sức mạnh thể chất được đề cao luôn tồn tại một lực lượng quân chủng mang tên 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 - mang trong mình trọng trách quan trọng nhất đó là bảo vệ và phát triển lãnh thổ với ba đại đội: Cơ bắp, Biết tuốt và Bay bổng. \r\n✨ Vào năm 2024, những người đứng đầu của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 đã quyết định tổ chức một sự kiện, một ngày hội đặc biệt mang tên 𝐽𝑖𝑚𝑏𝑜 𝑈𝑛𝑖𝑡𝑦 𝐹𝑒𝑠𝑡. Sự kiện là dịp để các chiến sĩ của cả 3 Đại đội gặp mặt, giao lưu và học hỏi lẫn nhau không chỉ về tinh thần đồng đội mà còn được khám phá thêm những kỹ năng từ các đội khác. \r\n🌷 Đặc biệt, 𝐽𝑖𝑚𝑏𝑜 𝑈𝑛𝑖𝑡𝑦 𝐹𝑒𝑠𝑡 không chỉ giới hạn cho các chiến sĩ của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 mà còn mở cửa chào đón tất cả những người trẻ của vùng đất Hola Campus có quan tâm và muốn trải nghiệm môi trường, văn hóa đặc trưng của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 tham gia sự kiện. Nếu như bạn đã sẵn sàng với các chiến binh bước vào thế giới của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 cùng một tinh thần nhiệt huyết và tràn đầy năng lượng để vượt qua những thử thách đầy cam go thì hãy cùng chúng mình đón chờ hành trình sắp tới nhé!\r\n---------------------------------------\r\n🔥 𝐉𝐈𝐌𝐁𝐎 𝐔𝐍𝐈𝐓𝐘 𝐅𝐄𝐒𝐓 🔥\r\n◻️ Thời gian: 13h - 17h30 thứ hai, ngày 30/09/2024\r\n◻️ Địa điểm: Đường 30m, Đại học FPT Hà Nội \r\n---------------------------------------\r\nTHÔNG TIN LIÊN HỆ\r\n◻️ Trưởng ban Tổ chức: Kiều Bảo Lộc (0367488155)\r\n◻️ Trưởng ban HR: Nguyễn Ngọc Quỳnh (0865349170)", new DateTime(2024, 10, 9, 17, 25, 36, 987, DateTimeKind.Local).AddTicks(817), " 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 - mang trong mình trọng trách quan trọng nhất đó là bảo vệ và phát triển lãnh thổ với ba đại đội: Cơ bắp, Biết tuốt và Bay bổng.", "[𝐊𝐈𝐂𝐊 𝐎𝐅𝐅] - 𝐉𝐈𝐌𝐁𝐎 𝐔𝐍𝐈𝐓𝐘 𝐅𝐄𝐒𝐓" },
                    { 3, 2, "🌟[ORIENTATION WEEK]🌟 GIỚI THIỆU CÁC PHÒNG BAN CHỨC NĂNG TẠI ĐẠI HỌC FPT\r\n🔥Ngay lúc này đây, Phòng Hợp tác Quốc tế và Phát triển Cá nhân ICPDP đang có mặt tại Hội trường NIC cùng các tân sinh viên K20 tham gia Buổi học định hướng với chủ đề “Giới thiệu các phòng ban tại Đại học FPT”.\r\n🔥Tại buổi định hướng, các Cóc út đã được lắng nghe anh Lê Huy Hoàng - Cán bộ quản lý IC, đại diện phòng ICPDP chia sẻ về vai trò và chức năng của Phòng ICPDP, về các cơ hội học tập, trải nghiệm trong và ngoài nước dành cho tất cả các bạn sinh viên FPT.\r\n🫶Phòng ICPDP rất sẵn lòng đồng hành cùng các Cóc trong hành trình 4 năm thanh xuân tại Đại học FPT. Hy vọng chúng mình sẽ có thật nhiều kỷ niệm tại Đại học FPT Hà Nội. \r\n-----------------------------------------------------------\r\nMọi thắc mắc vui lòng liên hệ: Phòng Hợp tác Quốc tế và Phát triển cá nhân ICPDP FPTU", new DateTime(2024, 10, 9, 17, 25, 36, 987, DateTimeKind.Local).AddTicks(819), " Giới thiệu các phòng ban tại Đại học FPT", "🌟[ORIENTATION WEEK]🌟 GIỚI THIỆU CÁC PHÒNG BAN CHỨC NĂNG TẠI ĐẠI HỌC FPT" },
                    { 4, 1, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", new DateTime(2024, 10, 9, 17, 25, 36, 987, DateTimeKind.Local).AddTicks(819), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 5, 1, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", new DateTime(2024, 10, 9, 17, 25, 36, 987, DateTimeKind.Local).AddTicks(820), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 6, 1, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", new DateTime(2024, 10, 9, 17, 25, 36, 987, DateTimeKind.Local).AddTicks(821), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 7, 1, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", new DateTime(2024, 10, 9, 17, 25, 36, 987, DateTimeKind.Local).AddTicks(822), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 8, 1, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", new DateTime(2024, 10, 9, 17, 25, 36, 987, DateTimeKind.Local).AddTicks(822), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 9, 1, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", new DateTime(2024, 10, 9, 17, 25, 36, 987, DateTimeKind.Local).AddTicks(823), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" }
                });

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("59278e64-880c-4ddc-9a56-585ffc1bde53"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 },
                    { new Guid("9db09a3a-7b8c-4523-b244-ec0fbe95a77c"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "MajorID", "SubjectCode", "Note", "NumberOfCredits", "SemesterNumber", "StudyTime", "SubjectName" },
                values: new object[,]
                {
                    { "HGE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "HME", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "HTE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "HWE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "SGE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "SME", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "STE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "SWE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "HAO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HBS", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HBT", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HEA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HFO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HGE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HHM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HJA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HKA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HME", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HRM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HSM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HSO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HTE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HWE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SAO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SBS", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SBT", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SEA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SFO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SGE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SHM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SJA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "MajorID", "SubjectCode", "Note", "NumberOfCredits", "SemesterNumber", "StudyTime", "SubjectName" },
                values: new object[,]
                {
                    { "SKA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SME", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SRM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SSM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SSO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "STE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SWE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HAO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HBS", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HBT", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HEA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HFO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HGE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HHM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HJA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HKA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HME", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HRM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HSM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HSO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HTE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HWE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SAO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SBS", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SBT", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SEA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SFO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SGE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SHM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SJA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SKA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SME", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SRM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SSM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SSO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "STE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SWE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HAO", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "HEA", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "HHM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "HME", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "HRM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "MajorID", "SubjectCode", "Note", "NumberOfCredits", "SemesterNumber", "StudyTime", "SubjectName" },
                values: new object[,]
                {
                    { "HSM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "SAO", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "SEA", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "SHM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "SME", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "SRM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "SSM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "HAO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HBS", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HBT", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HEA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HFO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HGE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HHM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HJA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HKA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HME", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HRM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HSM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HSO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HTE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HWE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SAO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SBS", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SBT", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SEA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SFO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SGE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SHM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SJA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SKA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SME", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SRM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SSM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SSO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "STE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SWE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HGE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "HME", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "HTE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "HWE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "SGE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "MajorID", "SubjectCode", "Note", "NumberOfCredits", "SemesterNumber", "StudyTime", "SubjectName" },
                values: new object[,]
                {
                    { "SME", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "STE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "SWE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "HGE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "HME", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "HTE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "HWE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "SGE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "SME", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "STE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "SWE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "HGE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "HME", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "HTE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "HWE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "SGE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "SME", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "STE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "SWE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7") });

            migrationBuilder.CreateIndex(
                name: "IX_Account_CampusId",
                table: "Account",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_BlogCategoryId",
                table: "Blog",
                column: "BlogCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategory_CampusId",
                table: "BlogCategory",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_Major_CampusId",
                table: "Major",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Slider_CampusId",
                table: "Slider",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentConsultation_CampusId",
                table: "StudentConsultation",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentConsultation_MajorID",
                table: "StudentConsultation",
                column: "MajorID");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_MajorID",
                table: "Subject",
                column: "MajorID");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Slider");

            migrationBuilder.DropTable(
                name: "StudentConsultation");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "BlogCategory");

            migrationBuilder.DropTable(
                name: "Major");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Campus");
        }
    }
}
