using System;
using TotalAwesomeThirdPartyThing;

namespace CodeReviewExample
{
    public class AuthorHashHelperOne
    {
        private readonly HashHelper _thing = new HashHelper();
        private readonly AuthorRepositoryTwo _authorRepository 
            = new AuthorRepositoryTwo();

        public string HashAuthorName(int id)
        {
            var arthur = _authorRepository.Find(id);
            var arthurName = $"{arthur.FirstName} {arthur.LastName}";
            return _thing.ComputeHash(arthurName, "sha256", 
                new Byte[] {0x00b, 0x01b, 0x02b, 0x08b});
        }
    }
}
