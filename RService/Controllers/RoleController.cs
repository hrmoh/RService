using Microsoft.AspNetCore.Mvc;
using RSecurityBackend.Controllers;
using RSecurityBackend.Services;

namespace RService.Controllers
{
    /// <summary>
    ///roles
    /// </summary>
    [Produces("application/json")]
    [Route("api/roles")]
    public class RoleController : RoleControllerBase
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="roleService"></param>
        public RoleController(IUserRoleService roleService)
            : base(roleService)
        {
        }
    }
}
