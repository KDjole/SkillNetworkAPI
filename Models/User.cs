namespace SkillNetworkAPI.Models{

    public partial class User{

        public int UserId {get; set;}
        public string FirstName {get; set;} = "";
        public string LastName  {get; set;} = "";
        public char Gender {get; set;}
        public DateTime DateOfBirth {get; set;}
        public string Description  {get; set;} = "";
        public string Image {get; set;} = "";
        public DateTime AccountCreated {get; set;}
        public bool Active;

    }
}