using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework_Code_First.DataBaseDal;
using EntityFramework_Code_First.Entities;

namespace EntityFramework_Code_First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerDal customerDal = new CustomerDal();

        public void AddCustomer()
        {
            customerDal.Add(new Customer
            {
                CustomerID = txt_CustomerID.Text,
                CompanyName = txt_CompanyName.Text,
                ContactName = txt_ContactName.Text,
                City = txt_City.Text,
                Country = txt_Country.Text,
                Orders = null
            }
            );

        }

        public void UpdateCustomer()
        {
            customerDal.Update(new Customer
            {
                CustomerID = txt_CustomerID.Text,
                CompanyName = txt_CompanyName.Text,
                ContactName = txt_ContactName.Text,
                City = txt_City.Text,
                Country = txt_Country.Text,
                Orders = null
            }
            );
        }

        public void GetAllCustomer()
        {
            dataGridView1.DataSource = customerDal.GetAll();
        }

        public void SearchCustomer(string Key)
        {
            //dataGridView1.DataSource = customerDal.GetAll().Where(f => f.CustomerID.Contains(Key)).ToList();

            //Verileri Listede aradığı için c# büyük küçük harf duyarlıdır bu yüzden Laptop yazınca gelen ürün laptop yazınca gelmez
            //Bu yüzden arama işleminde eğer liste kullanıcaksak 2 sinide ya küçük harfe yada büyük harfe çevirmeliyiz
            dataGridView1.DataSource = customerDal.GetAll().Where(f => f.CustomerID.ToLower().Contains(Key.ToLower())).ToList();
        }

        public void GetbyName(string key)
        {
            dataGridView1.DataSource = customerDal.GetByName(key);
        }


        public void DeleteCustomer()
        {
            customerDal.Update(new Customer { CustomerID = txt_CustomerID.Text });
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllCustomer();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Customer Add
            AddCustomer();
            GetAllCustomer();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Customer Update
            UpdateCustomer();
            GetAllCustomer();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Customer Delete
            DeleteCustomer();
            GetAllCustomer();
        }

        private void txt_Search_OnValueChanged(object sender, EventArgs e)
        {
            //Key = CustomerID  Search
            // Veritabanından bütün verileri ektikten sonra arama işlemi yapar
            // SearchCustomer(txt_Search.Text);

            //Veri tabanından sadece istenileni getirir bütün veriyi çekmez büyük db lerde tercih edilmeli çünkü bütün veriyi boşuna çekmemiş olur
            GetbyName(txt_Search.Text);
        }

        private void txt_Search_Enter(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search")
                txt_Search.Text = null;

        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if (txt_Search.Text == null)
                txt_Search.Text = "Search";
        }

        private void btn_GetCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = customerDal.GetById(txt_GetCustomerİD.Text);

                txt_CustomerID.Text = customer.CustomerID;
                txt_ContactName.Text = customer.ContactName;
                txt_CompanyName.Text = customer.CompanyName;
                txt_Country.Text = customer.Country;
                txt_City.Text = customer.City;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Aratılan İD Bulunamadı", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



        }

        private void btn_OrderAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                CustomerID = txt_CustomerID.Text,
            };
            
            customerDal.AddOrder(customer ,order: new Order {OrderDate = DateTime.Now , ShipCity = txt_ShipCity.Text , ShipCountry = txt_ShipCountry.Text } );

            MessageBox.Show(customer.CustomerID + " İD li Müşteriye Sipariş Eklendi ");
        }
    }
}
