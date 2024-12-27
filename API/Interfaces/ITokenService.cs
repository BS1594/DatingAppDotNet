using API.Model;

namespace API.Interfaces
{
    public interface ITokenService
    {
        public string CreateToken (AppUser user);
    }
}