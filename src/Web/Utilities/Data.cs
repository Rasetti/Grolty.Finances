using System;
using System.Linq;
using Microsoft.AspNet.Hosting;
using Microsoft.Data.Entity;
using Web.Models;

namespace Web.Utilities
{
    public class Data
    {
        public void InitialiseDatabase(IHostingEnvironment env)
        {
            if (!env.IsDevelopment()) return;

            using (var dbContext = new GroltyFinancesWebContext())
            {
                dbContext.Database.EnsureCreated();
                dbContext.Database.Migrate();

                if (!dbContext.TransactionTypes.Any(x => x.Id == TransactionTypes.Expense))
                    dbContext.TransactionTypes.Add(new TransactionType {Id = TransactionTypes.Expense, Name = Enum.GetName(typeof (TransactionTypes), TransactionTypes.Expense)});

                if (!dbContext.TransactionTypes.Any(x => x.Id == TransactionTypes.Income))
                    dbContext.TransactionTypes.Add(new TransactionType {Id = TransactionTypes.Income, Name = Enum.GetName(typeof (TransactionTypes), TransactionTypes.Income)});

                if (!dbContext.AccountSources.Any(x => x.Name == "ANZ Visa"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "ANZ Visa", Id = 1, IsActive = true});

                if (!dbContext.AccountSources.Any(x => x.Name == "Juampi ASB"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "Juampi ASB", Id = 2, IsActive = false});

                if (!dbContext.AccountSources.Any(x => x.Name == "Mad ASB"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "Mad ASB", Id = 3, IsActive = false});

                if (!dbContext.AccountSources.Any(x => x.Name == "Cash"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "Cash", Id = 4, IsActive = true});

                if (!dbContext.AccountSources.Any(x => x.Name == "ANZ Grolty Trust Fund"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "ANZ Grolty Trust Fund", Id = 5, IsActive = false});

                if (!dbContext.AccountSources.Any(x => x.Name == "ANZ Freedom"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "ANZ Freedom", Id = 6, IsActive = true});

                if (!dbContext.AccountSources.Any(x => x.Name == "ANZ Grolthar cash stash"))
                    dbContext.AccountSources.Add(new AccountSource {Name = "ANZ Grolthar cash stash", Id = 7, IsActive = false});

                dbContext.SaveChanges();
            }
        }
    }
}