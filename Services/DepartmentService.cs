﻿using System.Collections.Generic;
using System.Linq;
using WebSales.Data;
using WebSales.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WebSales.Services
{
    public class DepartmentService
    {
        private readonly WebSalesContext _context;

        public DepartmentService(WebSalesContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
