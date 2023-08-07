using Assignment.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Core.Repository
{
    public interface IStudentRepo
    {
        bool AddStudent(Student student);
        bool UpdateStudent(Student student);
        bool DeleteStudent(string id);
        Student GetStudentById(string id);
        DataTable GetAllStudent();
        bool AddGrade(Grade grade);
        bool UpdateGrade(Grade grade);
        bool DeleteGrade(int id);
        Grade GetGradeById(int id);
        DataTable GetAllGrade();
        DataTable GetTop3Grade(DataTable data);
        DataRow GetGradeByStudentId(string MaSV);
    }
}
