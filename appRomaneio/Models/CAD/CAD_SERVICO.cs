﻿namespace Models.Cadastros
{
    using Infra.Base.Interface;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CAD_SERVICO: IEntidadeBase
    {
        [Key]
        [Column("COD_CADSERVICO")]
        public int id { get; set; }
        public string NOME { get; set; }
    }
}
