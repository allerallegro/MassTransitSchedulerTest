using MassTransit;
using System.Threading.Tasks;

namespace MassTransitSchedulerTest
{
    public class TesteConsumer : IConsumer<Teste>
    {
        public async Task Consume(ConsumeContext<Teste> context)
        {
            if (context.Message.Id % 2 > 0)
                throw new System.Exception();
        }
    }
}
