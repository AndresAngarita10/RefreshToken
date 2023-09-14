using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class RolRepository : GenericRepository<Rol>, IRolRepository
    {
    private readonly TokensContext _context;

    public RolRepository(TokensContext context) : base(context)
    {
       _context = context;
    }
    }
}