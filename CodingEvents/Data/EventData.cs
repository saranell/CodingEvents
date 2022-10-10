using System;
using System.Collections.Generic;
using CodingEvents.Models;

namespace CodingEvents.Data
{
    public class EventData
    {
        //TODO: store events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();

        //TODO: add events
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);       
        }
        //TODO: retreive the events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        //TODO: retreive a single event
        public static Event GetById(int id)
        {
            return Events[id];
        }

        //TODO: remove an event
        public static void Remove(int id)
        {
            Events.Remove(id);
        }
    }
}