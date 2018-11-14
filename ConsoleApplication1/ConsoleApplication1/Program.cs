using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        { }
        public class Customer
        {
            public string lastname;        //фамилия
            public string name;            //имя
            string patronymic;      //отчество
            string address;
            string phonenumber;
            string creditcard;
            string account;

            public Customer(string n, string l, string p, string A, string h, string a, string c)
            {
                name = n;
                lastname = l;
                patronymic = p;
                address = A;
                phonenumber = h;
                creditcard = c;
                account = a;
            }
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Елизавета", "Сидорова", "Сергеевна", "улица Республиканская,11", "89562385686", "12456789563214052367", "1234567899874563"));
            customers.Add(new Customer("Артем", "Иванов", "Викторович", "проспект Ленина,36", "89654236588", "12457896582365897410", "9876543211236547"));
            customers.Add(new Customer("Олег", "Курочкин", "Петрович", "улица Громова,22", "89652358747", "1547896542365897456", "4545565623121223"));
            customers.Add(new Customer("Светлана", "Лебедева", "Александровна", "площадь Мира,5", "89645698745", "1597856412365985632", "7889564512234556"));
            return customers;

            customers.Sort(delegate (Customer customer1, Customer customer2)
            { return customer1.lastname.CompareTo(customer2.lastname); });
            customers.Sort(delegate (Customer customer2, Customer customer3)
            { return customer2.lastname.CompareTo(customer3.lastname);
            });
            customers.Sort(delegate (Customer customer3, Customer customer4)
            { return customer3.lastname.CompareTo(customer4.lastname);
            }); }
            public void setlastname(lastname l)
        {
            lastname = l;
        }

        public void setcreditcard(string c)
        {
            creditcard = c;
        }
       
        public creditcard getcreditcard()
        {
            return creditcard;
        }

        
        public string info()
        {

            return String.Format("{0} {1} {2}\n\Номер кредитной карты:{3}\n\tАдрес: {4}",
                    lastname, patronymic, name, getcreditcard(), address);
        }


    }
}
 

