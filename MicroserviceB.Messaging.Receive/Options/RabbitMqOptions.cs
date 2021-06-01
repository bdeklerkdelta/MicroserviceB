using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceB.Messaging.Receive.Options
{
    public class RabbitMqOptions
    {
        public string Hostname { get; set; }
        public string QueueName { get; set; }
    }
}
