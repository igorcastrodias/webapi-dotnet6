using MediatR;

namespace TicketManagement.Application.Features.Categories.Commads.CreateCategory
{
public class CreateCategoryCommand: IRequest<CreateCategoryCommandResponse>
    {
        public string Name { get; set; }
    }
}