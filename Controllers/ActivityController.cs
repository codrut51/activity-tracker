using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Activity.Models;
using Activity.Repository;
using System;
using System.Diagnostics;
using AutoMapper;
using Activity.Data;

namespace Activity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IRepository<ActivityModel> activityRepo;
        private readonly IMapper mapper;

        public ActivityController(IRepository<ActivityModel> activityRepo, IMapper mapper)
        {
            this.activityRepo = activityRepo;
            this.mapper = mapper;
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
        public ActionResult AddActivity(ActivityModel am)
        {
            Debug.WriteLine("Hello!");
            Debug.WriteLine(am.Id.ToString() + " " + am.Title + " " +
                            am.User + " " + am.Description + " " +
                            am.CreatedOn + " " + am.LastModified);
            return Ok();
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