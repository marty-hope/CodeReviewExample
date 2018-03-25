using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CodeReviewExample;
using Dapper;

namespace TotalAwesomeThirdPartyThing
{
    public class AuthorRepositoryTwo : AuthorRepositoryOne
    {
        public override Author Find(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString))
            {
                return db.Query<Author>($"Select * From Author WHERE Id = @Id", new { id }).SingleOrDefault();
            }
        }
    }
}
