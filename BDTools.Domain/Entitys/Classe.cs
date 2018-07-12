using System;
using System.Collections.Generic;
using System.Text;

namespace BDTools.Domain.Entitys
{
    public class Classe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<Item> Itens { get; set; }
    }
}
