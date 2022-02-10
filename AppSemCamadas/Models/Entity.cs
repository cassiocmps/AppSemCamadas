using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSemCamadas.Models
{
    public abstract class Entity
    {
        // toda classe herdeira tera um Id
        public Guid Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
