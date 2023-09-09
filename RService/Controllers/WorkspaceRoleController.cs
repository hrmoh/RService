using Microsoft.AspNetCore.Mvc;
using RSecurityBackend.Controllers;
using RSecurityBackend.Services;

namespace RService.Controllers
{
    /// <summary>
    /// Workspace User roles
    /// </summary>
    [Produces("application/json")]
    [Route("api/workspace/roles")]
    public class WorkspaceRoleController : WorkspaceRoleControllerBase
    {
        public WorkspaceRoleController(IWorkspaceRolesService roleService) : base(roleService)
        {
        }
    }
}
