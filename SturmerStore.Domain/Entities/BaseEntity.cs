using System;
using System.Collections.Generic;
using System.Text;

namespace SturmerStore.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
