﻿using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Shared.Entities
{
    public class Entity : Notifiable
    {
        public Entity()
        {
            Id = Guid.NewGuid();

        }

        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        
    }
}
