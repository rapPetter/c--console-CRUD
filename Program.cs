using DEVinDocuments;
using DEVinDocuments.Menu;

Funcionario funcionario = new Funcionario(01, "Rafael S", "Rua do arvoredo", new DateTime(1993, 01, 27), "Angela Cristina", new DateTime(2022, 06, 12));

bool StatusMenuPrincipal = true;
bool StatusMenuDocumento = true;
bool MenuListar = true;
bool ListarDocumentoTipo = true;

NotaFiscal notafiscal = new NotaFiscal();
notafiscal.ListNotaFiscal = new List<NotaFiscal>();

Contrato contrato = new Contrato();
contrato.ListContrato = new List<Contrato>();

LicencaFuncionamento licencafuncionamento = new LicencaFuncionamento();
licencafuncionamento.ListLicencaFuncionamento = new List<LicencaFuncionamento>();

void Menu()
{
    StatusMenuPrincipal = true;
    while (StatusMenuPrincipal)
    {
        Console.Clear();
        var opcaoSelecionada = Opcoes.ObterResultadoMenuPrincipal();

        switch (opcaoSelecionada)
        {
            case OpcoesMenuEnum.CadastrarDocumento:
                StatusMenuDocumento = true;
                AdicionarProduto();

                break;

            case OpcoesMenuEnum.AlterarItensDocumento:
                AlterarLista();
                StatusMenuPrincipal = false;
                break;

            case OpcoesMenuEnum.ListarDocumento:
                ListarTodosDocumentos();
                StatusMenuPrincipal = false;
                break;

            case OpcoesMenuEnum.AlterarStatusDocumento:
                AlterarStatusDocumento();
                StatusMenuPrincipal = false;
                break;
            case OpcoesMenuEnum.ListarTodosDocumentos:
                ListarTodosDocumentos();

                break;

            case OpcoesMenuEnum.Sair:
                StatusMenuPrincipal = false;
                break;
            case null:
                break;
        }
    }
}

