using System;
using System.Linq;
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

                if (!dbContext.TransactionTypes.Any(x => x.Id == TransactionTypes.Expense))
                    dbContext.TransactionTypes.Add(new TransactionType {Id = TransactionTypes.Expense, Name = Enum.GetName(typeof (TransactionTypes), TransactionTypes.Expense)});

                if (!dbContext.TransactionTypes.Any(x => x.Id == TransactionTypes.Income))
                    dbContext.TransactionTypes.Add(new TransactionType {Id = TransactionTypes.Income, Name = Enum.GetName(typeof (TransactionTypes), TransactionTypes.Income)});

                if (!dbContext.AccountSources.Any(x => x.Name == "ANZ Visa"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "ANZ Visa", IsActive = true});

                if (!dbContext.AccountSources.Any(x => x.Name == "Juampi ASB"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "Juampi ASB", IsActive = false});

                if (!dbContext.AccountSources.Any(x => x.Name == "Mad ASB"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "Mad ASB", IsActive = false});

                if (!dbContext.AccountSources.Any(x => x.Name == "Cash"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "Cash", IsActive = true});

                if (!dbContext.AccountSources.Any(x => x.Name == "ANZ Grolty Trust Fund"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "ANZ Grolty Trust Fund", IsActive = false});

                if (!dbContext.AccountSources.Any(x => x.Name == "ANZ Freedom"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "ANZ Freedom", IsActive = true});

                if (!dbContext.AccountSources.Any(x => x.Name == "ANZ Grolthar cash stash"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "ANZ Grolthar cash stash", IsActive = false});

                if (!dbContext.Categories.Any(x => x.Name == "Car"))
                    dbContext.Categories.Add(new Category {Name = "Car"});

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

                dbContext.SaveChanges();
            }
        }
    }
}