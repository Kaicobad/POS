using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsPurchaseDetails:clsMyBase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int DiscountId { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }
        public double Vat { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into purchaseDetails(productId, discountId, qty, rate, vat) values(@productId, @discountId, @qty, @rate, @vat)");
            MyCommand.Parameters.AddWithValue("@productId", ProductId);
            MyCommand.Parameters.AddWithValue("@discountId", DiscountId);
            MyCommand.Parameters.AddWithValue("@qty", Qty);
            MyCommand.Parameters.AddWithValue("@rate", Rate);
            MyCommand.Parameters.AddWithValue("@vat", Vat);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update purchaseDetails set productId = @productId, discountId = discountId, qty = @qty, rate = @rate, vat = @vat where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@productId", ProductId);
            MyCommand.Parameters.AddWithValue("@discountId", DiscountId);
            MyCommand.Parameters.AddWithValue("@qty", Qty);
            MyCommand.Parameters.AddWithValue("@rate", Rate);
            MyCommand.Parameters.AddWithValue("@vat", Vat);
            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from purchaseDetails where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select productId, discountId, qty, rate, vatfrom purchaseDetails where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = ExecuteReader(MyCommand);

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                ProductId = Convert.ToInt32(MyReader["productId"]);
                DiscountId = Convert.ToInt32(MyReader["discountId"]);
                Qty = Convert.ToInt32(MyReader["qty"]);
                Rate = Convert.ToDouble(MyReader["rate"]);
                Vat = Convert.ToDouble(MyReader["vat"]);
                return true;
            }
            return false;
        }

        public System.Data.DataSet Select( string extra = "")
        {
            MyCommand = MyCommandBuilder(@"select prc.id, p.name product, prc.qty, prc.rate,
                                        prc.vat, ds.persentage as discount from PurchaseDetails as prc left join product as p 
                                        on prc.productId = p.id left join discount as ds on prc.discountId = ds.id where prc.id > 0");

            if (ProductId > 0 )
            {
                MyCommand.CommandText += " and p.productId = @productId";
                MyCommand.Parameters.AddWithValue("@productId", ProductId);
            }

            MyCommand.CommandText += extra;

            return ExecuteDataSet(MyCommand);
        }
    }
}
