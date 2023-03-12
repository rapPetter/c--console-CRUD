using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVinDocuments
{
    public class DevInDocuments
    {
        private int codigoDocumento;
        private string nomeEstabelecimento;
        private string cnpj;
        private DateTime dataCadastro;
        private DateTime? dataAlteracao;
        private StatusDocumentoEnum statusDocumento;
        private int idFuncionario;

        Random gerarCodigoDocumento = new Random();

        public DevInDocuments(string nomeEstabelecimento, string cnpj, DateTime dataCadastro, DateTime? dataAlteracao, StatusDocumentoEnum statusDocumento, int idFuncionario)
        {
            int gera = gerarCodigoDocumento.Next();
            this.codigoDocumento = gera;
            this.nomeEstabelecimento = nomeEstabelecimento;
            this.cnpj = cnpj;
            this.dataCadastro = dataCadastro;
            this.dataAlteracao = dataAlteracao;
            this.statusDocumento = statusDocumento;
            this.idFuncionario = idFuncionario;
        }
        public DevInDocuments()
        {
        }

        public int CodigoDocumento
        {
            get { return this.codigoDocumento; }
            set { this.codigoDocumento = value; }
        }
        public string NomeEstabelecimento
        {
            get { return this.nomeEstabelecimento; }
            set { this.nomeEstabelecimento = value; }
        }
        public string Cnpj
        {
            get { return this.cnpj; }
            set { this.cnpj = value; }
        }
        public DateTime DataCadastro
        {
            get { return this.dataCadastro; }
            set { this.dataCadastro = value; }
        }
        public DateTime? DataAlteracao
        {
            set { this.dataAlteracao = value; }
            get { return this.dataAlteracao; }

        }
        public StatusDocumentoEnum StatusDocumento
        {
            get { return this.statusDocumento; }
            set { this.statusDocumento = value; }
        }
        public int IdFuncionario
        {
            get { return this.idFuncionario; }
            set { this.idFuncionario = value; }
        }

        public virtual void CadastrarDocumento(DevInDocuments devindocuments)
        {
        }

        public void listarDocumento(DevInDocuments devindocuments)
        {
        }

        public void AlterarItensDocumento(DevInDocuments devindocuments)
        {

        }
        public void AlterarStatusDocumento(DevInDocuments devindocuments)
        {

        }
    }
}