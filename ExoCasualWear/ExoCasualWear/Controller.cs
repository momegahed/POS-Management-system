using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ExoCasualWear
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public int InsertEmployee(string ID, string E_Fname, string E_Lname, string E_City, string E_Street, string E_State, int St_Hours, string St_ID, string Super_ID)
        {
            string query = "INSERT INTO Employee (ID, E_Fname, E_Lname, E_City, E_street, E_State, St_Hours, St_ID, Super_ID " +
                            "Values ('" + ID + "','" + E_Fname + "','" + E_Lname + "'," + E_City + "'," + E_Street + "'," + E_State + "'," + St_Hours + "'," + St_ID + "'," + Super_ID + ");";

            return dbMan.UpdateData(query);
        }
        public int InsertItems(string ItemNO, string Item_discription, int Price, string Category, string Item_size, string Color, int Brand, string OFID)
        {
            string query = "INSERT INTO Items (ItemNO#, Item_Discription, Price, Category, Item_size, Color, Brand, OfID" +
                            "Values ('" + ItemNO + "','" + Item_discription + "','" + Price + "'," + Category + "'," + Item_size + "'," + Color + "'," + Brand + "'," + OFID + ");";

            return dbMan.UpdateData(query);
        }
        public int InsertCustomer(string MembershipID, string C_Fname, string C_Lname, string C_Phone)
        {
            string query = "INSERT INTO Customer (MembershipID#, C_Fname, C_Lname, C_Phone#" +
                            "Values ('" + MembershipID + "','" + C_Fname + "','" + C_Lname + "'," + C_Phone  + ");";

            return dbMan.UpdateData(query);
        }
        public int CalcSales(int Discount_price)
        {
            string query = " SELECT Sum(Discount_price) AS Profit FROM Receipt";
            return dbMan.UpdateData(query);
        }

        public int CalcEmp(string ID)
        {
            string query = " SELECT Sum(ID) AS  FROM Employee";
            return dbMan.UpdateData(query);
        }
    }
}
