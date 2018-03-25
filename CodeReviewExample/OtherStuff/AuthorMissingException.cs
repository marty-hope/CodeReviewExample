using System;

namespace CodeReviewExample.OtherStuff
{
    public class AuthorMissingException : Exception
    {
        public AuthorMissingException(string message) : base(message)
        {}
    }
}