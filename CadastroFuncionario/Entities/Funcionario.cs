using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario.Entities
{
    public class Funcionario
    {

        private Guid? _idFuncionario;
        private string? _nome;
        private string? _cpf;
        private string? _matricula;
        private string? _cargo;
        private decimal? _salario;
        private DateTime? _dataAdimissao;

        public Guid? IdFuncionario
        {
            set { _idFuncionario = value; }
            get { return _idFuncionario; }
        }

        public string? Nome
        {
            set { _nome = value; }
            get { return _nome; }
        }

        public string? Cpf
        {
            set { _cpf = value; }
            get { return _cpf; }
        }

        public string? Matricula
        {
            set { _matricula = value; }
            get { return _matricula; }
        }

        public string? Cargo
        {
            set { _cargo = value; }
            get { return _cargo; }
        }

        public decimal? Salario
        {
            set { _salario = value; }
            get { return _salario; }
        }

        public DateTime? DataAdimissao
        {
            set { _dataAdimissao = value; }
            get { return _dataAdimissao; }
        }


    }
}
