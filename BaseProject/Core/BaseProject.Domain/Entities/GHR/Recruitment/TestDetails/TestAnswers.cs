﻿using BaseProject.Domain.Entities.GHR.Recruitment.Applications;

namespace BaseProject.Domain.Entities.GHR.Recruitment.TestDetails
{
    public class TestAnswers : B_BaseEntity
    {
        public Guid JobApplicationTestId { get; set; }

        public Guid TestId { get; set; }

        public Guid TestQuestionOptionId { get; set; }

        public bool IsAnswerCorrect { get; set; }

        public JobApplicationTest JobApplicationTest { get; set; }

        public Test Test { get; set; }

        public TestQuestionOptions Question { get; set; }
    }
}
