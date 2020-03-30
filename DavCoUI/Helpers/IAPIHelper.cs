using System.Threading.Tasks;
using DavCoUI.Models;

namespace DavCoUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}