using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class AddressEmployee : Model<AddressEmployee>
    {
        public int Bsn { get; set; }
        public int AddressId { get; set; }
        public bool Residence { get; set; }

        private Address _address;
        public Address Address
        {
            get
            {
                if (this._address == null)
                {
                    var address = new Address().Find(this.AddressId.ToString());
                    address.Pivot = this.Builder.Columns(true);

                    this._address = address;
                }
                
                return this._address;
            }
        }

        public AddressEmployee()
        {
            this.Builder.Table = "address_employee";
        }
    }

    public class AddressDegree : Model<AddressDegree>
    {
        public int EmployeeBsn { get; set; }
        public int DegreeId { get; set; }

        private Degree _degree;
        public Degree Degree
        {
            get
            {
                if (this._degree == null)
                {
                    var degree = new Degree().Find(this.DegreeId.ToString());
                    degree.Pivot = this.Builder.Columns(true);

                    this._degree = degree;
                }

                return this._degree;
            }
        }

        public AddressDegree()
        {
            this.Builder.Table = "employee_degree";
        }
    }

    public class Employee : Model<Employee>
    {
        public int Bsn { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Employee()
        {
            this.PrimaryKey = "bsn";
        }

        public List<Address> Addresses()
        {
            var results = new List<Address>();

            var model = new AddressEmployee();

            model.Where("bsn", "=", this.Bsn.ToString());
            var pivots = model.Get();

            foreach (AddressEmployee pivot in pivots)
            {
                results.Add(pivot.Address);
            }

            return results;
        }

        public List<Degree> Degrees()
        {
            var results = new List<Degree>();

            var model = new AddressDegree();

            model.Where("employee_bsn", "=", this.Bsn.ToString());
            var pivots = model.Get();

            foreach (AddressDegree pivot in pivots)
            {
                results.Add(pivot.Degree);
            }

            return results;
        }
    }
}
