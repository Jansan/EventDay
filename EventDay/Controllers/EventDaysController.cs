using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventDay.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventDay.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventDaysController : ControllerBase
    {
        private EventRepository repo;
        private readonly IMapper mapper;

        public EventDaysController(EventDayContext context, IMapper mapper)
        {
            repo = new EventRepository(context);
            this.mapper = mapper;
            
        }

    }
}
