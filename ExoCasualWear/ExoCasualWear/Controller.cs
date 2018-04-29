﻿using System;
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
        public int CalcSales()
        {
            string query = " SELECT Sum(Discount_price) AS Profit FROM Receipt";
            return dbMan.UpdateData(query);
        }

        public int CalcEmp()
        {
            string query = " SELECT Count(ID) AS NumOfEmp FROM Employee";
            return dbMan.UpdateData(query);
        }

        public DataTable ItemProfile(string ItemNum)
        {
            string query = "SELECT Item_discription, Category, Item_size, Color, Brand, Offer.Value, O_Start, O_End, SoldAt.Available, SoldAt.StID, Store.St_City, Store.St_State  FROM Items, Offer, SoldAt, Store WHERE ItemNO#='" + ItemNum + "' AND Items.OfID=Offer.OfferID AND SoldAt.ItemsNumber=Items.ItemNO# AND SoldAt.StID=Store.Store#;";
            return dbMan.ExecuteTableQuery(query);      
        }

        public DataTable MemberProfile(string MemberNum)
        {
            string query = "SELECT C_Fname, C_Lname, C_Phone#, Receipt.Total_price, Receipt.Discount_price, R_Contains.Quantity, R_Contains.ReceiptID, R_Contains.Item#No, Items.Item_discription, Offer.Value FROM Customer, Receipt, R_Contains, Items, Offer WHERE MembershipID#='" + MemberNum + "' AND Receipt.MemID#=Customer.MembershipID# AND R_Contains.ReceiptID=Receipt.Receipt# AND R_Contains.Item#No=Items.ItemNO# AND Items.OfID=Offer.OfferID;";
            return dbMan.ExecuteTableQuery(query);
        }

        public DataTable ShipmentProfile(string ShipNum)
        {
            string query = "SELECT ShipmentID#, Sh_Date, Supplier.Su_Fname, Supplier.Su_Lname, Supplier.Su_Phone#, Supply_Store.ItemsNum, Supply_Store.StoreID, Supply_Store.Quantity, Items.Item_discription, Items.Price, Offer.Value FROM Shipment, Supplier, Supply_Store, Items, Offer WHERE ShipmentID#='" + ShipNum + "' AND Shipment.SupID#=Supplier.SupplierID# AND Supply_Store.ShipID=Shipment.ShipmentID# AND Supply_Store.ItemsNum=Items.ItemNO# AND Items.OfID=Offer.OfferID;";
            return dbMan.ExecuteTableQuery(query);
        }
        public DataTable MostSoldItemPerStore()
        {
            string query = "select stid, st_city, st_state, itemsnumber, item_discription as Item_name, max(sold) as #sold from soldAt s , store,  items where itemsnumber=itemNO# AND stid=store# group by stid, itemsnumber, st_city, st_state, item_discription having max(sold) = ( select top 1 max(sold) from soldAt where stid = s.stid group by stid, itemsnumber order by max(sold) desc);";
            return dbMan.ExecuteTableQuery(query);
        }

        public DataTable MostSoldItemPerStore(string CheckDate) //User input the date required for the check that no items are sold after it
        {
            string query = "SELECT Items.ItemNO#,Items.Item_discription FROM Items WHERE itemNo# NOT IN( select distinct Item#No from R_Contains, Receipt WHERE R_Contains.ReceiptID=Receipt.Receipt# AND Receipt.R_Date>='"+CheckDate+"');";
            return dbMan.ExecuteTableQuery(query);
        }

    }
}
