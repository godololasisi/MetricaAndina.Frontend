using M.ANDINA.REGISTER.APPLICATION.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace M.ANDINA.REGISTER.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientUseCase _clientUseCase;
        public ClientController(IClientUseCase clientUseCase)
        {
            _clientUseCase= clientUseCase;
        }

        public async Task<ActionResult> Index()
        {
            var response = await _clientUseCase.GetClients();

            return View(response);
        }

        public ActionResult DetailsClient(int id)
        {
            return View();
        }
    }
}
