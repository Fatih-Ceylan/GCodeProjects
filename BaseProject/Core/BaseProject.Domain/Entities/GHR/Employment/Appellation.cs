namespace BaseProject.Domain.Entities.GHR.Employment
{
    public class Appellation : B_BaseEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public Guid? MainAppellationId { get; set; }
    }
}
