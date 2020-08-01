using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyTemplate.BLL.Dto;
using MyTemplate.BLL.Service.ControllerService;
using MyTemplate.DAL.Entities;

namespace MyTemplate.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }
        [HttpGet]
        public async Task<ActionResult> GetUserList()
        {
            //
            return Ok(await _userService.GetAll());
        }
    }
}
