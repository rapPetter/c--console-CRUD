using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVinDocuments
{
    public class LicencaFuncionamento : DevInDocuments
    {
        public List<LicencaFuncionamento> ListLicencaFuncionamento { get; set; }
        private string endereco;
        private AreaAtuacaoEnum areaAtuacao;

        public LicencaFuncionamento(string nomeEstabelecimento, string cnpj, DateTime dataCadastro, DateTime? dataAlteracao, StatusDocumentoEnum statusDocumento, int idFuncionario,
        string endereco, AreaAtuacaoEnum areaAtuacao) :
        base(nomeEstabelecimento, cnpj, dataCadastro, dataAlteracao, statusDocumento, idFuncionario)
        {
            this.endereco = endereco;
            this.areaAtuacao = areaAtuacao;
        }
        public LicencaFuncionamento()
        {

        }
        public string Endereco
        {
            get { return this.endereco; }
            set { this.endereco = value; }
        }
        public AreaAtuacaoEnum AreaAtuacao
        {
            get { return this.areaAtuacao; }
            set { this.areaAtuacao = value; }
        }
        public void CadastrarDocumento(LicencaFuncionamento lecencafuncionamento)
        {
            ListLicencaFuncionamento.Add(lecencafuncionamento);
        }

        public void listarDocumento(LicencaFuncionamento licencafuncionamento)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("||__________________________________________________________________________________________________________________________________________________________________||");
            Console.WriteLine("||                                                                                                                                                                  ||");
            Console.WriteLine("||********************************************************** LICENÇAS DE FUNCIONAMENTO CADASTRADAS *****************************************************************||");
            Console.WriteLine("||                                                                                                                                                                  ||");
            Console.WriteLine("||__________________________________________________________________________________________________________________________________________________________________||");
            Console.ResetColor();
            if (licencafuncionamento.ListLicencaFuncionamento.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("||       ===========================================================================================================================");
                Console.WriteLine($"||      |                              Nenhuma licença de funcionamento registrada                                                |");
                Console.WriteLine("||       ===========================================================================================================================");
                Console.ResetColor();
            }
            else
            {
                foreach (LicencaFuncionamento item in licencafuncionamento.ListLicencaFuncionamento)
                {
                    Console.WriteLine($"||  ________________________________________________ Documento Numero:({licencafuncionamento.ListLicencaFuncionamento.IndexOf(item) + 1}) _______________________________________________");
                    Console.WriteLine("||  |");
                    Console.WriteLine($"||  |           Codigo do documento: {item.CodigoDocumento}             Nome da empresa: {item.NomeEstabelecimento}");
                    Console.WriteLine($"||  |           Cnpj: {item.Cnpj}");
                    Console.WriteLine($"||  |           Data do cadastro: {item.DataCadastro.ToString("dd/ MM/ yyyy")}            Data de Alteração: {item.DataAlteracao}");
                    Console.WriteLine($"||  |           Status do documento: {item.StatusDocumento}             Funcionario que efeutou cadastro: {item.IdFuncionario}");
                    Console.WriteLine($"||  |");
                    Console.WriteLine($"||  |           Área de atuação: : {item.AreaAtuacao}              Endereço: {item.Endereco} ");
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
            return;
        }
        public void AlterarStatusDocumento(DevInDocuments devindocuments)
        {
            return;
        }
    }
}