using System.ComponentModel.DataAnnotations.Schema;

namespace Vituha.Play.EntityFramework.CodeFirst.Repositories.Tables
{
    [Table("Company")]
    internal sealed class CompanyTable
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}
