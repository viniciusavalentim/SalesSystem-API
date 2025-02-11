using Domain.Command.Create.Product;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Handler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, string>
    {

        public Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
