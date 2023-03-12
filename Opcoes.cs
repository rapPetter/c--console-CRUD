using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DEVinDocuments.Menu;

namespace DEVinDocuments
{
    public static class Opcoes
    {
        public static StatusDocumentoEnum statusDoDocumento { get; set; }
        public static AreaAtuacaoEnum AreaDeAtuacao { get; set; }
        public static TipoImpostoEnum TipoImposto { get; set; }
        public static TipoDocumentoEnum TipoDeDocumentoCadastrar { get; set; }
        public static OpcoesMenuEnum ResultadoMenuPrincipalEscolhaUsuario { get; set; }
        public static ExibirListasEnum? ListarTodosDocumentos { get; set; }


        public static StatusDocumentoEnum? ObterStatusDocumento()
        {
            var statusDocumento = Enum.GetValues<StatusDocumentoEnum>();
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("|| Digite o número que corresponde ao status do documento||");
            foreach (var item in statusDocumento)
            {
                if (item == StatusDocumentoEnum.ativo)
                {
                    Console.WriteLine($"||      {(int)item} - Ativo");
                }
                if (item == StatusDocumentoEnum.emTramitação)
                {
                    Console.WriteLine($"||      {(int)item} - Em tramitação");
                }
                if (item == StatusDocumentoEnum.suspenso)
                {
                    Console.WriteLine($"||      {(int)item} - Suspenso");
                }
            }
            Console.WriteLine("||-------------------------------------------------------||");
            var usuarioEscolha = Console.ReadLine();
            try
            {
                if ((StatusDocumentoEnum)(Convert.ToInt32(usuarioEscolha)) == StatusDocumentoEnum.ativo ||
                (StatusDocumentoEnum)(Convert.ToInt32(usuarioEscolha)) == StatusDocumentoEnum.emTramitação ||
                (StatusDocumentoEnum)(Convert.ToInt32(usuarioEscolha)) == StatusDocumentoEnum.suspenso)
                {
                    return statusDoDocumento = (StatusDocumentoEnum)(Convert.ToInt32(usuarioEscolha));
                }
                else
                {
                    ConsolesTextoUsuario.ConsoleMessageInvalidNumber();
                    return ObterStatusDocumento();
                }
            }
            catch
            {
                ConsolesTextoUsuario.ConsoleMessageErroString();
                return ObterStatusDocumento();
            }
        }
        public static AreaAtuacaoEnum? ObterAreaDeAtuacao()
        {
            var areaAtuacao = Enum.GetValues<AreaAtuacaoEnum>();
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||                Digite a area de atuação               ||");
            foreach (var item in areaAtuacao)
            {
                Console.WriteLine($"||      {(int)item}) -  {item}");
            }
            Console.WriteLine("||-------------------------------------------------------||");
            var usuarioEscolha = Console.ReadLine();
            try
            {
                if ((AreaAtuacaoEnum)(Convert.ToInt32(usuarioEscolha)) == AreaAtuacaoEnum.Agropecuário ||
                (AreaAtuacaoEnum)(Convert.ToInt32(usuarioEscolha)) == AreaAtuacaoEnum.Industrial ||
                (AreaAtuacaoEnum)(Convert.ToInt32(usuarioEscolha)) == AreaAtuacaoEnum.Metalúrgico ||
                (AreaAtuacaoEnum)(Convert.ToInt32(usuarioEscolha)) == AreaAtuacaoEnum.Tecnologia ||
                (AreaAtuacaoEnum)(Convert.ToInt32(usuarioEscolha)) == AreaAtuacaoEnum.Outro)
                {
                    return AreaDeAtuacao = (AreaAtuacaoEnum)(Convert.ToInt32(usuarioEscolha));
                }
                else
                {
                    ConsolesTextoUsuario.ConsoleMessageInvalidNumber();
                    return ObterAreaDeAtuacao();
                }

            }
            catch
            {
                ConsolesTextoUsuario.ConsoleMessageErroString();
                return ObterAreaDeAtuacao();
            }
        }
        public static TipoImpostoEnum? ObterTipoImposto()
        {
            var tipoImposto = Enum.GetValues<TipoImpostoEnum>();
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||      Digite o número que corresponde ao imposto       ||");
            foreach (var item in tipoImposto)
            {
                Console.WriteLine($"||             {(int)item}) -  {item}");
            }
            Console.WriteLine("||-------------------------------------------------------||");
            var usuarioEscolha = Console.ReadLine();
            try
            {
                if ((TipoImpostoEnum)(Convert.ToInt32(usuarioEscolha)) == TipoImpostoEnum.ICMS ||
                (TipoImpostoEnum)(Convert.ToInt32(usuarioEscolha)) == TipoImpostoEnum.IOF ||
                (TipoImpostoEnum)(Convert.ToInt32(usuarioEscolha)) == TipoImpostoEnum.IPI ||
                (TipoImpostoEnum)(Convert.ToInt32(usuarioEscolha)) == TipoImpostoEnum.Outro)
                {
                    return TipoImposto = (TipoImpostoEnum)(Convert.ToInt32(usuarioEscolha));
                }
                else
                {
                    ConsolesTextoUsuario.ConsoleMessageInvalidNumber();
                    return ObterTipoImposto();
                }
            }
            catch
            {
                ConsolesTextoUsuario.ConsoleMessageErroString();
                return ObterTipoImposto();
            }


        }
        public static TipoDocumentoEnum? ObterDocumentoCadastrar()
        {
            var quantidadeMenuCadastrar = Enum.GetValues<TipoDocumentoEnum>();
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||              Digite o tipo de documento               ||");
            Console.WriteLine("||-------------------------------------------------------||");
            foreach (var item in quantidadeMenuCadastrar)
            {
                if (item == TipoDocumentoEnum.NotaFiscal)
                {
                    Console.WriteLine($"||      {(int)item} - Nota fiscal");
                }
                if (item == TipoDocumentoEnum.Contrato)
                {
                    Console.WriteLine($"||      {(int)item} - Contrato");
                }
                if (item == TipoDocumentoEnum.LicencaFunciamento)
                {
                    Console.WriteLine($"||      {(int)item} - Licença de funcionamento");
                }
                if (item == TipoDocumentoEnum.Voltar)
                {
                    Console.WriteLine($"||      {(int)item} - Voltar");
                }
            }
            Console.WriteLine("||-------------------------------------------------------||");
            var usuarioEscolha = Console.ReadLine();
            try
            {
                if ((TipoDocumentoEnum)(Convert.ToInt32(usuarioEscolha)) == TipoDocumentoEnum.Contrato ||
                (TipoDocumentoEnum)(Convert.ToInt32(usuarioEscolha)) == TipoDocumentoEnum.LicencaFunciamento ||
                (TipoDocumentoEnum)(Convert.ToInt32(usuarioEscolha)) == TipoDocumentoEnum.NotaFiscal ||
                (TipoDocumentoEnum)(Convert.ToInt32(usuarioEscolha)) == TipoDocumentoEnum.Voltar)
                {
                    return TipoDeDocumentoCadastrar = (TipoDocumentoEnum)(Convert.ToInt32(usuarioEscolha));
                }
                else
                {
                    ConsolesTextoUsuario.ConsoleMessageInvalidNumber();
                    return ObterDocumentoCadastrar();
                }
            }
            catch
            {
                ConsolesTextoUsuario.ConsoleMessageErroString();
                return ObterDocumentoCadastrar();
            }
        }
        public static OpcoesMenuEnum? ObterResultadoMenuPrincipal()
        {
            var quantidadeMenuCadastrar = Enum.GetValues<OpcoesMenuEnum>();
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||                    MENU PRINCIPAL                     ||");
            Console.WriteLine("||_______________________________________________________||");
            foreach (var opcao in quantidadeMenuCadastrar)
            {
                if (opcao == OpcoesMenuEnum.CadastrarDocumento)
                {
                    Console.WriteLine($"||      {(int)opcao} - Cadastrar Produto");
                }
                if (opcao == OpcoesMenuEnum.ListarDocumento)
                {
                    Console.WriteLine($"||      {(int)opcao} - Listar Documento");
                }
                if (opcao == OpcoesMenuEnum.AlterarItensDocumento)
                {
                    Console.WriteLine($"||      {(int)opcao} - Alterar Itens do Documento");
                }
                if (opcao == OpcoesMenuEnum.AlterarStatusDocumento)
                {
                    Console.WriteLine($"||      {(int)opcao} - Alterar o Status do Documento");
                }
                if (opcao == OpcoesMenuEnum.ListarTodosDocumentos)
                {
                    Console.WriteLine($"||      {(int)opcao} - Listar Todos Documentos");
                }
                if (opcao == OpcoesMenuEnum.Sair)
                {
                    Console.WriteLine($"||      {(int)opcao} - Sair");
                }
            }
            Console.WriteLine("||-------------------------------------------------------||");
            var usuarioEscolha = Console.ReadLine();
            try
            {
                if ((OpcoesMenuEnum)(Convert.ToInt32(usuarioEscolha)) == OpcoesMenuEnum.CadastrarDocumento ||
                (OpcoesMenuEnum)(Convert.ToInt32(usuarioEscolha)) == OpcoesMenuEnum.ListarDocumento ||
                (OpcoesMenuEnum)(Convert.ToInt32(usuarioEscolha)) == OpcoesMenuEnum.AlterarItensDocumento ||
                (OpcoesMenuEnum)(Convert.ToInt32(usuarioEscolha)) == OpcoesMenuEnum.AlterarStatusDocumento ||
                (OpcoesMenuEnum)(Convert.ToInt32(usuarioEscolha)) == OpcoesMenuEnum.ListarTodosDocumentos ||
                (OpcoesMenuEnum)(Convert.ToInt32(usuarioEscolha)) == OpcoesMenuEnum.Sair)
                {
                    return ResultadoMenuPrincipalEscolhaUsuario = (OpcoesMenuEnum)(Convert.ToInt32(usuarioEscolha));
                }
                else
                {
                    ConsolesTextoUsuario.ConsoleMessageInvalidNumber();
                    return ObterResultadoMenuPrincipal();
                }
            }
            catch
            {
                ConsolesTextoUsuario.ConsoleMessageErroString();
                return ObterResultadoMenuPrincipal();
            }
        }

