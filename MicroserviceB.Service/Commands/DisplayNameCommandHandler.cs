using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroserviceB.Service.Commands
{
    public class DisplayNameCommandHandler : IRequestHandler<DisplayNameCommand>
    {
        public async Task<Unit> Handle(DisplayNameCommand request, CancellationToken cancellationToken)
        {
            Console.WriteLine(string.Format("Hello {0}, I am your father!", request.Name));

            return Unit.Value;
        }
    }
}
