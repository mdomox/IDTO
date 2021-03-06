﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Repository
{
    public abstract class EntityBase : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; } //Renamed since a possible coflict with State entity column
    }
}