using ProjetoModeloDDD.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClienteEspeciais();
    }
}
