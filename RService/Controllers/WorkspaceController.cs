using Microsoft.AspNetCore.Mvc;
using RSecurityBackend.Controllers;
using RSecurityBackend.Services;

namespace RService.Controllers
{
    /// <summary>
    /// Worspace API
    /// </summary>
    [Produces("application/json")]
    [Route("api/workspace")]
    public class WorkspaceController : WorkspaceControllerBase
    {
        public WorkspaceController(IWorkspaceService workspaceService, IUserPermissionChecker userPermissionChecker, IAppUserService appUserService) : base(workspaceService, userPermissionChecker, appUserService)
        {
        }
    }
}
