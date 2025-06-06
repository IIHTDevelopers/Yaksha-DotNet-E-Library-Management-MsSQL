﻿using e_library.BusinessLayer.Interfaces;
using e_library.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_library.Controllers
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        /// <summary>
        /// Creating referance of ILibraryServices and injecting in BookController Constructor
        /// </summary>
        private readonly ILibraryServices _libraryServices;
        public BooksController(ILibraryServices libraryServices)
        {
            _libraryServices = libraryServices;
        }
        /// <summary>
        /// Get all issued book
        /// </summary>
        /// <returns></returns>
        
        public async Task<IEnumerable<Book>> IssuedBook()
        {
            return await _libraryServices.IssuedBook();
        }
        /// <summary>
        /// Get all book by stream
        /// </summary>
        /// <param name="streams"></param>
        /// <returns></returns>
        
        public async Task<IEnumerable<Book>> GetAllBookByStream(Streams streams)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get all book of student by student id and stream
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
       
        public async Task<IEnumerable<Book>> GetAllBooksByStudentStream(int studentId)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add new book
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        
        public async Task<ActionResult<Book>> AddNewBook([FromBody] Book model)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all book with fine.
        /// </summary>
        /// <returns></returns>
       
        public async Task<IEnumerable<Book>> GetAllBookWithFine()
        {
            //do code here
            throw new NotImplementedException();
        }
    }
}
