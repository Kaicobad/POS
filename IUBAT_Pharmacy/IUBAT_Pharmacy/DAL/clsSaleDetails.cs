using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsSaleDetails:clsMyBase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
        public string SerialNumber { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }
        public double Vat { get; set; }
        public int DiscountId { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into saledetails(productId, companyId, serialNumber, qty, rate,vat, discountId) values(@productId, @companyId, @serialNumber, @qty, @rate, @vat, @discountId)");
            MyCommand.Parameters.AddWithValue("@productId", ProductId);
            MyCommand.Parameters.AddWithValue("@companyId", CompanyId);
            MyCommand.Parameters.AddWithValue("@serialNumber", SerialNumber);
            MyCommand.Parameters.AddWithValue("@qty", Qty);
            MyCommand.Parameters.AddWithValue("@rate", Rate);
            MyCommand.Parameters.AddWithValue("@vat", Vat);
            MyCommand.Parameters.AddWithValue("@discountId", DiscountId);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update saleDetails set productId = @productId, companyId = @companyId, serialNumbe0 = @serialNumber, qty = @qty, rate = @rate, vat = @vat, discountId = @discountId where Id = !id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@productId", ProductId);
            MyCommand.Parameters.AddWithValue("@companyId", CompanyId);
            MyCommand.Parameters.AddWithValue("@serialNumber", SerialNumber);
            MyCommand.Parameters.AddWithValue("@qty", Qty);
            MyCommand.Parameters.AddWithValue("@rate", Rate);
            MyCommand.Parameters.AddWithValue("@vat", Vat);
            MyCommand.Parameters.AddWithValue("@discountId", DiscountId);
            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from saleDetails where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select productId, companyId, serialNumber, qty, rate,vat, discountId from saleDetails where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = MyCommand.ExecuteReader();

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                ProductId = Convert.ToInt32(MyReader["productId"]);
                CompanyId = Convert.ToInt32(MyReader["productId"]);
                SerialNumber = MyReader["serialNumber"].ToString();
                Qty = Convert.ToInt32(MyReader["qty"]);
                Rate = Convert.ToDouble(MyReader["rate"]);
                Vat = Convert.ToDouble(MyReader["vat"]);
                DiscountId = Convert.ToInt32(MyReader["discountId"]);
                return true;
            }
            return false;
        }

        public System.Data.DataSet Select()
        {
            return ExecuteDataSet("select id, productId, companyId, serialNumber, qty, rate,vat, discountId from saleDetails");
        }
    }
}