void AdicionarProduto()
{
    while (StatusMenuDocumento)
    {
        Console.Clear();
        var opcaoSelecionadaUsuario = Opcoes.ObterDocumentoCadastrar();
        switch (opcaoSelecionadaUsuario)
        {
            case TipoDocumentoEnum.NotaFiscal:
                Console.Clear();
                ConsolesTextoUsuario.ConsoleWriteLineCadastrarNotaFiscal();
                ConsolesTextoUsuario.ConsoleWriteLineNomeDoEstabelecimento();
                string NomeEstabelecimento = Console.ReadLine();
                ConsolesTextoUsuario.ConsoleWriteLineCnpj();
                string Cnpj = Console.ReadLine();
                Opcoes.ObterStatusDocumento();
                ConsolesTextoUsuario.ConsoleWriteLineNomeDoProdutoVendido();
                string NomeProduto = Console.ReadLine();
                decimal ValorTotal = EntradaDecimal.EntradaConverterParaDecimalValorTotal();
                Opcoes.ObterTipoImposto();
                decimal ValorTotalImposto = EntradaDecimal.EntradaConverterParaDecimalValorTotalDoImposto();
                NotaFiscal notafiscal1 = new NotaFiscal(nomeEstabelecimento: NomeEstabelecimento, cnpj: Cnpj, dataCadastro: DateTime.Now, dataAlteracao: null,
                statusDocumento: Opcoes.statusDoDocumento, idFuncionario: funcionario.Codigo, nomeProduto: NomeProduto, valorTotal: ValorTotal, tipo: Opcoes.TipoImposto, valorTotalImposto: ValorTotalImposto);
                notafiscal.CadastrarDocumentoNFE(notafiscal1);
                ConsolesTextoUsuario.ConsoleWriteLineCadastradoComSucesso();
                ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
                Console.ReadKey();
                StatusMenuDocumento = false;
                break;

            case TipoDocumentoEnum.LicencaFunciamento:
                Console.Clear();
                ConsolesTextoUsuario.ConsoleWriteLineCadastrarLicencaDeFuncionamento();
                ConsolesTextoUsuario.ConsoleWriteLineNomeDoEstabelecimento();
                licencafuncionamento.NomeEstabelecimento = Console.ReadLine();
                ConsolesTextoUsuario.ConsoleWriteLineCnpj();
                licencafuncionamento.Cnpj = Console.ReadLine();
                Opcoes.ObterStatusDocumento();
                Opcoes.ObterAreaDeAtuacao();
                ConsolesTextoUsuario.ConsoleWriteLineEndereco();
                licencafuncionamento.Endereco = Console.ReadLine();
                LicencaFuncionamento licencafuncionamento1 = new LicencaFuncionamento(nomeEstabelecimento: licencafuncionamento.NomeEstabelecimento, cnpj: licencafuncionamento.Cnpj, dataCadastro: DateTime.Now, dataAlteracao: null,
                statusDocumento: Opcoes.statusDoDocumento, idFuncionario: funcionario.Codigo, areaAtuacao: Opcoes.AreaDeAtuacao, endereco: licencafuncionamento.Endereco);
                licencafuncionamento.CadastrarDocumento(licencafuncionamento1);
                ConsolesTextoUsuario.ConsoleWriteLineCadastradoComSucesso();
                ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
                Console.ReadKey();
                StatusMenuDocumento = false;
                break;

            case TipoDocumentoEnum.Contrato:
                Console.Clear();
                ConsolesTextoUsuario.ConsoleWriteLineCadastrarContrato();
                ConsolesTextoUsuario.ConsoleWriteLineNomeDoEstabelecimento();
                string NomeEstabelecimento1 = Console.ReadLine();
                ConsolesTextoUsuario.ConsoleWriteLineCnpj();
                string Cnpj1 = Console.ReadLine();
                Opcoes.ObterStatusDocumento();
                ConsolesTextoUsuario.ConsoleWriteLineFinalidade();
                string Finalidade = Console.ReadLine();
                ConsolesTextoUsuario.ConsoleWriteLinePrimeiraTestemunha();
                string PrimeiraTestemunha = Console.ReadLine();
                ConsolesTextoUsuario.ConsoleWriteLineSegundaTestemunha();
                string SegundaTestemunha = Console.ReadLine();
                DateTime DataExpiracao = EntradaData.PegarData();
                Contrato contrato1 = new Contrato(nomeEstabelecimento: NomeEstabelecimento1, cnpj: Cnpj1, dataCadastro: DateTime.Now, dataAlteracao: null,
                statusDocumento: Opcoes.statusDoDocumento, idFuncionario: funcionario.Codigo, finalidade: Finalidade, primeiraTestemunha: PrimeiraTestemunha, segundaTestemunha: SegundaTestemunha, dataExpiracao: DataExpiracao);
                contrato.CadastrarDocumento(contrato1);
                ConsolesTextoUsuario.ConsoleWriteLineCadastradoComSucesso();
                ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
                Console.ReadKey();
                StatusMenuDocumento = false;
                break;
            case TipoDocumentoEnum.Voltar:
                StatusMenuDocumento = false;
                Menu();
                break;
        }
    }
}

