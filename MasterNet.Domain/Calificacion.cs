using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNet.Domain
{
    public class Calificacion:BaseEntity
    {
        public string? Alumno { get; set; }
        public int Puntaje { get; set; }
        public string? Comentario { get; set; }
        public Guid? CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}
