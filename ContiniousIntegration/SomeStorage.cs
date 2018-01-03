using System.CodeDom.Compiler;
using Modulbank.DbMapping;
using Modulbank.DbMapping.Contracts;
using Newtonsoft.Json.Serialization;

namespace ContiniousIntegration
{
    public class SomeStorage
    {
        private readonly string _connectionString;

        public SomeStorage(string connectionString)
        {
            _connectionString = connectionString;
        }

        private ICommonDbMapper GetDbMapper()
        {
            return new PostgresqlDbMapper(_connectionString);
        }
        
        public int Create(string name)
        {
            return GetDbMapper().ExecuteScalar<int>("insert into test (name) values (:name) returning id", new QueryParameter("name", name));
        }
        
        public void Update(int id, string name)
        {
            GetDbMapper().ExecuteNonQuery("update test set name = :name where id = :id", new QueryParameter("name", name), new QueryParameter("id", id));
        }
        
        public void Delete(int id)
        {
            GetDbMapper().ExecuteNonQuery("delete from test where id = :id", new QueryParameter("id", id));
        }

        public string Read(int id)
        {
            return GetDbMapper().ExecuteScalar<string>("select name from test where id = :id", new QueryParameter("id", id));
        }
    }
}