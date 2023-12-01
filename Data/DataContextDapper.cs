using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Npgsql;

namespace SkillNetworkAPI.Data{

    public class DataContextDapper{

        private readonly IConfiguration _config;

        public DataContextDapper(IConfiguration config){
            _config = config;
        }

        public T LoadDataSingle<T>(string sql){
            IDbConnection dbConnection = new NpgsqlConnection(_config.GetConnectionString("DefaultConnection"));
            return dbConnection.QuerySingle<T>(sql);
        }

        public IEnumerable<T> LoadData<T>(string sql){
            IDbConnection dbConnection = new NpgsqlConnection(_config.GetConnectionString("DefaultConnection"));
            return dbConnection.Query<T>(sql);
        }
        
    }
}
