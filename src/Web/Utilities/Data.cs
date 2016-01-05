using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using Web.Models;

namespace Web.Utilities
{
    public class Data
    {
        public void InitialiseDatabase(IHostingEnvironment env, IApplicationBuilder app)
        {
            if (!env.IsDevelopment()) return;

            using (var dbContext = app.ApplicationServices.GetService<GroltyFinancesWebContext>())
            {
                dbContext.Database.EnsureCreated();
                dbContext.Database.Migrate();

                dbContext.RemoveRange(dbContext.Set<Transaction>());
                dbContext.RemoveRange(dbContext.Set<Category>());
                dbContext.RemoveRange(dbContext.Set<Period>());
                dbContext.RemoveRange(dbContext.Set<TransactionType>());
                dbContext.RemoveRange(dbContext.Set<Currency>());
                dbContext.SaveChanges();

                var expense = new TransactionType {Id = TransactionTypes.Expense, Name = Enum.GetName(typeof (TransactionTypes), TransactionTypes.Expense)};
                dbContext.TransactionTypes.Add(expense);

                var income = new TransactionType {Id = TransactionTypes.Income, Name = Enum.GetName(typeof (TransactionTypes), TransactionTypes.Income)};
                dbContext.TransactionTypes.Add(income);

                var categoryCar = new Category {Name = "Car"};
                dbContext.Categories.Add(categoryCar);
                dbContext.Categories.Add(new Category {Name = "Clothing"});
                dbContext.Categories.Add(new Category {Name = "Entertainment"});
                dbContext.Categories.Add(new Category {Name = "Food"});
                dbContext.Categories.Add(new Category {Name = "Grolty"});
                dbContext.Categories.Add(new Category {Name = "Health & Fitness"});
                dbContext.Categories.Add(new Category {Name = "Housekeeping"});
                dbContext.Categories.Add(new Category {Name = "Housing"});
                dbContext.Categories.Add(new Category {Name = "Personal Care"});
                dbContext.Categories.Add(new Category {Name = "Public Transport"});
                dbContext.Categories.Add(new Category {Name = "Salary"});
                dbContext.Categories.Add(new Category {Name = "Utilities"});
                dbContext.Categories.Add(new Category {Name = "Gift"});
                dbContext.Categories.Add(new Category {Name = "Books and learning"});
                dbContext.Categories.Add(new Category {Name = "Medical"});
                dbContext.Categories.Add(new Category {Name = "Other"});
                dbContext.Categories.Add(new Category {Name = "Bank"});
                dbContext.Categories.Add(new Category {Name = "Wedding"});
                dbContext.Categories.Add(new Category {Name = "Travel"});
                dbContext.Categories.Add(new Category {Name = "Move to Argentina"});

                var currencyNzd = new Currency {Code = "NZD"};
                dbContext.Currencies.Add(currencyNzd);

                var period1 = new Period {Id = "201512"};
                dbContext.Periods.Add(period1);
                
                dbContext.Transactions.Add(new Transaction
                {
                    Period = period1,
                    Amount = (decimal) 10.01,
                    Category = categoryCar,
                    Date = DateTime.Now,
                    Description = "Test 1",
                    TransactionType = expense,
                    Currency = currencyNzd
                });

                dbContext.Transactions.Add(new Transaction
                {
                    Period = period1,
                    Amount = (decimal)10.02,
                    Category = categoryCar,
                    Date = DateTime.Now.AddDays(-10),
                    Description = "Test 2",
                    TransactionType = expense,
                    Currency = currencyNzd
                });

                dbContext.SaveChanges();
            }
        }
    }
}