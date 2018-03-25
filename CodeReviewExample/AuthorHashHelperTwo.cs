using System;
using CodeReviewExample.OtherStuff;
using TotalAwesomeThirdPartyThing;

namespace CodeReviewExample
{
    public class AuthorHashHelperTwo
    {
        private readonly HashHelper _hashHelper = new HashHelper();
        private readonly IAuthorRepository _authorRepository;

        public AuthorHashHelperTwo(IAuthorRepository repository)
        {
            _authorRepository = repository;
        }

        public string HashAuthorName(int id)
        {
            var arthur = _authorRepository.GetAuthorById(id);
            var arthurName = $"{arthur.FirstName} {arthur.LastName}";
            return _hashHelper.ComputeHash(arthurName, "sha256", 
                new Byte[] {0x00b, 0x01b, 0x02b, 0x08b});
        }
    }
}
