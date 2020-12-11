﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appcsharp.Classes;

namespace appcsharp.Classes
{
    public class Nome
    { //Metodo Construtor
        public Nome(int id=0, string nome=null, string email=null, string telefone=null, string empresa=null, bool ativo=false)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.empresa = empresa;
        }
        //Propriedades
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string empresa { get; set; }
    }
    public List<Nome> ListNome()
    {
        List<Nome> lista = new List<Nome>();
        var cmd = Banco.Abrir();
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.CommandText = "Select * from Alunos";
        var dr = cmd.BeginExecuteReader();
        return lista;

    }
}
