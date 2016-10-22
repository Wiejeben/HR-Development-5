using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Employee : Model<Employee>
    {
        public int Bsn { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Employee()
        {
            this.IdentifyingKeys.Add("bsn");
        }

        public List<Address> Addresses()
        {
            var results = new List<Address>();

            var model = new AddressEmployee().Where("bsn", "=", this.Bsn.ToString());
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

            var model = new EmployeeDegree().Where("employee_bsn", "=", this.Bsn.ToString());

            var pivots = model.Get();

            foreach (EmployeeDegree pivot in pivots)
            {
                results.Add(pivot.Degree);
            }

            return results;
        }

        public List<Position> Positions()
        {
            var results = new List<Position>();

            var model = new EmployeePosition().Where("bsn", "=", this.Bsn.ToString());

            var pivots = model.Get();

            foreach (EmployeePosition pivot in pivots)
            {
                results.Add(pivot.Position);
            }

            return results;
        }
    }

    public class AddressEmployee : Model<AddressEmployee>, Pivot
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
                    address.Pivot = this;

                    this._address = address;
                }

                return this._address;
            }
        }

        public AddressEmployee()
        {
            this.IdentifyingKeys.Add("bsn");
            this.IdentifyingKeys.Add("address_id");
            this.Builder.Table = "address_employee";
        }

        public void AssignLeft(int value)
        {
            this.Bsn = value;
        }
    }

    public class EmployeeDegree : Model<EmployeeDegree>, Pivot
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
                    degree.Pivot = this;

                    this._degree = degree;
                }

                return this._degree;
            }
        }

        public EmployeeDegree()
        {
            this.IdentifyingKeys.Add("employee_bsn");
            this.IdentifyingKeys.Add("degree_id");
            this.Builder.Table = "employee_degree";
        }

        public void AssignLeft(int value)
        {
            this.EmployeeBsn = value;
        }
    }

    public class EmployeePosition : Model<EmployeePosition>, Pivot
    {
        public int Bsn { get; set; }
        public int PositionId { get; set; }

        private Position _position;
        public Position Position
        {
            get
            {
                if (this._position == null)
                {
                    var position = new Position().Find(this.PositionId.ToString());
                    position.Pivot = this;

                    this._position = position;
                }

                return this._position;
            }
        }

        public EmployeePosition()
        {
            this.IdentifyingKeys.Add("bsn");
            this.IdentifyingKeys.Add("position_id");
            this.Builder.Table = "employee_position";
        }

        public void AssignLeft(int value)
        {
            this.Bsn = value;
        }
    }
}
