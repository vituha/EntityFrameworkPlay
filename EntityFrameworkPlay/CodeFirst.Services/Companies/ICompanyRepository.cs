using System.Collections.Generic;

namespace Vituha.Play.EntityFramework.CodeFirst.Services.Companies
{
    public interface ICompanyRepository
    {
        Company Create(string name);
        void Delete(int companyId);
        IReadOnlyCollection<Company> FindByName(string name);
        void Update(Company company);
    }
}