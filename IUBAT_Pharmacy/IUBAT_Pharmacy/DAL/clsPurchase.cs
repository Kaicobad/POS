using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsPurchase:clsMyBase
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime DateTime { get; set; }
        public int EmployeeId { get; set; }
        public int PurchaseDetailsId { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into purchase(number, dateTime,employeeId, purchaseDetailsId) values(@number, @dateTime, @employeeId, @purchaseDetailsId )");
            MyCommand.Parameters.AddWithValue("@number", Number);
            MyCommand.Parameters.AddWithValue("@dateTime", DateTime);
            MyCommand.Parameters.AddWithValue("@employeeId", EmployeeId);
            MyCommand.Parameters.AddWithValue("@purchaseDetailsId", PurchaseDetailsId);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update purchase set number = @number, dateTime= @dateTime, employeeId = @employeeId, purchaseDetailsId = @purchaseDetailsId where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@number", Number);
            MyCommand.Parameters.AddWithValue("@dateTime", DateTime);
            MyCommand.Parameters.AddWithValue("@employeeId", EmployeeId);
            MyCommand.Parameters.AddWithValue("@purchaseDetailsId", PurchaseDetailsId);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from purchase where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select number, dateTime,employeeId, purchaseDetailsId from purchase where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = MyCommand.ExecuteReader();

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                Number = MyReader["number"].ToString();
                DateTime = Convert.ToDateTime(MyReader["dateTime"]);
                EmployeeId = Convert.ToInt32(MyReader["employeeId"]);
                PurchaseDetailsId = Convert.ToInt32(MyReader["purchaseDetailsId"]);
                return true;
            }
            return false;
        }

        public System.Data.DataSet Select()
        {
            return ExecuteDataSet("select id, number, dateTime,employeeId, purchaseDetailsId from purchase");
        }
    }
}
