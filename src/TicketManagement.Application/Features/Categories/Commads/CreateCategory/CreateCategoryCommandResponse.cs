using TicketManagement.Application.Responses;

namespace TicketManagement.Application.Features.Categories.Commads.CreateCategory
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryCommandResponse(): base()
        {

        }

        public CreateCategoryDto Category { get; set; }
    }
}