using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsSale:clsMyBase
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime DateTime { get; set; }
        public int EmployeeId { get; set; }
        public int SaleStatusId { get; set; }
        public int SaleDetailsId { get; set; }
        public int PaymentMethodId { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into sale(number, dateTime,employeeId, saleStatusId, saleDetailsId, paymentMethodId) values(@number, @dateTime,@employeeId, @saleStatusId, @saleDetailsId, @paymentMethodId)");
            MyCommand.Parameters.AddWithValue("@number", Number);
            MyCommand.Parameters.AddWithValue("@dateTime", DateTime);
            MyCommand.Parameters.AddWithValue("@employeeId", EmployeeId);
            MyCommand.Parameters.AddWithValue("@saleStatusId", SaleStatusId);
            MyCommand.Parameters.AddWithValue("@saleDetailsId", SaleDetailsId);
            MyCommand.Parameters.AddWithValue("@paymentMethodId", PaymentMethodId);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update slae set number = @number, dateTime = @dateTime, employeeId = @employeeId, saleStatusId = @saleStatusId, saleDetailsId = @saleDetailsId, paymentMethodId = @paymentMethodId where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@number", Number);
            MyCommand.Parameters.AddWithValue("@dateTime", DateTime);
            MyCommand.Parameters.AddWithValue("@employeeId", EmployeeId);
            MyCommand.Parameters.AddWithValue("@saleStatusId", SaleStatusId);
            MyCommand.Parameters.AddWithValue("@saleDetailsId", SaleDetailsId);
            MyCommand.Parameters.AddWithValue("@paymentMethodId", PaymentMethodId);
            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from sale where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select number, dateTime,employeeId, saleStatusId, saleDetailsId, paymentMethodId from sale where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = MyCommand.ExecuteReader();

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                Number = MyReader["number"].ToString();
                DateTime = Convert.ToDateTime(MyReader["dateTime"]);
                EmployeeId = Convert.ToInt32(MyReader["employeeId"]);
                SaleStatusId = Convert.ToInt32(MyReader["saleStatusId"]);
                SaleDetailsId = Convert.ToInt32(MyReader["saledetailsId"]);
                PaymentMethodId = Convert.ToInt32(MyReader["paymentMethodId"]);
            }
            return false;
        }

        public System.Data.DataSet Select()
        {
            return ExecuteDataSet("select id, number, dateTime,employeeId, saleStatusId, saleDetailsId, paymentMethodId from sale");
        }
    }
}
