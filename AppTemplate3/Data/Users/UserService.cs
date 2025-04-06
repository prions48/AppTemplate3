using Microsoft.EntityFrameworkCore;
namespace AppTemplate3.Data.Users
{
    public class UserService
    {
        private readonly UserContext _context;
        public UserService(UserContext context)
        {
            _context = context;
        }
        public Auth0User GetUserByKey(string saml)
        {
            List<Auth0User> users = _context.Auth0Users.FromSqlRaw($"SELECT * FROM [Auth0Users] WHERE [UserSAML] = '{saml}'").ToList();
            if (users.Count > 0)
                return users.FirstOrDefault()!;
            Auth0User newuser = new Auth0User(saml);
            _context.Auth0Users.Add(newuser);
            _context.SaveChanges();
            return newuser;
        }
        public void RecordLogin(Guid userid)
        {
            AuditLogin login = new AuditLogin()
            {
                UserID = userid
            };
            _context.AuditLogins.Add(login);
            _context.SaveChanges();
        }
    }
}