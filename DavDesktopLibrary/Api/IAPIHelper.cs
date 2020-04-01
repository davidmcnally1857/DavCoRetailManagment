using DavCoUI.Models;
using System.Threading.Tasks;




namespace DavDesktopLibrary.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}