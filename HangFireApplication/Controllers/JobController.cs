using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HangFireApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {

        [HttpGet]
        public void ListaInteiros()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }


        [HttpPost]
        [Route("CriarBackgroundJob")]
        public ActionResult CriarBackgroudJob()
        {
            BackgroundJob.Enqueue(() => ListaInteiros());

            return Ok();
        }

        [HttpPost]
        [Route("CriarScheduledJob")]
        public ActionResult CriarScheduledJob()
        {
            var scheduleDatetime = DateTime.UtcNow.AddSeconds(5);
            var dateTimeOffSet = new DateTimeOffset(scheduleDatetime);

            BackgroundJob.Schedule(() => Console.WriteLine("Tarefa agendada"), dateTimeOffSet); 

            return Ok();
        }

        [HttpPost]
        [Route("CriarContinuationJob")]
        public ActionResult CriarContinuationJob()
        {
            var scheduleDatetime = DateTime.UtcNow.AddSeconds(5);
            var dateTimeOffSet = new DateTimeOffset(scheduleDatetime);

            var job1 = BackgroundJob.Schedule(() => Console.WriteLine("Tarefa agendada"), dateTimeOffSet);

            var job2 = BackgroundJob.ContinueJobWith(job1, () => Console.WriteLine("Segundo job"));

            var job3 = BackgroundJob.ContinueJobWith(job2, () => Console.WriteLine("Terceiro job"));

            var job4 = BackgroundJob.ContinueJobWith(job3, () => Console.WriteLine("Quarto job"));


            return Ok();
        }

        [HttpPost]
        [Route("CriarRecurringJob")]
        public ActionResult CriarRecurringJob()
        {

            RecurringJob.AddOrUpdate("RecurringJob1", () => Console.WriteLine("Recuring Job"), "* * * * *");

            return Ok();
        }


    }
}
