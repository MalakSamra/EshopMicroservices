using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    //Command Object
    public record CreateProductCommand(
        string Name,
        List<string> Category, 
        string Description,
        string ImageFile,
        decimal Price):IRequest<CreateProductResult>;

    //Result Object
    public record CreateProductResult(
        Guid Id);

    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            //Business Logic to create a product
            throw new NotImplementedException();
        }
    }
}
