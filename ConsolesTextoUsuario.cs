using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVinDocuments
{
    public static class ConsolesTextoUsuario
    {
        public static void ConsoleMessageErroString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||   Digite somente o número que corresponde ao item     ||");
            Console.ResetColor();
        }
        public static void ConsoleMessageInvalidNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||                Número inválido                        ||");
            Console.ResetColor();
        }

        public static void ConsoleMessageInsertNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||          Inserir somente o valor sem letras           ||");
            Console.ResetColor();
        }
        public static void ConsoleWriteLineAmountInvoice()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||           Insira o valor total do produto             ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLineNomeDoEstabelecimento()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||           Insira o nome do estabelecimento            ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLineCnpj()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||            Insira o cnpj do estabelecimento           ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLineNomeDoProdutoVendido()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||          Insira o nome do produto vendido             ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLineValorTotalDoImposto()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||             Insira o valor total do imposto           ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLineCadastrarNotaFiscal()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||                 CADASTRAR NOTA FISCAL                 ||");
        }
        public static void ConsoleWriteLineCadastrarLicencaDeFuncionamento()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||           CADASTRAR LICENÇA DE FUNCIONAMENTO          ||");
        }
        public static void ConsoleWriteLineEndereco()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||                   Insira o endereço                   ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLineCadastrarContrato()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||                 CADASTRAR CONTRATO                    ||");
        }
        public static void ConsoleWriteLineFinalidade()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||             Insira a finalidade do contrato           ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLinePrimeiraTestemunha()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||        Insira a primeira testemunha do contrato       ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLineSegundaTestemunha()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||        Insira a segunda testemunha do contrato        ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLineAnoExpiraContrato()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||          Insira o ano de expirar o contrato           ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLineDiaExpiraContrato()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||          Insira o dia de expirar o contrato           ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLineMesExpiraContrato()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||          Insira o mes de expirar o contrato           ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleMessageErroDataNaoExiste()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||                Essa data não existe                   ||");
            Console.ResetColor();
        }
        public static void ConsoleWriteLineCodigoAlterarItensDocumento()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||   Digite o codigo do documento para alterar os itens  ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLineAlterarItensDocumento()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||             Alterar itens do documento                ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }

        public static void ConsoleWriteLineAlterarStatusDoDocumento()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||             Alterar status do documento               ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleMessageErroDocumentoStatusNaoEncontrado()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||    Nenhum documento com esse status foi encontrato    ||");
            Console.ResetColor();
        }
        public static void ConsoleWriteLineDigiteQualquerTecla()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||        Digite alguma tecla para voltar ao menu        ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLineCodigoNaoEncontrado()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||    Nenhum documento com esse codigo foi encontrato    ||");
            Console.ResetColor();
        }
        public static void ConsoleWriteLineListarNotaFiscal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||    Nenhum documento com esse codigo foi encontrato    ||");
            Console.ResetColor();
        }
        public static void ConsoleWriteLineCadastradoComSucesso()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||          Documento cadastrado com sucesso             ||");
            Console.WriteLine("||-------------------------------------------------------||");
            Console.ResetColor();
        }
        public static void ConsoleWriteLineAlteradoComSucesso()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||           Documento alterado com sucesso              ||");
            Console.WriteLine("||-------------------------------------------------------||");
            Console.ResetColor();
        }
        public static void ConsoleWriteLineStatusAlteradoComSucesso()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||        Status do documento alterado com sucesso       ||");
            Console.WriteLine("||-------------------------------------------------------||");
            Console.ResetColor();
        }
        public static void ConsoleWriteLineQualDocumentoCadastrar()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||     Digite o numero do documento que quer cadastrar   ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }
        public static void ConsoleWriteLineListarStatusDocumento()
        {
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||               Escolha qual status listar              ||");
            Console.WriteLine("||-------------------------------------------------------||");
        }

    }
}