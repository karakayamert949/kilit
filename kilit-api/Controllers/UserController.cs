using kilit_data.Data.Dto;
using kilit_services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace kilit_api.Controllers
{
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        [ActionName("user/{id}")]
        public UserDto Get(int id) { 
            var data = _userService.GetById(id);
            return Mapper.Map<UserDto>(data);
        }
    }
}
