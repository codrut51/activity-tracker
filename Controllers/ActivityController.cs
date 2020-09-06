using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Activity.Models;
using Activity.Repository;
using System;
using AutoMapper;
using Activity.Data.Read;
using Activity.Data.Create;
using System.Linq;

namespace Activity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IRepository<ActivityModel> activityRepo;
        private readonly IRepository<UsersModel> usersRepo;
        private readonly IMapper mapper;

        public ActivityController(IRepository<ActivityModel> activityRepo, IRepository<UsersModel> usersRepo, IMapper mapper)
        {
            this.activityRepo = activityRepo;
            this.mapper = mapper;
            this.usersRepo = usersRepo;
        }

        //GET api/activity
        [HttpGet]
        public ActionResult<IEnumerable<ActivityDto>> GetAllActivities()
        {
            return Ok(mapper.Map<IEnumerable<ActivityModel>, IEnumerable<ActivityDto>>(activityRepo.getAll()));
        }

        //GET api/activity/{id}
        [HttpGet("{id}")]
        public ActionResult<ActivityDto> GetActivityById(Guid id)
        {
            var res = activityRepo.getOne(id);
            if (res != null)
            {
                return Ok(mapper.Map<ActivityDto>(res));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<ActivityDto> AddActivity(ActivityCreateDto am)
        {
            var activityModel = mapper.Map<ActivityModel>(am);
            activityModel.User = usersRepo.getOne(am.UserId) ?? throw new Exception("User not found!");
            activityRepo.addOne(activityModel);
            activityRepo.saveChanges();
            return Ok(mapper.Map<ActivityDto>(activityModel));
        }

        [HttpPut]
        public ActionResult UpdateActivity(int id, ActivityModel am)
        {
            return null;
        }

        [HttpDelete]
        public ActionResult UpdateActivity(int id)
        {
            return null;
        }

    }
}