using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVinDocuments
{

    public class NotaFiscal : DevInDocuments
    {
        private string nomeProduto;
        private decimal valorTotal;
        private TipoImpostoEnum tipo;
        private decimal valorTotalImposto;
        public List<NotaFiscal> ListNotaFiscal { get; set; }

        public NotaFiscal(string nomeEstabelecimento, string cnpj, DateTime dataCadastro, DateTime? dataAlteracao, StatusDocumentoEnum statusDocumento, int idFuncionario, string nomeProduto, decimal valorTotal, decimal valorTotalImposto, TipoImpostoEnum tipo) :
        base(nomeEstabelecimento, cnpj, dataCadastro, dataAlteracao, statusDocumento, idFuncionario)
        {
            this.nomeProduto = nomeProduto;
            this.valorTotal = valorTotal;
            this.valorTotalImposto = valorTotalImposto;
            this.tipo = tipo;
        }
        public NotaFiscal()
        {
        }
        public string NomeProduto
        {
            get { return this.nomeProduto; }
            set { this.nomeProduto = value; }
        }
        public decimal ValorTotal
        {
            get { return this.valorTotal; }
            set { this.valorTotal = value; }
        }
        public decimal ValorTotalImposto
        {
            get { return this.valorTotalImposto; }
            set { this.valorTotalImposto = value; }
        }
        public TipoImpostoEnum Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public void CadastrarDocumentoNFE(NotaFiscal notafiscal)
        {
            ListNotaFiscal.Add(notafiscal);
        }

        public void listarDocumento(NotaFiscal notafiscal)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("||__________________________________________________________________________________________________________________________________________________________________||");
            Console.WriteLine("||                                                                                                                                                                  ||");
            Console.WriteLine("||********************************************************** NOTAS FISCAIS CADASTRADAS *****************************************************************************||");
            Console.WriteLine("||                                                                                                                                                                  ||");
            Console.WriteLine("||__________________________________________________________________________________________________________________________________________________________________||");
            Console.ResetColor();
            if (notafiscal.ListNotaFiscal.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("||       ===========================================================================================================================");
                Console.WriteLine($"||      |                                     Nenhuma nota fiscal registrada                                                        |");
                Console.WriteLine("||       ===========================================================================================================================");
                Console.ResetColor();
            }
            else
            {
                foreach (NotaFiscal item in notafiscal.ListNotaFiscal)
                {
                    Console.WriteLine($"||  ____________________________________________________ Documento Numero:({notafiscal.ListNotaFiscal.IndexOf(item) + 1})____________________________________________________");
                    Console.WriteLine("||  |");
                    Console.WriteLine($"||  |           Codigo do documento: {item.CodigoDocumento}             Nome da empresa: {item.NomeEstabelecimento}");
                    Console.WriteLine($"||  |           Cnpj: {item.Cnpj}");
                    Console.WriteLine($"||  |           Data do cadastro: {item.DataCadastro.ToString("dd/ MM/ yyyy")}            Data de Alteração: {item.DataAlteracao}");
                    Console.WriteLine($"||  |           Status do documento: {item.StatusDocumento}             Funcionario que efeutou cadastro: {item.IdFuncionario}");
                    Console.WriteLine($"||  |");
                    Console.WriteLine($"||  |           Nome do produto: {item.NomeProduto}              Valor total do produto: R$ {item.ValorTotal.ToString("F")} ");
                    Console.WriteLine($"||  |           Tipo de imposto: {item.Tipo}              Valor total do Imposto: R$ {item.ValorTotalImposto.ToString("F")}");
                    Console.WriteLine("||  ===========================================================================================================================");
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("||                                                                                                                                                                  ||");
            Console.WriteLine("||__________________________________________________________________________________________________________________________________________________________________||");
            Console.ResetColor();
        }

        public void AlterarItensDocumento(NotaFiscal notafiscal)
        {
        }
        public void AlterarStatusDocumento(NotaFiscal notafiscal)
        {
        }
    }
}