using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ITS.Prova.Domain.Funcionario;
using ITSProva.Data.Context;
using ITSProva.Data.Interfaces;

namespace ITSProva.Data.Repository
{
    public class FuncionarioFeriasRepository : IFuncionarioFeriasRepository, IDisposable
    {
        private readonly ProvaContext _context;

        public FuncionarioFeriasRepository(ProvaContext context)
        {
            _context = context;
        }

        public void Add(FuncionarioFerias funcionarioFerias)
        {
            _context.FuncionarioFerias.Add(funcionarioFerias);
        }

        public void Update(FuncionarioFerias funcionarioFerias)
        {
            _context.FuncionarioFerias.AddOrUpdate(funcionarioFerias);
        }

        public void Delete(FuncionarioFerias funcionarioFerias)
        {
            _context.FuncionarioFerias.Remove(funcionarioFerias);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        public FuncionarioFerias GetById(int feriasId)
        {
            return _context.FuncionarioFerias.FirstOrDefault(x => x.FeriasId == feriasId);
        }

        public IEnumerable<FuncionarioFerias> GetAll()
        {
            return _context.FuncionarioFerias.Include("Funcionario").ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
