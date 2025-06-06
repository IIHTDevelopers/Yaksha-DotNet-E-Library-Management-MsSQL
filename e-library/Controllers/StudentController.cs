﻿using e_library.BusinessLayer.Interfaces;
using e_library.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_library.Controllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {
        /// <summary>
        /// Creating referance of ILibraryServices and injecting in StudentController Constructor
        /// </summary>
        private readonly ILibraryServices _libraryServices;
        public StudentController(ILibraryServices libraryServices)
        {
            _libraryServices = libraryServices;
        }
        /// <summary>
        /// Register new Student.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        
        public async Task<ActionResult<Student>> RegisterStudent([FromBody] Student model)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Issue a new book for student.
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="bookId"></param>
        /// <returns></returns>
        
        public async Task<ActionResult<bool>> IssueNewBook(int studentId, int bookId)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Return borrow book
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="bookId"></param>
        /// <returns></returns>
        
        public async Task<ActionResult<bool>> ReturnBook(int studentId, int bookId)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get all student book information by student Id
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
       
        public async Task<IEnumerable<Book>> GetAllIssuedBooksByStudent(int studentId)
        {
            //do code here
            throw new NotImplementedException();
        }
    }
}
