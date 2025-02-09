using AutoMapper;
using kilit_data.Data.Dto;
using kilit_data.Data.Model;
using kilit_services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace kilit_api.Controllers
{
    [Route("users")]
    public class UserController:ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService,IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        [HttpGet("{id}")]
        public UserDto Get(int id) { 
            var data = _userService.GetById(id);
            return _mapper.Map<UserDto>(data);
        }

        [HttpGet]
        public IEnumerable<UserDto> Get() 
        {
            var data = _userService.Get();
            return _mapper.Map<IEnumerable<UserDto>>(data);
        }
        [HttpPost]
        public void Add(SignupRequest request)
        {
            _userService.Add(request);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.Remove(id);
        }
    }
}