void AlterarLista()
{
    try
    {
        ConsolesTextoUsuario.ConsoleWriteLineCodigoAlterarItensDocumento();
        int escolhaUsuario = int.Parse(Console.ReadLine());

        if (notafiscal.ListNotaFiscal.Exists(x => x.CodigoDocumento == escolhaUsuario) ||
        contrato.ListContrato.Exists(x => x.CodigoDocumento == escolhaUsuario) ||
        licencafuncionamento.ListLicencaFuncionamento.Exists(x => x.CodigoDocumento == escolhaUsuario))
        {
            foreach (NotaFiscal item in notafiscal.ListNotaFiscal)
            {
                if (escolhaUsuario == item.CodigoDocumento)
                {
                    ConsolesTextoUsuario.ConsoleWriteLineAlterarItensDocumento();
                    ConsolesTextoUsuario.ConsoleWriteLineNomeDoEstabelecimento();
                    item.NomeEstabelecimento = Console.ReadLine();
                    ConsolesTextoUsuario.ConsoleWriteLineCnpj();
                    item.Cnpj = Console.ReadLine();
                    item.DataAlteracao = DateTime.Now;
                    Opcoes.ObterStatusDocumento();
                    item.StatusDocumento = Opcoes.statusDoDocumento;
                    ConsolesTextoUsuario.ConsoleWriteLineNomeDoProdutoVendido();
                    item.NomeProduto = Console.ReadLine();
                    item.ValorTotal = EntradaDecimal.EntradaConverterParaDecimalValorTotal(); ;
                    Opcoes.ObterTipoImposto();
                    item.Tipo = Opcoes.TipoImposto;
                    item.ValorTotalImposto = EntradaDecimal.EntradaConverterParaDecimalValorTotalDoImposto();
                    ConsolesTextoUsuario.ConsoleWriteLineAlteradoComSucesso();
                    ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
                    Console.ReadKey();
                    Menu();
                    break;
                };
            }
            foreach (Contrato item in contrato.ListContrato)
            {
                if (escolhaUsuario == item.CodigoDocumento)
                {
                    ConsolesTextoUsuario.ConsoleWriteLineAlterarItensDocumento();
                    ConsolesTextoUsuario.ConsoleWriteLineNomeDoEstabelecimento();
                    item.NomeEstabelecimento = Console.ReadLine();
                    ConsolesTextoUsuario.ConsoleWriteLineCnpj();
                    item.Cnpj = Console.ReadLine();
                    item.DataAlteracao = DateTime.Now;
                    Opcoes.ObterStatusDocumento();
                    item.StatusDocumento = Opcoes.statusDoDocumento;
                    ConsolesTextoUsuario.ConsoleWriteLineFinalidade();
                    item.Finalidade = Console.ReadLine();
                    ConsolesTextoUsuario.ConsoleWriteLinePrimeiraTestemunha();
                    item.PrimeiraTestemunha = Console.ReadLine();
                    ConsolesTextoUsuario.ConsoleWriteLineSegundaTestemunha();
                    item.SegundaTestemunha = Console.ReadLine();
                    DateTime DataExpiracao = EntradaData.PegarData();
                    ConsolesTextoUsuario.ConsoleWriteLineAlteradoComSucesso();
                    ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
                    Console.ReadKey();
                    Menu();
                    break;
                };
            }
            foreach (LicencaFuncionamento item in licencafuncionamento.ListLicencaFuncionamento)
            {
                if (escolhaUsuario == item.CodigoDocumento)
                {
                    ConsolesTextoUsuario.ConsoleWriteLineAlterarItensDocumento();
                    ConsolesTextoUsuario.ConsoleWriteLineNomeDoEstabelecimento();
                    item.NomeEstabelecimento = Console.ReadLine();
                    ConsolesTextoUsuario.ConsoleWriteLineCnpj();
                    item.Cnpj = Console.ReadLine();
                    item.DataAlteracao = DateTime.Now;
                    Opcoes.ObterStatusDocumento();
                    item.StatusDocumento = Opcoes.statusDoDocumento;

                    Opcoes.ObterAreaDeAtuacao();
                    item.AreaAtuacao = Opcoes.AreaDeAtuacao;
                    ConsolesTextoUsuario.ConsoleWriteLineEndereco();
                    item.Endereco = Console.ReadLine();
                    ConsolesTextoUsuario.ConsoleWriteLineAlteradoComSucesso();
                    ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
                    Console.ReadKey();
                    Menu();
                    break;
                };
            }
        }
        else
        {
            ConsolesTextoUsuario.ConsoleWriteLineCodigoNaoEncontrado();
            ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
            Console.ReadKey();
            Menu();
        }
    }
    catch
    {
        ConsolesTextoUsuario.ConsoleWriteLineCodigoNaoEncontrado();
        ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
        Console.ReadKey();
        Menu();
    }
}

