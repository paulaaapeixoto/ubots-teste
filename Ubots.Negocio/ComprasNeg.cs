using Modelo;
using System.Collections.Generic;
using Ubots.Repositorio;

namespace Ubots.Negocio
{
    public class ComprasNeg
    {
        public static List<Compras> Listar()
        {
            return ComprasRep.Listar();

        }

        public static List<Itens>  ListarItens()
        {
            return ComprasRep.ListarItens();
        }
    }
}
