using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_Code_First.Context;
using EntityFramework_Code_First.Entities;
using System.Data.Entity;

namespace EntityFramework_Code_First.DataBaseDal
{
    public class CustomerDal
    {


        public List<Customer> GetAll()
        {
            using (var northwindContext = new NorthwindContext())
            {
                return northwindContext.Customer.ToList();
            }
        }
        public Customer GetById(string id)
        {
            using (var northwindContext = new NorthwindContext())
            {
                // SingleorDefault Aynı Sorğuda Birden Fazla Değer Gelirse Hata verir yoksa Null Getirir
               // return northwindContext.Customer.SingleOrDefault(p => p.CustomerID == id);

                // SingleorDefault Aynı Sorğuda Birden Fazla Değer Gelirse ilk Bulduğunu getirir Yoksa Null Getirir
                return northwindContext.Customer.FirstOrDefault(p => p.CustomerID == id);

                // Zaten Burda Sorgumuz İd YE Göre Arayacağından tek bir değer getirir O yüzden burda Hangisini Kullandığımız Fark Etmez
            }
        }


        public List<Customer> GetByName(string key)
        {
            using (var northwindContext = new NorthwindContext())
            {
                return northwindContext.Customer.Where( p => p.CustomerID.Contains(key)).ToList();
            }
        }



        public void AddOrder(Customer customer , Order order)
        {
            using (var northwindContext = new NorthwindContext())
            {
                northwindContext.Customer.Find(customer.CustomerID);
                customer.Orders.Add(order);
                northwindContext.SaveChanges();
            }
        }


        public void Add(Customer customer)
        {
            using (var northwindContext = new NorthwindContext())
            {
                northwindContext.Customer.Add(customer);
                northwindContext.SaveChanges();

                /*
                yada böylede yapılabilir
                var entity = northwindContext.Entry(customer);
                entity.State = EntityState.Add;
                northwindContext.SaveChanges();
                 */
            }
        }

        public void Update(Customer customer)
        {
            using (var northwindContext = new NorthwindContext())
            {
                // customer ı Git veritabanında ilişkilendir IDENTİTY E göre ilişkilendirir
                var entity = northwindContext.Entry(customer);
                //Güncellendi diye işaretle
                entity.State = EntityState.Modified;
                northwindContext.SaveChanges();
            }
        }

        public void Delete(Customer customer)
        {
            using (var northwindContext = new NorthwindContext())
            {
                // customer ı Git veritabanında ilişkilendir IDENTİTY E göre ilişkilendirir
                var entity = northwindContext.Entry(customer);
                //Silindi diye işaretle
                entity.State = EntityState.Deleted;
                northwindContext.SaveChanges();
            }
        }


    }
}
