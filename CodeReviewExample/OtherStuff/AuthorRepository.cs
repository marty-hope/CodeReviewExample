using TotalAwesomeThirdPartyThing;

namespace CodeReviewExample.OtherStuff
{
    public class AuthorRepository : IAuthorRepository
    {
        public Author GetAuthorById(int id)
        {
            AuthorRepositoryTwo two = new AuthorRepositoryTwo();
            var author = two.Find(id);
            if (author == null)
            {
                throw new AuthorMissingException($"Author with id {id} not found.");
            }
            return author;
        }
    }
}
