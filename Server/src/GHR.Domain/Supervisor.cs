using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHR.Domain
{
    public class Supervisor
    {
        public int Id { get; set; }
        public int? MetaId { get; set; }
        public int FuncionarioId { get; set; }
        public int DepartamentoId { get; set; }
        public DateTime? DataPromocao { get; set; }
        public string UltimoCargo { get; set; }
    }
}