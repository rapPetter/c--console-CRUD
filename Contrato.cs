using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVinDocuments
{
    public class Contrato : DevInDocuments
    {
        private string finalidade;
        private string primeiraTestemunha;
        private string segundaTestemunha;
        private DateTime dataExpiracao;
        public List<Contrato> ListContrato { get; set; }

        public Contrato(string nomeEstabelecimento, string cnpj, DateTime dataCadastro, DateTime? dataAlteracao, StatusDocumentoEnum statusDocumento, int idFuncionario, string finalidade, string primeiraTestemunha, string segundaTestemunha, DateTime dataExpiracao) :
        base(nomeEstabelecimento, cnpj, dataCadastro, dataAlteracao, statusDocumento, idFuncionario)
        {
            this.finalidade = finalidade;
            this.primeiraTestemunha = primeiraTestemunha;
            this.segundaTestemunha = segundaTestemunha;
            this.dataExpiracao = dataExpiracao;
        }
        public Contrato()
        {

        }
        public string Finalidade
        {
            get { return this.finalidade; }
            set { this.finalidade = value; }
        }
        public string PrimeiraTestemunha
        {
            get { return this.primeiraTestemunha; }
            set { this.primeiraTestemunha = value; }
        }
        public string SegundaTestemunha
        {
            get { return this.segundaTestemunha; }
            set { this.segundaTestemunha = value; }
        }
        public DateTime DataExpiracao
        {
            get { return this.dataExpiracao; }
            set { this.dataExpiracao = value; }
        }
        public void CadastrarDocumento(Contrato contrato)
        {
            ListContrato.Add(contrato);
        }

        public void listarDocumento(Contrato contrato)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("||__________________________________________________________________________________________________________________________________________________________________||");
            Console.WriteLine("||                                                                                                                                                                  ||");
            Console.WriteLine("||*********************************************************** CONTRATOS CADASTRADOS ********************************************************************************||");
            Console.WriteLine("||                                                                                                                                                                  ||");
            Console.WriteLine("||__________________________________________________________________________________________________________________________________________________________________||");
            Console.ResetColor();
            if (contrato.ListContrato.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("||       ===========================================================================================================================");
                Console.WriteLine($"||      |                                        Nenhum contrato registrada                                                        |");
                Console.WriteLine("||       ===========================================================================================================================");
                Console.ResetColor();
            }
            else
            {
                foreach (Contrato item in contrato.ListContrato)
                {
                    Console.WriteLine($"|| __________________________________________ Documento Numero:({contrato.ListContrato.IndexOf(item) + 1}) ___________________________________________");
                    Console.WriteLine("||  |");
                    Console.WriteLine($"||  |           Codigo do documento: {item.CodigoDocumento}             Nome da empresa: {item.NomeEstabelecimento}");
                    Console.WriteLine($"||  |           Cnpj: {item.Cnpj}");
                    Console.WriteLine($"||  |           Data do cadastro: {item.DataCadastro.ToString("dd/MM/yyyy")}            Data de Alteração: {item.DataAlteracao}");
                    Console.WriteLine($"||  |           Status do documento: {item.StatusDocumento}             Funcionario que efeutou cadastro: {item.IdFuncionario}");
                    Console.WriteLine("||  |");
                    Console.WriteLine($"||  |           Finalidade do contrato: {item.Finalidade}                    Data de expiração: {item.DataExpiracao.ToString("dd/MM/yyyy")}");
                    Console.WriteLine($"||  |           Nome da primeira testemunha {item.PrimeiraTestemunha}             Nome da segunda testemunha: {item.SegundaTestemunha}");
                    Console.WriteLine("||  ===========================================================================================================================");
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("||__________________________________________________________________________________________________________________________________________________________________||");
            Console.ResetColor();
            Console.WriteLine();
        }

        public void AlterarItensDocumento(DevInDocuments devindocuments)
        {
        }
        public void AlterarStatusDocumento(Contrato contrato)
        {
        }
    }
}