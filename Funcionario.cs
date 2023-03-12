using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEVinDocuments
{
    public class Funcionario
    {
        private int codigo;
        private string nome;
        private string endereco;
        private DateTime dataNascimento;
        private string filiacao;
        private DateTime dataAdmissao;

        public Funcionario(int codigo, string nome, string endereco, DateTime dataNascimento, string filiacao, DateTime dataAdmissao)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.endereco = endereco;
            this.dataNascimento = dataNascimento;
            this.filiacao = filiacao;
            this.dataAdmissao = dataAdmissao;
        }
        public int Codigo
        {
            get { return this.codigo; }
        }
    }
}