using System;
using System.Linq;
using Ubots.Modelo;

namespace Ubots.Negocio
{
    public class RelatorioNeg
    {
        public static string ListarClientesMaioresVendas()
        {
            var compras = ComprasNeg.Listar();

            var comprasGroupByCPF = compras.GroupBy(a => a.cliente).Select(x => new
            {
                cliente = x.Key,
                valorTotal = x.Sum(y => y.valorTotal)
            }).OrderByDescending(x => x.valorTotal).ToList();

            string result = String.Empty;
            int i = 1;
            foreach (var item in comprasGroupByCPF)
            {
                result += String.Format(" ({0}) - Cliente={1}, Valor Total em compras={2}", i, item.cliente, Convert.ToDecimal(item.valorTotal));
                i++;
            }

            return result;

        }

        public static string ClienteMaiorCompra2016()
        {
            var compras = ComprasNeg.Listar();

            var cliente = compras.Where(x => x.data.Contains("2016"))
                                        .OrderByDescending(x => x.valorTotal).First().cliente;

            var cpf = cliente.Remove(0, 1);

            Cliente clientec = ClienteNeg.Buscar(cpf);

            return clientec.cpf + " - " + clientec.nome;
        }

        public static string ListarClientesFieis()
        {
            var compras = ComprasNeg.Listar();

            var comprasCliente = compras.GroupBy(m => m.cliente)
                                        .Select(group => new
                                        {
                                            Cliente = group.Key,
                                            NCompras = group.Count()
                                        }).OrderByDescending(n => n.NCompras).ToList();

            string sb = "";

            foreach (var cc in comprasCliente)
            {
                var cpf = cc.Cliente.Remove(0, 1);
                Cliente cliente = ClienteNeg.Buscar(cpf);
                sb += " Cliente: " + cliente.nome + " Quantidade de Compras: " + cc.NCompras;
                sb += Environment.NewLine;
            }

            return sb.ToString();
        }

        public static string RecomendarVinho()
        {
            var compras = ComprasNeg.ListarItens();


            var vinho = compras.GroupBy(m => new { m.produto, m.variedade, m.categoria }).Select(group => new
            {
                Produto = group.Key,
                Compras = group.Count()
            }).OrderByDescending(n => n.Compras).First();


            return "Recomendo o vinho " + vinho.Produto.produto + "(" + vinho.Produto.variedade + "), pois é o mais vendido.";
        }

    }
}
