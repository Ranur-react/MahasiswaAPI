using MahasiswaAPI.Context;
using MahasiswaAPI.Models;
using MahasiswaAPI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahasiswaAPI.Repository
{

    public class MahasiswaRepository : IMahasiswaRepository
    {
        private readonly MyContext myContext;
        public MahasiswaRepository(MyContext myContext) {
            this.myContext = myContext;
        }
        public int Delete(string Nobp)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Mahasiswa> Get()
        {
            return myContext.mahasiswas.ToList();
        }

        public Mahasiswa Get(string Nobp)
        {
            throw new NotImplementedException();
        }

        public int Insert(Mahasiswa mahasiswa)
        {
            throw new NotImplementedException();
        }

        public int Update(Mahasiswa mahasiswa)
        {
            throw new NotImplementedException();
        }
    }
}
