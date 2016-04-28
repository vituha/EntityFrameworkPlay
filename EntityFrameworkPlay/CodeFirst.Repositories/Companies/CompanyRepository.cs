using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Vituha.Play.EntityFramework.CodeFirst.Repositories.Tables;
using Vituha.Play.EntityFramework.CodeFirst.Services.Companies;

namespace Vituha.Play.EntityFramework.CodeFirst.Repositories.Companies
{
    internal sealed class CompanyRepository : ICompanyRepository
    {
        public Company Create(string name)
        {
            using (var context = new SampleContext())
            {
                var company = context.Companies.Create();

                company.Name = name;

                context.Companies.Add(company);

                context.SaveChanges();

                return new Company(company.Id, company.Name);
            }
        }

        public void Delete(int companyId)
        {
            using (var context = new SampleContext())
            {
                var company = context.Companies.Find(companyId);

                context.Companies.Remove(company);

                context.SaveChanges();
            }
        }

        public void Update(Company company)
        {
            using (var context = new SampleContext())
            {
                var companyTable = context.Companies.Find(company.Id);

                companyTable.Name = company.Name;

                context.SaveChanges();
            }
        }

        public IReadOnlyCollection<Company> FindByName(string name)
        {
            // load tables
            CompanyTable[] tables;
            using (var context = new SampleContext())
            {
                var query =
                    from company in context.Companies.AsNoTracking()
                    where company.Name == name
                    select company;

                tables = query.ToArray();
            }

            // map to domain
            return tables
                .Select(c => new Company(c.Id, c.Name))
                .ToArray();
        }
    }
}
