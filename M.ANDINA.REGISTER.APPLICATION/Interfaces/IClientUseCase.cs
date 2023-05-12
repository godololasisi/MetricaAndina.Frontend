using M.ANDINA.REGISTER.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.ANDINA.REGISTER.APPLICATION.Interfaces
{
    public interface IClientUseCase
    {
        Task<Client> GetClients();
    }
}
