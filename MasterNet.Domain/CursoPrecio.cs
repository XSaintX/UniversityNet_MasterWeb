﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNet.Domain
{
    public class CursoPrecio
    {
        public Guid? CursoId { get; set; }
        public Curso? Curso { get; set; }
        public Guid? PrecioId { get; set; }
        public Precio? Precio { get; set; }
    }
}
