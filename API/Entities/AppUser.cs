namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; } // recommened Id for primary key, as entityfrwk recognizes
        public string UserName { get; set; } //CamelCase recommended to use .net core identity
        
    }
}