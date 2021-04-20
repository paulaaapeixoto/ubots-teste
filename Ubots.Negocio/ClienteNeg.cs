using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ubots.Modelo;
using Ubots.Repositorio;

namespace Ubots.Negocio
{
    public class ClienteNeg
    {
        public static List<Cliente> Listar()
        {
            return ClienteRep.Listar();

        }


        public static Cliente Buscar(string cpf)

        {
            Cliente cliente = new Cliente();
            var clientes = Listar();

            string sCPF = Regex.Replace(cpf, "[^0-9,]", "");

            foreach (Cliente cli in clientes)
            {
                var cpfCli = Regex.Replace(cli.cpf, "[^0-9,]", "");
                if (cpfCli == sCPF)
                {
                    cliente.cpf = cli.cpf;
                    cliente.id = cli.id;
                    cliente.nome = cli.nome;
                }
            }

            return cliente;
        }
    }
}
