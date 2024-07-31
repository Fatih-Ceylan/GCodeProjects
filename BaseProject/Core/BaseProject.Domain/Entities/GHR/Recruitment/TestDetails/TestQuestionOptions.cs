namespace BaseProject.Domain.Entities.GHR.Recruitment.TestDetails
{
    public class TestQuestionOptions : B_BaseEntity
    {
        public Guid QuestionId { get; set; }

        public Guid TestId { get; set; }

        public string Option { get; set; }

        public bool IsOptionCorrect { get; set; }
    }
}
