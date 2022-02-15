using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace MassTransitSchedulerTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly IMessageScheduler scheduler;
        private readonly IBus bus;

        public TesteController(IMessageScheduler scheduler, IBus bus)
        {
            this.scheduler = scheduler;
            this.bus = bus;
        }
        [HttpGet("{id:int}")]
        public async Task<int> Index(int id, CancellationToken ct)
        {
            Thread.Sleep(5000);
            await bus.Publish(new Teste
            {
                Mensagem = "Isso é um teste",
                Id = id
            }, ct);
            return 0;


        }
    }
}
