using MasterNet.Domain;
using MasterNet.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MasterNet.Application.Cursos.CursoCreate.CursoCreateCommand;

namespace MasterNet.Application.Cursos.CursoCreate
{
    public class CursoCreateCommand
    {
        public record CursoCreateCommandRequest(CursoCreateRequest cursoCreateRequest) : IRequest<Guid>;

        internal class CursoCreateCommandHandler : IRequestHandler<CursoCreateCommandRequest, Guid>
        {
            private readonly MasterNetDbContext _context;

            public CursoCreateCommandHandler(MasterNetDbContext context)
            {
                _context = context;
            }

            public async Task<Guid> Handle(CursoCreateCommandRequest request, CancellationToken cancellationToken)
            {
                var curso = new Curso
                {
                    Id = Guid.NewGuid(),
                    Titulo = request.cursoCreateRequest.Titulo,//"Curso de udemy",
                    Descripcion = request.cursoCreateRequest.Descripcion, //"Curso avanzado de programacion",
                    FechaPublicacion = request.cursoCreateRequest.FechaPublicacion //DateTime.Now
                };
                _context.Add(curso);
                await _context.SaveChangesAsync(cancellationToken);
                return curso.Id;

            }
        }
    }
}
