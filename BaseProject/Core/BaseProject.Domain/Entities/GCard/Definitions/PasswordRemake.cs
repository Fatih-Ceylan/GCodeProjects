﻿using Utilities.Core.UtilityDomain.Entities;

namespace BaseProject.Domain.Entities.GCard.Definitions
{
    public class PasswordRemake:BaseEntity
    {
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
