﻿namespace BaseProject.Domain.Entities.GHR.Recruitment.TestDetails
{
    public class TestQuestion : B_BaseEntity
    {
        public Guid TestId { get; set; }

        public string Questions { get; set; }

        public Test Test { get; set; }
    }
}