        public static ExibirListasEnum? ObterResultadoListarTodosDocumentos()
        {
            var quantidadeListarTodosDocumentos = Enum.GetValues<ExibirListasEnum>();
            Console.WriteLine("||-------------------------------------------------------||");
            Console.WriteLine("||                LISTAR DOCUMENTOS                      ||");
            Console.WriteLine("||_______________________________________________________||");
            foreach (var opcao in quantidadeListarTodosDocumentos)
            {
                if (opcao == ExibirListasEnum.ListarTodosDocumentos)
                {
                    Console.WriteLine($"||      {(int)opcao} - Listar todos os documentos");
                }
                if (opcao == ExibirListasEnum.ListarPorStatusDoDocumento)
                {
                    Console.WriteLine($"||      {(int)opcao} - Listar por  status do documento");
                }
                if (opcao == ExibirListasEnum.ListarPorTipoDeDocumento)
                {
                    Console.WriteLine($"||      {(int)opcao} - Listar por tipo de documento");
                }
                if (opcao == ExibirListasEnum.NumeroTotalDeDocumentos)
                {
                    Console.WriteLine($"||      {(int)opcao} - Mostrar número total de documentos");
                }
                if (opcao == ExibirListasEnum.Voltar)
                {
                    Console.WriteLine($"||      {(int)opcao} - Voltar");
                }
            }
            Console.WriteLine("||-------------------------------------------------------||");
            var usuarioEscolha = Console.ReadLine();
            try
            {
                if ((ExibirListasEnum)(Convert.ToInt32(usuarioEscolha)) == ExibirListasEnum.ListarPorStatusDoDocumento ||
                (ExibirListasEnum)(Convert.ToInt32(usuarioEscolha)) == ExibirListasEnum.ListarPorTipoDeDocumento ||
                (ExibirListasEnum)(Convert.ToInt32(usuarioEscolha)) == ExibirListasEnum.ListarTodosDocumentos ||
                (ExibirListasEnum)(Convert.ToInt32(usuarioEscolha)) == ExibirListasEnum.NumeroTotalDeDocumentos ||
                (ExibirListasEnum)(Convert.ToInt32(usuarioEscolha)) == ExibirListasEnum.Voltar)
                {
                    return ListarTodosDocumentos = (ExibirListasEnum)(Convert.ToInt32(usuarioEscolha));
                }
                else
                {
                    ConsolesTextoUsuario.ConsoleMessageInvalidNumber();
                    return ObterResultadoListarTodosDocumentos();
                }
            }
            catch
            {
                ConsolesTextoUsuario.ConsoleMessageErroString();
                return ObterResultadoListarTodosDocumentos();
            }
        }
    }

}