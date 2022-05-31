using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHR.Application.Dtos.Contas
{
    public class ContaVisaoDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string NomeCompleto { get; set; }
        public string Funcao { get; set; }
        public string Visao { get; set; }
        public string Descricao { get; set; }
        public string ImagemURL { get; set; }
    }
}