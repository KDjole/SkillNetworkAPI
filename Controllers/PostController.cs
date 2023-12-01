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
            string sql = @"SELECT user_id AS UserId, first_name AS FirstName, last_name AS LastName, gender AS Gender,date_of_birth AS DateOfBirth, description AS Description, image AS Image,account_created AS AccountCreated, active AS Active FROM users.user_info";
            Console.WriteLine(sql);
            IEnumerable<User> users =  _dapper.LoadData<User>(sql);
            return users;
        }

    }
}