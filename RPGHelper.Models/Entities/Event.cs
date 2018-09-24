using System;
using System.Collections.Generic;
using System.Text;
using RPGHelper.Models.Tables.Encounter;

namespace RPGHelper.Models.Entities
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Flavor { get; set; }
    }
}
