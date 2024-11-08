using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNet.Domain
{
    public class Precio
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public decimal PrecioActual { get; set; }
        public decimal PrecioPromocion { get; set; }
        public ICollection<Curso>? Cursos { get; set; }
        public ICollection<CursoPrecio>? CursoPrecios { get; set; }
        //public ICollection<Precio>? Precios { get; set; }
    }
}
