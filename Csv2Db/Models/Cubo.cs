using System;

namespace Csv2Db.Models
{
    class Cubo
    {
        public string Pedido { get; set; }
        public string AnoPedido { get; set; }
        public string MesPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public string Cliente { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Regiao { get; set; }
        public string Codigo { get; set; }
        public string Produto { get; set; }
        public string Categoria { get; set; }
        public string Familia { get; set; }
        public string Linha { get; set; }
        public string Marca { get; set; }
        public string Vendedor { get; set; }
        public string FormaPagamento { get; set; }
        public DateTime DataValidade { get; set; }
        public string TipoVenda { get; set; }
        public DateTime DataFaturamento { get; set; }
        public string NotaFiscal { get; set; }
        public float Quantidade { get; set; }
        public float ValorUnitario { get; set; }
        public float ReceitaBruta { get; set; }
        public float ValorIpi { get; set; }
        public float ValorST { get; set; }
        public int PrazoPagMedio { get; set; }
        public float FatuBruto { get; set; }
        public string MesCadastro { get; set; }
        public string MesFatura { get; set; }
        public bool Faturado { get; set; }
        public string MesEntregue { get; set; }
        public string ClienteNfDataFat { get; set; }
        public string CodigoAjustado { get; set; }
        public string CodNomeProdutoUnidade { get; set; }
        public int UnidadeId { get; set; }
        public float QuantAjustada { get; set; }
        public float PesoBruto { get; set; }
        public string NaturCli { get; set; }
        public string TipoCliente { get; set; }
        public string CategoriaCliente { get; set; }
        public string SegmentoCliente { get; set; }
        public string Grupo { get; set; }
        public int PrazoEntrega { get; set; }
        public float TaxaDolar { get; set; }
        public float FatBrutoUsd { get; set; }
        public float PrecoIndividual { get; set; }
        public float ReceitaLiquida { get; set; }
        public float Comissao { get; set; }
        public float Frete { get; set; }
        public float CustoFinancCobranca { get; set; }
        public int GrupoRateioId { get; set; }
        public int AnoFaturamento { get; set; }
        public bool TemPeso { get; set; }
        public float PvRsKg { get; set; }
        public string Trimestre { get; set; }
        public float M2Fitas { get; set; }
        public float RecBrutaUsd { get; set; }
        public int CategoProdAjustadaId { get; set; }
        public string PeriodoEstatistico { get; set; }

    }
}
