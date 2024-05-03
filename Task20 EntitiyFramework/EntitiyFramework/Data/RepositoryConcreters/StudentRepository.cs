using Core.Models;
using Core.RepostoryAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConcreters
{
    public class StudentRepository:GenericRepository<Student>,IStudentRepository
    {

    }
}
