using System;
using System.Collections.Generic;
using CodingEvents.Models;

namespace CodingEvents.Data
{
    public class EventData
    {
        //TODO: store events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();

        //CRUD...
        //TODO: CREATE (add) events
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }
        //TODO: READ (retreive) the events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        //UPDATE:
        //public static void Update(int id, Event updatedEvent)
        //{
        //    Remove(id);
        //    Add(updatedEvent);
        //}

        //TODO: retreive a single event
        public static Event GetById(int id)
        {
            return Events[id];
        }

        //TODO: DELETE (remove) an event
        public static void Remove(int id)
        {
            Events.Remove(id);
        }
    }
}