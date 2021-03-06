using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSales.Models;
using WebSales.Models.Enums;

namespace WebSales.Data
{
    public class SeedingService
    {
        private WebSalesContext _context;

        public SeedingService(WebSalesContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DB has been seeded
            }

            Department departmentA = new Department(1, "Computers");
            Department departmentB = new Department(2, "Electronics");
            Department departmentC = new Department(3, "Fashion");
            Department departmentD = new Department(4, "Books");

            Seller sellerA = new Seller(1, "Bob Brown", "bob@mail.com", new DateTime(1982, 9, 14), 1000.0, departmentA);
            Seller sellerB = new Seller(2, "Maria Green", "maria@mail.com", new DateTime(1979, 12, 31), 1000.0, departmentB);
            Seller sellerC = new Seller(3, "Alex Grey", "alex@mail.com", new DateTime(1988, 1, 15), 1000.0, departmentA);
            Seller sellerD = new Seller(4, "Martha Red", "martha@mail.com", new DateTime(1993, 11, 30), 1000.0, departmentD);
            Seller sellerE = new Seller(5, "Donald Blue", "donald@mail.com", new DateTime(2000, 1, 9), 1000.0, departmentC);
            Seller sellerF = new Seller(6, "Alex Pink", "alex@mail.com", new DateTime(1998, 4, 21), 1000.0, departmentB);

            SalesRecord record1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, sellerA);
            SalesRecord record2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, sellerE);
            SalesRecord record3 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, sellerD);
            SalesRecord record4 = new SalesRecord(4, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, sellerA);
            SalesRecord record5 = new SalesRecord(5, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, sellerC);
            SalesRecord record6 = new SalesRecord(6, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, sellerA);
            SalesRecord record7 = new SalesRecord(7, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, sellerB);
            SalesRecord record8 = new SalesRecord(8, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, sellerD);
            SalesRecord record9 = new SalesRecord(9, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, sellerF);
            SalesRecord record10 = new SalesRecord(10, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, sellerF);
            SalesRecord record11 = new SalesRecord(11, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, sellerB);
            SalesRecord record12 = new SalesRecord(12, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, sellerC);
            SalesRecord record13 = new SalesRecord(13, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, sellerD);
            SalesRecord record14 = new SalesRecord(14, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, sellerE);
            SalesRecord record15 = new SalesRecord(15, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, sellerA);
            SalesRecord record16 = new SalesRecord(16, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, sellerD);
            SalesRecord record17 = new SalesRecord(17, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, sellerA);
            SalesRecord record18 = new SalesRecord(18, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, sellerC);
            SalesRecord record19 = new SalesRecord(19, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, sellerE);
            SalesRecord record20 = new SalesRecord(20, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, sellerF);
            SalesRecord record21 = new SalesRecord(21, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, sellerB);
            SalesRecord record22 = new SalesRecord(22, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, sellerD);
            SalesRecord record23 = new SalesRecord(23, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, sellerB);
            SalesRecord record24 = new SalesRecord(24, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, sellerE);
            SalesRecord record25 = new SalesRecord(25, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, sellerC);
            SalesRecord record26 = new SalesRecord(26, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, sellerD);
            SalesRecord record27 = new SalesRecord(27, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, sellerA);
            SalesRecord record28 = new SalesRecord(28, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, sellerC);
            SalesRecord record29 = new SalesRecord(29, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, sellerE);
            SalesRecord record30 = new SalesRecord(30, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, sellerB);

            _context.Department.AddRange(departmentA, departmentB, departmentC, departmentD);

            _context.Seller.AddRange(sellerA, sellerB, sellerC, sellerD, sellerE, sellerF);

            _context.SalesRecord.AddRange(
                record1, record2, record3, record4, record5, record6, record7, record8, record9, record10,
                record11, record12, record13, record14, record15, record16, record17, record18, record19, record20,
                record21, record22, record23, record24, record25, record26, record27, record28, record29, record30
            );

            _context.SaveChanges();
        }
    }
}
