using Microsoft.Extensions.Configuration;
using MyTemplate.BLL.Service.EntityRepository;
using MyTemplate.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTemplate.BLL.Service.ControllerService
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
    }
    public class UserService: IUserService
    {
        private readonly IConfiguration _config;
        private readonly IBaseRepository<User> _userService;
        public UserService(IConfiguration config, IBaseRepository<User> userService)
        {
            _config = config;
            _userService = userService;
        }
        public async Task<List<User>> GetAll()
        {
            return await _userService.GetAll();
        }
    }
}
