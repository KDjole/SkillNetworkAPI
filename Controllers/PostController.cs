using Microsoft.AspNetCore.Mvc;
using SkillNetworkAPI.Data;
using SkillNetworkAPI.Models;

namespace SkillNetworkAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase{

        private readonly DataContextDapper _dapper;
   
        public PostController(IConfiguration config){
            _dapper = new DataContextDapper(config);
        }

        [HttpGet("TestConnection")]
        public DateTime TestConnection()
        {
            return _dapper.LoadDataSingle<DateTime>("SELECT CURRENT_DATE");
        }

        [HttpGet("GetAllUsers")]

        public IEnumerable<User> GetAllUsers(){
            string sql = "SELECT user_id, first_name, last_name, gender, date_of_birth, description, image, account_created, active FROM users.user_info";
            Console.WriteLine(sql);
            IEnumerable<User> users =  _dapper.LoadData<User>(sql);
            return users;
        }

    }
}