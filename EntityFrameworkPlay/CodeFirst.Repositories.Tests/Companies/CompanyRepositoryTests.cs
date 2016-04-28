using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace Vituha.Play.EntityFramework.CodeFirst.Repositories.Companies
{
    internal sealed class CompanyRepositoryTests
    {
        [Test]
        public void FindByName_should_return_companies_with_correct_names()
        {
            var fixture = new Fixture();
            string originalName = fixture.Create<string>();
            string newName = fixture.Create<string>();

            var sut = new CompanyRepository();

            Company company = sut.Create(originalName);
            int companyId = company.Id;

            sut.FindByName(originalName).Single().Id.Should().Be(companyId);

            company.Rename(newName);
            sut.Update(company);

            sut.FindByName(originalName).Should().BeEmpty();
            sut.FindByName(newName).Single().Id.Should().Be(companyId);

            sut.Delete(companyId);
            sut.FindByName(newName).Should().BeEmpty();
        }
    }
}
