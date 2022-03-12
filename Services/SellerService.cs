﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSales.Data;
using WebSales.Models;
using Microsoft.EntityFrameworkCore;

namespace WebSales.Services
{
    public class SellerService
    {
        private readonly WebSalesContext _context;

        public SellerService(WebSalesContext context)
        {
            _context = context;
        }

        public List<Models.Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
