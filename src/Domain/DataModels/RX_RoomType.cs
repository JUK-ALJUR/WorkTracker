﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DataModels
{
    public class RX_RoomType
    {
        public Guid Id { get; set; }
        public string Name { get; set; } // max 28 reqired
        public string Description { get; set; } //255
    }
}