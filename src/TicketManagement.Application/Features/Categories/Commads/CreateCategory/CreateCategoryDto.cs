namespace TicketManagement.Application.Features.Categories.Commads.CreateCategory
{
    public class CreateCategoryDto
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}