using MahasiswaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahasiswaAPI.Repository.Interface
{
    interface IMahasiswaRepository
    {
        IEnumerable<Mahasiswa> Get();
        Mahasiswa Get(String Nobp);
        int Insert(Mahasiswa mahasiswa);
        int Update(Mahasiswa mahasiswa);
        int Delete(String Nobp);
    }
}
