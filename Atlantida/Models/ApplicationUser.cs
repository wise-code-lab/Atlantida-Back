using System;
using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace Atlantida.Models
{
    [CollectionName("Users")]
    public class ApplicationUser : MongoIdentityUser<Guid>
    {
        public ApplicationUser()
            : base()
        {
        }

        public ApplicationUser(string userName, string email)
            : base(userName, email)
        {
        }
    }
}
