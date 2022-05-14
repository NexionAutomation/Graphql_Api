using GraphQL_HotChoclate_EFCore.Models;
using GraphQL_HotChoclate_EFCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_HotChoclate_EFCore.GraphQL
{
    //public class Query
    //{
    //    public Book GetBook()
    //    {
    //        return new Book { Title = "C# in depth", Author = "Jon Skeet" };
    //    }
    //    #region Property
    //    private readonly IEmployeeService _employeeService;
    //    #endregion

    //    #region Constructor
    //    public Query(IEmployeeService employeeService)
    //    {
    //        _employeeService = employeeService;
    //    }
    //    #endregion

    //    public IQueryable<Employee> Employees => _employeeService.GetAll();

    //}


    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }
    }
}
