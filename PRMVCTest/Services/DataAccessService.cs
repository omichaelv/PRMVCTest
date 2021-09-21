using Microsoft.EntityFrameworkCore;
using PRMVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PRMVCTest.Services
{
	public class DataAccessService : IDataAccessService
	{
		private readonly AppIdentityDbContext _context;

		public DataAccessService(AppIdentityDbContext context)
		{
			_context = context;
		}

		public async Task<List<NavigationMenu>> GetMenuItemsAsync(ClaimsPrincipal principal)
		{
			var isAuthenticated = principal.Identity.IsAuthenticated;
			if (!isAuthenticated)
				return new List<NavigationMenu>();

			var roleIds = await GetUserRoleIds(principal);
			var data = await (from menu in _context.RoleMenuPermission
							  where roleIds.Contains(menu.RoleId)
							  select menu)
							  .Select(m => new NavigationMenu()
							  {
								  Id = m.NavigationMenu.Id,
								  Name = m.NavigationMenu.Name,
								  ActionName = m.NavigationMenu.ActionName,
								  ControllerName = m.NavigationMenu.ControllerName,
								  ParentMenuId = m.NavigationMenu.ParentMenuId,
							  }).Distinct().ToListAsync();

			return data;
		}

		private async Task<List<string>> GetUserRoleIds(ClaimsPrincipal ctx)
		{
			var userId = GetUserId(ctx);
			var data = await (from role in _context.UserRoles
							  where role.UserId == userId
							  select role.RoleId).ToListAsync();

			return data;
		}

		private string GetUserId(ClaimsPrincipal user)
		{
			return ((ClaimsIdentity)user.Identity).FindFirst(ClaimTypes.NameIdentifier)?.Value;
		}
	}
}
