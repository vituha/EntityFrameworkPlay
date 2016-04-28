using System.Data.Entity;
using Vituha.Play.EntityFramework.CodeFirst.Repositories.Tables;

namespace Vituha.Play.EntityFramework.CodeFirst.Repositories
{
    internal sealed class SampleContext : DbContext
    {
        public SampleContext()
            : base("SampleConnection")
        {
        }

        public IDbSet<CompanyTable> Companies { get; set; }
    }
}
