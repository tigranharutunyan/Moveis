using Microsoft.AspNetCore.Identity;
using System.Drawing;

namespace Moveis.Data.Entity
{
    public class Admin
    {
        public int Id { get; set; }       
        public string Name { get; set; }    
        public string Login { get; set; }          
        public string Password { get;set; }
    }
}
