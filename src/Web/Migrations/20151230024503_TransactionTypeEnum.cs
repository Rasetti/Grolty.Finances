using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Web.Migrations
{
    public partial class TransactionTypeEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Transaction_AccountSource_AccountSourceId", table: "Transaction");
            migrationBuilder.DropForeignKey(name: "FK_Transaction_Category_CategoryId", table: "Transaction");
            migrationBuilder.DropForeignKey(name: "FK_Transaction_Period_PeriodId", table: "Transaction");
            migrationBuilder.DropForeignKey(name: "FK_Transaction_TransactionType_TransactionTypeId", table: "Transaction");
            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_AccountSource_AccountSourceId",
                table: "Transaction",
                column: "AccountSourceId",
                principalTable: "AccountSource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Category_CategoryId",
                table: "Transaction",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Period_PeriodId",
                table: "Transaction",
                column: "PeriodId",
                principalTable: "Period",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_TransactionType_TransactionTypeId",
                table: "Transaction",
                column: "TransactionTypeId",
                principalTable: "TransactionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Transaction_AccountSource_AccountSourceId", table: "Transaction");
            migrationBuilder.DropForeignKey(name: "FK_Transaction_Category_CategoryId", table: "Transaction");
            migrationBuilder.DropForeignKey(name: "FK_Transaction_Period_PeriodId", table: "Transaction");
            migrationBuilder.DropForeignKey(name: "FK_Transaction_TransactionType_TransactionTypeId", table: "Transaction");
            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_AccountSource_AccountSourceId",
                table: "Transaction",
                column: "AccountSourceId",
                principalTable: "AccountSource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Category_CategoryId",
                table: "Transaction",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Period_PeriodId",
                table: "Transaction",
                column: "PeriodId",
                principalTable: "Period",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_TransactionType_TransactionTypeId",
                table: "Transaction",
                column: "TransactionTypeId",
                principalTable: "TransactionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
