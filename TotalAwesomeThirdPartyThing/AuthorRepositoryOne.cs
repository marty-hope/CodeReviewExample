using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using TotalAwesomeThirdPartyThing;

namespace CodeReviewExample
{
    public class AuthorRepositoryOne
    {
        public List<Author> ReadAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString))
            {
                return db.Query<Author>
                    ("Select * From Author").ToList();
            }
        }
        public virtual Author Find(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString))
            {
                return db.Query<Author>($"Select * From Author WHERE Id = {id}").SingleOrDefault();
            }
        }
    }
}
