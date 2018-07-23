using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ITS.Prova.Data.Context;
using ITS.Prova.Data.Interfaces;
using ITS.Prova.Domain.Funcionario;

namespace ITS.Prova.Data.Repository
{
    public class FuncionarioFeriasRepository : IFuncionarioFeriasRepository
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
        public FuncionarioFerias GetById(int funcionarioId)
        {
            return _context.FuncionarioFerias.FirstOrDefault(x => x.FuncionarioId == funcionarioId);
        }

        public IEnumerable<FuncionarioFerias> GetAll()
        {
            return _context.FuncionarioFerias.ToList();
        }

        //public void Dispose()
        //{
        //    GC.SuppressFinalize(this);
        //}
    }
}
