using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI2.Models;

namespace WebAPI2.Controllers
{
    public class ClienteController : ApiController
    {

        private List<Cliente> clientes = new List<Cliente>()
        {
            new Cliente(){ cod_cliente=1, nome_cliente="Angélica Noronha", telefone_cliente="585968541"},
            new Cliente(){ cod_cliente=2, nome_cliente="Edvilson Almeida", telefone_cliente="369258147"},
            new Cliente(){ cod_cliente=3, nome_cliente="Burgos Filho", telefone_cliente="147258963"}
        };

        public IEnumerable<Cliente> Get()
        {
            return clientes.ToList();
        }

        public Cliente Get(int id)
        {

            return clientes.FirstOrDefault(x => x.cod_cliente == id);

        }
    }
}