void ListarDocumentoPorStatus()
{
    Console.Clear();
    ConsolesTextoUsuario.ConsoleWriteLineListarStatusDocumento();
    Opcoes.ObterStatusDocumento();

    if (notafiscal.ListNotaFiscal.Exists(x => x.StatusDocumento == Opcoes.statusDoDocumento) || contrato.ListContrato.Exists(x => x.StatusDocumento == Opcoes.statusDoDocumento)
    || licencafuncionamento.ListLicencaFuncionamento.Exists(x => x.StatusDocumento == Opcoes.statusDoDocumento))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("||________________________________________________________________________________________________________________________________________________________||");
        Console.WriteLine("||                                                                                                                                                        ||");
        Console.WriteLine($"                                                               Documentos listados por status : {Opcoes.statusDoDocumento}");
        Console.WriteLine("||                                                                                                                                                        ||");
        Console.WriteLine("||________________________________________________________________________________________________________________________________________________________||");
        Console.ResetColor();
        foreach (NotaFiscal item in notafiscal.ListNotaFiscal)
        {
            if (Opcoes.statusDoDocumento == item.StatusDocumento)
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
        foreach (Contrato item in contrato.ListContrato)
        {
            if (Opcoes.statusDoDocumento == item.StatusDocumento)
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
        foreach (LicencaFuncionamento item in licencafuncionamento.ListLicencaFuncionamento)
        {
            if (Opcoes.statusDoDocumento == item.StatusDocumento)
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

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("||                                                                                                                                                        ||");
        Console.WriteLine("||________________________________________________________________________________________________________________________________________________________||");
        Console.ResetColor();
        ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
        Console.ReadKey();
        Menu();
    }
    else
    {
        ConsolesTextoUsuario.ConsoleMessageErroDocumentoStatusNaoEncontrado();
        ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
        Console.ReadKey();
        ListarTodosDocumentos();
    }

}

void AlterarStatusDocumento()
{
    try
    {
        ConsolesTextoUsuario.ConsoleWriteLineCodigoAlterarItensDocumento();
        int escolhaUsuario = int.Parse(Console.ReadLine());
        if (notafiscal.ListNotaFiscal.Exists(x => x.CodigoDocumento == escolhaUsuario) || contrato.ListContrato.Exists(x => x.CodigoDocumento == escolhaUsuario)
       || licencafuncionamento.ListLicencaFuncionamento.Exists(x => x.CodigoDocumento == escolhaUsuario))
        {
            foreach (NotaFiscal item in notafiscal.ListNotaFiscal)
            {
                if (escolhaUsuario == item.CodigoDocumento)
                {
                    ConsolesTextoUsuario.ConsoleWriteLineAlterarStatusDoDocumento();
                    Opcoes.ObterStatusDocumento();
                    item.StatusDocumento = Opcoes.statusDoDocumento;
                    item.DataAlteracao = DateTime.Now;
                    ConsolesTextoUsuario.ConsoleWriteLineStatusAlteradoComSucesso();
                    ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
                    Console.ReadKey();
                    Menu();
                    break;
                };
            }
            foreach (Contrato item in contrato.ListContrato)
            {
                if (escolhaUsuario == item.CodigoDocumento)
                {
                    ConsolesTextoUsuario.ConsoleWriteLineAlterarStatusDoDocumento();
                    Opcoes.ObterStatusDocumento();
                    item.StatusDocumento = Opcoes.statusDoDocumento;
                    item.DataAlteracao = DateTime.Now;
                    ConsolesTextoUsuario.ConsoleWriteLineStatusAlteradoComSucesso();
                    ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
                    Console.ReadKey();
                    Menu();
                    break;
                };
            }
            foreach (LicencaFuncionamento item in licencafuncionamento.ListLicencaFuncionamento)
            {
                if (escolhaUsuario == item.CodigoDocumento)
                {
                    ConsolesTextoUsuario.ConsoleWriteLineAlterarStatusDoDocumento();
                    Opcoes.ObterStatusDocumento();
                    item.StatusDocumento = Opcoes.statusDoDocumento;
                    item.DataAlteracao = DateTime.Now;
                    ConsolesTextoUsuario.ConsoleWriteLineStatusAlteradoComSucesso();
                    ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
                    Console.ReadKey();
                    Menu();
                    break;
                };
            }
        }
        else
        {
            ConsolesTextoUsuario.ConsoleWriteLineCodigoNaoEncontrado();
            ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
            Console.ReadKey();
            Menu();
        }
    }
    catch
    {
        ConsolesTextoUsuario.ConsoleWriteLineCodigoNaoEncontrado();
        ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
        Console.ReadKey();
        Menu();
    }
}
void ListarTodosDocumentos()
{
    MenuListar = true;
    Console.Clear();
    while (MenuListar)
    {
        var opcaoSelecionada = Opcoes.ObterResultadoListarTodosDocumentos();

        switch (opcaoSelecionada)
        {
            case ExibirListasEnum.ListarTodosDocumentos:
                notafiscal.listarDocumento(notafiscal);
                licencafuncionamento.listarDocumento(licencafuncionamento);
                contrato.listarDocumento(contrato);
                ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
                Console.ReadKey();
                MenuListar = false;
                Menu();
                break;

            case ExibirListasEnum.ListarPorStatusDoDocumento:
                ListarDocumentoPorStatus();
                MenuListar = false;
                break;

            case ExibirListasEnum.ListarPorTipoDeDocumento:
                ListarDocumentoPorTipo();
                MenuListar = false;
                break;

            case ExibirListasEnum.NumeroTotalDeDocumentos:
                QuantidadeTotalDeDocumentos();
                MenuListar = false;
                Menu();
                break;
            case ExibirListasEnum.Voltar:
                MenuListar = false;
                Menu();
                break;

            case null:
                break;
        }
    }
}
void ListarDocumentoPorTipo()
{
    ListarDocumentoTipo = true;
    while (ListarDocumentoTipo)
    {
        Console.Clear();
        Console.WriteLine("||-------------------------------------------------------||");
        Console.WriteLine("||         Escolha qual tipo de documento listar         ||");
        var opcaoSelecionadaUsuario = Opcoes.ObterDocumentoCadastrar();
        switch (opcaoSelecionadaUsuario)
        {
            case TipoDocumentoEnum.NotaFiscal:
                notafiscal.listarDocumento(notafiscal);
                ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
                Console.ReadKey();
                Menu();
                ListarDocumentoTipo = false;
                break;

            case TipoDocumentoEnum.LicencaFunciamento:
                licencafuncionamento.listarDocumento(licencafuncionamento);
                ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
                Console.ReadKey();
                Menu();
                ListarDocumentoTipo = false;
                break;

            case TipoDocumentoEnum.Contrato:
                contrato.listarDocumento(contrato);
                ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
                Console.ReadKey();
                Menu();
                ListarDocumentoTipo = false;
                break;

            case TipoDocumentoEnum.Voltar:
                ListarDocumentoTipo = false;
                ListarTodosDocumentos();
                break;
        }
    }
}
void QuantidadeTotalDeDocumentos()
{
    int soma = contrato.ListContrato.Count + licencafuncionamento.ListLicencaFuncionamento.Count + notafiscal.ListNotaFiscal.Count;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("||__________________________________________________________________________________________________________________________________________________________________||");
    Console.WriteLine("||                                                                                                                                                                  ||");
    Console.WriteLine("||*************************************************************** TOTAL DE DOCUMENTOS ******************************************************************************||");
    Console.WriteLine("||                                                                                                                                                                  ||");
    Console.WriteLine("||__________________________________________________________________________________________________________________________________________________________________||");
    Console.ResetColor();
    Console.WriteLine("||           _______________________________________________________________________________________________________________________________________________________||");
    Console.WriteLine($"||          | Tem um total de {notafiscal.ListNotaFiscal.Count} Notas Fiscais armazenadas.");
    Console.WriteLine("||          |                                                                                                                                                       ");
    Console.WriteLine($"||          | Tem um total de {licencafuncionamento.ListLicencaFuncionamento.Count} licenças de funcionamento armazenadas.                                          ");
    Console.WriteLine("||          |                                                                                                                                                       ");
    Console.WriteLine($"||          | Tem um total de {contrato.ListContrato.Count} contratos armazenados.                                                                                  ");
    Console.WriteLine("||          |                                                                                                                                                       ");
    Console.WriteLine("||          |                                                                                                                                                        ");
    Console.WriteLine($"||          |Contabilizando um total de {soma} documentos armazenados.                                                                                              ");
    Console.WriteLine("||          |________________________________________________________________________________________________________________________________________________________||");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("||___________________________________________________________________________________________________________________________________________________________________||");
    Console.ResetColor();
    ConsolesTextoUsuario.ConsoleWriteLineDigiteQualquerTecla();
    Console.ReadKey();
}

Menu();

