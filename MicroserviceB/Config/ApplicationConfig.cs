using MicroserviceB.Messaging.Receive.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceB.Config
{
    public class ApplicationConfig
    {
        public RabbitMqOptions RabbitMq { get; set; }
    }
}
