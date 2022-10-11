using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Xml.Linq;
using CodingEvents.Data;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(Event newEvent)
        {
            EventData.Add(newEvent);

            return Redirect("/Events");
        }

        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach(int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }

            return Redirect("/Events");
        }

        [HttpGet]
        [Route("Events/Edit/{eventId}")]
        public IActionResult Edit(int eventId)
        {
            //TODO: Using an EventData method to find the event object with the given eventId:
            Event editingEvent = EventData.GetById(eventId);

            //TODO: Putting the event object in ViewBag:
            ViewBag.eventToEdit = editingEvent;

            //TODO: Adding a title to ViewBag that reads “Edit Event NAME (id=ID)” where "NAME" and "ID" are replaced by the values for the given event:
            ViewBag.title = "Edit Event " + editingEvent.Name + "(id = " + editingEvent.Id + ")";

            //TODO: Returning the appropriate view:
            return View();
        }

        [HttpPost]
        [Route("Events/Edit")]
        public IActionResult SubmitEditEventForm(int eventId, string name, string description)
        {
            //TODO: Querying EventData for the event being edited with the given id parameter:
            Event editingEvent = EventData.GetById(eventId);

            //TODO: Updating the event name and description:
            editingEvent.Name = name;
            editingEvent.Description = description;

            //TODO: Redirecting the user to /Events (the event listing page):
            return Redirect("/Events");
        }
    }
}

