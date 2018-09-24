using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHelper.Models.Tables.Encounter
{
    public class EncounterEvent
    {
        public Guid Id { get; set; }
        public Event Event { get; set; }
    }
}
