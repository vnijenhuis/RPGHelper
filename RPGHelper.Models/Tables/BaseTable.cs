using System;
using System.Collections;
using System.Collections.Generic;
using RPGHelper.Models.Entities;

namespace RPGHelper.Models.Tables
{
    public class BaseTable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TableType Type { get; set; }
        public string Description { get; set; }
    }
}
