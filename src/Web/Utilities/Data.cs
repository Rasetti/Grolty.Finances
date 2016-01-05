using System;
using System.Linq;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.ChangeTracking;
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

                var expense = new TransactionType {Id = TransactionTypes.Expense, Name = Enum.GetName(typeof (TransactionTypes), TransactionTypes.Expense)};
                if (!dbContext.TransactionTypes.Any(x => x.Id == expense.Id))
                    dbContext.TransactionTypes.Add(expense);

                var income = new TransactionType {Id = TransactionTypes.Income, Name = Enum.GetName(typeof (TransactionTypes), TransactionTypes.Income)};
                if (!dbContext.TransactionTypes.Any(x => x.Id == income.Id))
                    dbContext.TransactionTypes.Add(income);

                EntityEntry<Category> c = null;
                var categoryCar = new Category {Name = "Car"};
                if (!dbContext.Categories.Any(x => x.Name == categoryCar.Name))
                {
                    c = dbContext.Categories.Add(categoryCar);
                }

                if (!dbContext.Categories.Any(x => x.Name == "Clothing"))
                    dbContext.Categories.Add(new Category {Name = "Clothing"});

                if (!dbContext.Categories.Any(x => x.Name == "Entertainment"))
                    dbContext.Categories.Add(new Category {Name = "Entertainment"});

                if (!dbContext.Categories.Any(x => x.Name == "Food"))
                    dbContext.Categories.Add(new Category {Name = "Food"});

                if (!dbContext.Categories.Any(x => x.Name == "Grolty"))
                    dbContext.Categories.Add(new Category {Name = "Grolty"});

                if (!dbContext.Categories.Any(x => x.Name == "Health & Fitness"))
                    dbContext.Categories.Add(new Category {Name = "Health & Fitness"});

                if (!dbContext.Categories.Any(x => x.Name == "Housekeeping"))
                    dbContext.Categories.Add(new Category {Name = "Housekeeping"});

                if (!dbContext.Categories.Any(x => x.Name == "Housing"))
                    dbContext.Categories.Add(new Category {Name = "Housing"});

                if (!dbContext.Categories.Any(x => x.Name == "Personal Care"))
                    dbContext.Categories.Add(new Category {Name = "Personal Care"});

                if (!dbContext.Categories.Any(x => x.Name == "Public Transport"))
                    dbContext.Categories.Add(new Category {Name = "Public Transport"});

                if (!dbContext.Categories.Any(x => x.Name == "Salary"))
                    dbContext.Categories.Add(new Category {Name = "Salary"});

                if (!dbContext.Categories.Any(x => x.Name == "Utilities"))
                    dbContext.Categories.Add(new Category {Name = "Utilities"});

                if (!dbContext.Categories.Any(x => x.Name == "Gift"))
                    dbContext.Categories.Add(new Category {Name = "Gift"});

                if (!dbContext.Categories.Any(x => x.Name == "Books and learning"))
                    dbContext.Categories.Add(new Category {Name = "Books and learning"});

                if (!dbContext.Categories.Any(x => x.Name == "Medical"))
                    dbContext.Categories.Add(new Category {Name = "Medical"});

                if (!dbContext.Categories.Any(x => x.Name == "Other"))
                    dbContext.Categories.Add(new Category {Name = "Other"});

                if (!dbContext.Categories.Any(x => x.Name == "Bank"))
                    dbContext.Categories.Add(new Category {Name = "Bank"});

                if (!dbContext.Categories.Any(x => x.Name == "Wedding"))
                    dbContext.Categories.Add(new Category {Name = "Wedding"});

                if (!dbContext.Categories.Any(x => x.Name == "Travel"))
                    dbContext.Categories.Add(new Category {Name = "Travel"});

                if (!dbContext.Categories.Any(x => x.Name == "Move to Argentina"))
                    dbContext.Categories.Add(new Category {Name = "Move to Argentina"});

                var currencyNzd = new Currency {Code = "NZD"};
                if (!dbContext.Currencies.Any(x => x.Code == currencyNzd.Code))
                    dbContext.Currencies.Add(currencyNzd);

                EntityEntry<Period> p = null;
                var period1 = new Period {Id = "201512"};
                if (!dbContext.Periods.Any(x => x.Id == period1.Id))
                    p = dbContext.Periods.Add(period1);

                if (!dbContext.Transactions.Any())
                {
                    dbContext.Transactions.Add(new Transaction
                    {
                        Period = p.Entity,
                        Amount = (decimal) 10.01,
                        Category = c.Entity,
                        Date = DateTime.Now,
                        Description = "Test 1",
                        TransactionType = expense,
                        Currency = currencyNzd
                    });
                }

                dbContext.SaveChanges();
            }
        }
    }
}