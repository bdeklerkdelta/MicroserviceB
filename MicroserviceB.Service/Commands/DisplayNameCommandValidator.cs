﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceB.Service.Commands
{
    public class DisplayNameCommandValidator : IRequest
    {
        public string Name { get; set; }
    }
}
