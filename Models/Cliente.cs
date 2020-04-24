using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAvanadeCliente.Models
{
    public class Cliente
    {
        private static DBContexto _db = new DBContexto();
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Agencia { get; set; }

        public int ContaCorrente { get; set; }
        public int Senha { get; set; }


        public static DbSet<Cliente> Busca()
        {
            return _db.Clientes;
        }

        

        public bool Salvar()
        {
            try
            {
                _db.Clientes.Add(this);
                _db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }

        public static  List<Cliente> Lista()
        {
            return _db.Clientes.ToList();
        }
    }
}

    
