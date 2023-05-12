using M.ANDINA.REGISTER.APPLICATION.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M.ANDINA.REGISTER.DOMAIN;

namespace M.ANDINA.REGISTER.APPLICATION.UseCase.Client
{
    public class ClientUseCase : IClientUseCase
    {
        private readonly IClientService _clientService;
        public ClientUseCase(IClientService clientService)
        {
            _clientService= clientService;
        }
        public async Task<DOMAIN.Client> GetClients()
        {
            return await _clientService.GetClientService();
        }

    }
}
