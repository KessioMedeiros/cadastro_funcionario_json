using CadastroFuncionario.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CadastroFuncionario.Repositories
{
    public class FuncionarioRepository
    {
        public void Exportar(Funcionario funcionario)
        {

            var json = JsonConvert.SerializeObject(funcionario, Newtonsoft.Json.Formatting.Indented);
            var streamWriter = new StreamWriter("c:\\temp\\funcionario.json", true);
            streamWriter.Write(json);
            streamWriter.Close();

        }

    }
}
