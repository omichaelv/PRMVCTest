using PRMVCTest.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PRMVCTest.Services
{
    public interface IDataAccessService
    {
        Task<List<NavigationMenu>> GetMenuItemsAsync(ClaimsPrincipal principal);
    }
}