using Assignment.Core.Context;
using Assignment.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Core.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentDbContext context;
        public StudentRepo(StudentDbContext context)
        {
            this.context = context;
        }
        public bool AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return true;
        }
        public bool UpdateStudent(Student student)
        {
            var eStudent = context.Students.FirstOrDefault(s => s.MaSV == student.MaSV);
            if (eStudent != null)
            {
                eStudent.HoTen = student.HoTen;
                eStudent.Email = student.Email;
                eStudent.SoDT = student.SoDT;
                eStudent.GioiTinh = student.GioiTinh;
                eStudent.DiaChi = student.DiaChi;
                eStudent.Hinh = student.Hinh;
                context.Attach(eStudent);
                context.Entry(eStudent).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteStudent(string id)
        {
            var eStudent = context.Students.Find(id);
            if (eStudent != null)
            {
                context.Students.Remove(eStudent);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public Student GetStudentById(string id)
        {
            var student = context.Students.Find(id);
            return student;
        }
        public DataTable GetAllStudent()
        {
            var students = context.Students.ToList();
            var data = new DataTable();
            data.Columns.Add("Mã SV", typeof(string));
            data.Columns.Add("Họ Tên", typeof(string));
            data.Columns.Add("Email", typeof(string));
            data.Columns.Add("Số điện thoại", typeof(string));
            data.Columns.Add("Giới tính", typeof(bool));
            data.Columns.Add("Địa Chỉ", typeof(string));
            data.Columns.Add("Hình", typeof(byte[]));
            foreach (var s in students)
            {
                data.Rows.Add(s.MaSV, s.HoTen, s.Email, s.SoDT, s.GioiTinh, s.DiaChi, s.Hinh);
            }
            return data;
        }
        public bool AddGrade(Grade grade)
        {
            try
            {
                context.Grades.Add(grade);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateGrade(Grade grade)
        {
            var eGrade = context.Grades.FirstOrDefault(g => g.Id == grade.Id);
            if (eGrade != null)
            {
                eGrade.TiengAnh = grade.TiengAnh;
                eGrade.TinHoc = grade.TinHoc;
                eGrade.GDTC = grade.GDTC;
                context.Attach(eGrade);
                context.Entry(eGrade).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool DeleteGrade(int id)
        {
            try
            {
                var grade = context.Grades.Find(id);
                context.Grades.Remove(grade);
                context.SaveChanges();
                return true;
            }
            catch 
            { 
                return false; 
            }
        }
        public Grade GetGradeById(int id)
        {
            return context.Grades.Find(id);
        }
        public DataTable GetAllGrade()
        {
            var student = context.Grades.Include(g => g.Student).ToList();
            var grades = student.Select(g => new
            {
                g.Id,
                MaSV = g.Student.MaSV,
                HoTen = g.Student.HoTen,
                g.TiengAnh,
                g.TinHoc,
                g.GDTC,
                DTB = (g.TiengAnh + g.TinHoc + g.GDTC) / 3,
            });
            var data = new DataTable();
            data.Columns.Add("Mã SV", typeof(string));
            data.Columns.Add("Họ Tên", typeof(string));
            data.Columns.Add("Tiếng Anh", typeof(float));
            data.Columns.Add("Tin học", typeof(float));
            data.Columns.Add("GDTC", typeof(float));
            data.Columns.Add("Điểm TB", typeof(float));
            data.Columns.Add("Id", typeof(int));
            foreach (var g in grades)
            {
                data.Rows.Add(g.MaSV, g.HoTen, g.TiengAnh, g.TinHoc, g.GDTC, g.DTB, g.Id);
            }
            return data;
        }
        public DataTable GetTop3Grade(DataTable data)
        {
            var top = data.Select("", "Điểm TB DESC").Take(3).CopyToDataTable();
            return top;
        }
        public DataRow GetGradeByStudentId(string MaSV)
        {
            var data = GetAllGrade();
            foreach (DataRow row in data.Rows)
            {
                if (row["Mã SV"].ToString() == MaSV)
                {
                    return row;
                }
            }
            return null;
        }

    }
}
