using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Web.Models;

namespace Web.Migrations
{
    [DbContext(typeof(GroltyFinancesWebContext))]
    partial class GroltyFinancesWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Web.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Web.Models.Currency", b =>
                {
                    b.Property<string>("Code");

                    b.HasKey("Code");
                });

            modelBuilder.Entity("Web.Models.Period", b =>
                {
                    b.Property<string>("Id");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Web.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<int?>("CategoryId")
                        .IsRequired();

                    b.Property<string>("CurrencyCode");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("PeriodId")
                        .IsRequired();

                    b.Property<int?>("TransactionTypeId")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Web.Models.TransactionType", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 20);

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Web.Models.Transaction", b =>
                {
                    b.HasOne("Web.Models.Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Web.Models.Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyCode");

                    b.HasOne("Web.Models.Period")
                        .WithMany()
                        .HasForeignKey("PeriodId");

                    b.HasOne("Web.Models.TransactionType")
                        .WithMany()
                        .HasForeignKey("TransactionTypeId");
                });
        }
    }
}
