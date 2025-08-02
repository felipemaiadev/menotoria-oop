using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIA.OOP
{
    public class Cliente : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public Cliente(string categoria) : base(categoria)
        {
        }


        public override string ToString()
        {

            return this.Nome;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            var other = obj as Cliente;
            return other.Id == this.Id;
        }

    }
}
