using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;

namespace ExoCasualWear
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();

        }

        public int CheckPassword(string username, string password)
        {
            //Query the DB to check for username/password
            string query = "SELECT  ID FROM User_Type, Employee WHERE   ID=EmployeeID AND username = '" + username + "' AND password = '" + password + "' ;";
            object p = dbMan.ExecuteScalarQuery(query);
            if (p == null)
                return 0;
            else return (int)p;

        }
        public void ChangePassword(string username, string newpass, string Security)
        {
            string test = "SELECT Security FROM User_Type WHERE Security = '" + Security + "' AND username = '" + username + "'; ";
            object flag = dbMan.ExecuteScalarQuery(test);
            if (flag == null)
            {
                MessageBox.Show("Can't reset password");
            }
            string query = "UPDATE User_Type SET password = '" + newpass + "' WHERE EmployeeID IN(SELECT ID FROM Employee) AND username =  '" + username + "'   ;";
            object p = dbMan.ExecuteScalarQuery(query);


        }

        public void CreateNormalAccount(string username, string password, string ID, string Security)
        {
            string test1 = "SELECT EmployeeID FROM User_Type  WHERE EmployeeID = '" + ID + "'; "; //First test if the ID is already signed up
            object flag1 = dbMan.ExecuteScalarQuery(test1);

            if (flag1 != null)
            {
                MessageBox.Show(" You are already signed in !");
                return;

            }

            string test2 = " SELECT ID FROM  Employee WHERE ID = '" + ID + "'; "; //Second test if the ID is not in the company
            object flag2 = dbMan.ExecuteScalarQuery(test2);
            if (flag2 == null)
            {
                MessageBox.Show(" You are not working here !");
                return;


            }
            //Now we can gurantee that this ID is for an empolyee in the store and didn't register before.
            string query = " INSERT INTO User_Type (username, password , type , EmployeeID, Security) " +
                           " Values ( '" + username + "' , '" + password + "' , ' Sales Assistant' , '" + ID + "' , '" + Security + "' ); ";
            object p = dbMan.ExecuteScalarQuery(query);

        }

        public void AddUser(string username, string password, string ID, string type, string Security)
        {

            string test1 = "SELECT EmployeeID FROM User_Type  WHERE EmployeeID = '" + ID + "'; "; //First test if the ID is already signed up
            object flag1 = dbMan.ExecuteScalarQuery(test1);

            if (flag1 != null)
            {
                MessageBox.Show(" The user is already added !");
                return;

            }

            string test2 = " SELECT ID FROM  Employee WHERE ID = '" + ID + "'; "; //Second test if the ID is not in the company
            object flag2 = dbMan.ExecuteScalarQuery(test2);
            if (flag2 == null)
            {
                MessageBox.Show(" Error! There is no employee with this ID !");
                return;


            }
            string test3 = "SELECT username FROM User_Type WHERE username = '" + username + "'; ";
            object flag3 = dbMan.ExecuteScalarQuery(test3);
            if (flag3 != null)
            {
                MessageBox.Show(" This username is already taken !");
                return;
            }
            string query = " INSERT INTO User_Type (username, password , type , EmployeeID, Security) " +
                           " Values ( '" + username + "' , '" + password + "' , '" + type + "' , '" + ID + "' , '" + Security + "' ); ";
            object p = dbMan.ExecuteScalarQuery(query);
        }

        public void DeleteUser(string username)
        {
            string query = "DELETE FROM User_Type WHERE username = '" + username + "' ; ";
            object p = dbMan.ExecuteScalarQuery(query);
            MessageBox.Show("Done ! user is deleted.");
        }

        public void ChangeUserType(string username, string type)
        {
            string query = "UPDATE User_Type SET type = '" + type + "' WHERE username = '" + username + "' ; ";
            object p = dbMan.ExecuteScalarQuery(query);
            MessageBox.Show("Done ! user type has changed.");

        }
        public DataTable SelectUsername()
        {
            string query = "SELECT  username FROM User_Type;";
            return dbMan.ExecuteTableQuery(query);
        }
        public DataTable SelectUser()
        {
            string query = "SELECT username, type, EmployeeID FROM User_Type ";
            return dbMan.ExecuteTableQuery(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int InsertEmployee(int ID, string E_Fname, string E_Lname, string E_City, string E_Street, string E_State, int St_Hours, string St_ID, string Super_ID)
        {
            string query = "INSERT INTO Employee (ID, E_Fname, E_Lname, E_City, E_street, E_State, St_Hours, St_ID, SuperID ) " +
                            "Values ('" + ID + "','" + E_Fname + "','" + E_Lname + "','" + E_City + "','" + E_Street + "','" + E_State + "','" + St_Hours + "','" + St_ID + "','" + Super_ID + "');";

            return Int16.Parse(dbMan.UpdateData(query).ToString());
        }

        public int InsertItems(Int64 ItemNO, string Item_discription, string Item_detailed_discription, double Price, string Category, string Brand)
        {
            string query = "INSERT INTO Items (ItemNO#, Item_Discription,Item_detailed_discription,Price,Category , Brand, OfID)" +
                            "Values ('" + ItemNO + "','" + Item_discription + "','" + Item_detailed_discription + "','" + Price + "','" + Category + "','" + Brand + "',null);";

            return dbMan.UpdateData(query);
        }

        public int InsertCustomer(int MembershipID, string C_Fname, string C_Lname, string C_Phone)
        {
            string query = "INSERT INTO Customer (MembershipID#, C_Fname, C_Lname, C_Phone#)" +
                            "Values ('" + MembershipID + "','" + C_Fname + "','" + C_Lname + "','" + C_Phone  + "');";

            return dbMan.UpdateData(query);
        }
        public Double CalcSales()
        {
            string query = " SELECT Sum(Discount_price) AS Profit FROM Receipt";
            return Double.Parse(dbMan.ExecuteScalarQuery(query).ToString());
        }

        public int CalcEmp()
        {
            string query = " SELECT Count(ID) AS NumOfEmp FROM Employee";
            return Int32.Parse(dbMan.ExecuteScalarQuery(query).ToString());
        }

        public DataTable ItemProfile(Int64 ItemNum)
        {
            string query = "SELECT Item_Discription,Item_detailed_discription,Price,Category , Brand, OfID, Offer.Value, O_Start, O_End, SoldAt.Available, SoldAt.StID, Store.St_City, Store.St_State  FROM Items, Offer, SoldAt, Store WHERE ItemNO#=" + ItemNum + " AND Items.OfID=Offer.OfferID AND SoldAt.ItemsNumber=Items.ItemNO# AND SoldAt.StID=Store.Store#;";
            return dbMan.ExecuteTableQuery(query);
        }

        public DataTable MemberProfile(int MemberNum)
        {
            string query = "SELECT C_Fname, C_Lname, C_Phone#, Receipt.Total_price, Receipt.Discount_price, R_Contains.Quantity, R_Contains.ReceiptID, R_Contains.Item#No, Items.Item_discription, Offer.Value FROM Customer, Receipt, R_Contains, Items, Offer WHERE MembershipID#=" + MemberNum + " AND Receipt.MemID#=Customer.MembershipID# AND R_Contains.ReceiptID=Receipt.Receipt# AND R_Contains.Item#No=Items.ItemNO# AND Items.OfID=Offer.OfferID;";
            return dbMan.ExecuteTableQuery(query);
        }

        public DataTable ShipmentProfile(int ShipNum)
        {
            string query = "SELECT ShipmentID#, Sh_Date, Supplier.Su_Fname, Supplier.Su_Lname, Supplier.Su_Phone#, Supply_Store.ItemsNum, Supply_Store.StoreID, Supply_Store.Quantity, Items.Item_discription, Items.Price, Offer.Value FROM Shipment, Supplier, Supply_Store, Items, Offer WHERE ShipmentID#=" + ShipNum + " AND Shipment.SupID#=Supplier.SupplierID# AND Supply_Store.ShipID=Shipment.ShipmentID# AND Supply_Store.ItemsNum=Items.ItemNO# AND Items.OfID=Offer.OfferID;";
            return dbMan.ExecuteTableQuery(query);
        }

        //Most soled items in every branch
        public DataTable MostSoldItemPerStore()
        {
            string query = "select stid, st_city, st_state, itemsnumber, item_discription as Item_name, max(sold) as #sold from soldAt s , store,  items where itemsnumber=itemNO# AND stid=store# group by stid, itemsnumber, st_city, st_state, item_discription having max(sold) = ( select top 1 max(sold) from soldAt where stid = s.stid group by stid, itemsnumber order by max(sold) desc);";
            return dbMan.ExecuteTableQuery(query);
        }
        
        //Itemes in every brach that are not sold from specific date untill now
        public DataTable itemNotsold(string CheckDate) //User input the date required for the check that no items are sold after it 
        {
            string query = "SELECT Items.ItemNO#,Items.Item_discription FROM Items WHERE itemNo# NOT IN( select distinct Item#No from R_Contains, Receipt WHERE R_Contains.ReceiptID=Receipt.Receipt# AND Receipt.R_Date='"+CheckDate+"');";
            return dbMan.ExecuteTableQuery(query);
        }
        //add and details of the supplier
        public DataTable Supplier_Details(Int32 ID)
        {
            string query = "SELECT SupplierID#, Su_Fname, Su_Lname, Su_City, Su_Street, Su_State, Su_Phone#, Email FROM Supplier WHERE SupplierID#=" + ID + ";";
            return dbMan.ExecuteTableQuery(query);
        }

        public int AddSupplier(Int32 ID, string FName, string LName, string City, string Street, string State, string Phone, string Email)
        {
            string query = "INSERT INTO Supplier (SupplierID#, Su_Fname, Su_Lname, Su_City, Su_Street, Su_State, Su_Phone#, Email)" +
                             "Values ('" + ID + "','" + FName + "','" + LName + "','" + City + "','" + Street + "','" + State + "','" + Phone + "','" + Email + "');";

            return dbMan.UpdateData(query);
        }

        public int AddStore(Int32 ID, Int16 Ohours, string City, string Street, string State)
        {
            string query = "INSERT INTO Store( Store#, Operating_hours, St_City, St_Street, St_State)" +
                             "Values ('" + ID + "','" + Ohours  + "','" + City + "','" + Street + "','" + State + "');";

            return dbMan.UpdateData(query);
        }

        public DataTable Store_Details()
        {
            string query = "SELECT Store#, Operating_hours, St_City, St_Street, St_State FROM Store;";
            return dbMan.ExecuteTableQuery(query);
        }


        public DataTable getSups() // to get all suppliers names and IDs
        {
            string query = "SELECT Supplier.Su_Fname , Supplier.Su_Lname, SupplierID# FROM Supplier;";
            return dbMan.ExecuteTableQuery(query);
        }

        public int Shipment_AG()
        {
            string query = "SELECT Count(ShipmentID#) AS AG_ShipmentNum FROM Shipment";
            return Int32.Parse(dbMan.ExecuteScalarQuery(query).ToString());
        }

        public DataTable getItem(Int64 ItemNum) //to get item no,detailsmprice,1,discount 
        {
            string query = "SELECT ItemNO# AS itemnumber , Item_discription AS ItemDescription , Price AS price,Store# AS Quantity ,Value AS discount  From Items , Store, Offer WHERE Store# = 1 AND Items.OfID=OfferID AND ItemNO# = " + ItemNum + ";";
            return dbMan.ExecuteTableQuery(query);
        }

        public int fillship(Int64 ItemNum , int StoreID, int ShipID, int quantity) //to fill data inside shipment (supplystore Table)
        {
            string query = "INSERT INTO Supply_Store " +
                            "Values ('" + ItemNum + "','" + StoreID + "','" + ShipID + "','" + quantity + "');"+
                            " UPDATE SoldAt SET Available = (SELECT Available FROM SoldAt AS OLDSoldAt WHERE SoldAt.ItemsNumber=OLDSoldAt.ItemsNumber AND SoldAt.StID=OLDSoldAt.StID)+" + quantity + " WHERE SoldAt.ItemsNumber='" + ItemNum + "' AND SoldAt.StID='" + StoreID + "';";
            return dbMan.UpdateData(query);
        }

        public int fillR(Int64 RID, int EmpID, Int64 ItemNum, string price, double descount, int quantity) //to fill data inside specific recipt (R_contain table)
        {
            string query = "INSERT INTO R_contains " +
                            "Values ('" + quantity + "','" + RID + "','" + ItemNum + "','" + price + "','" + descount + "');" +
                           " UPDATE SoldAt SET Available = (SELECT Available FROM SoldAt AS OLDSoldAt WHERE SoldAt.ItemsNumber=OLDSoldAt.ItemsNumber AND SoldAt.StID=OLDSoldAt.StID)-" + quantity + " WHERE ItemsNumber='" + ItemNum + "' AND StID=(SELECT St_ID FROM Employee WHERE ID = '" + EmpID + "');" +
                           " UPDATE SoldAt SET Sold = (SELECT Sold FROM SoldAt AS OLDSoldAt WHERE SoldAt.ItemsNumber=OLDSoldAt.ItemsNumber AND SoldAt.StID=OLDSoldAt.StID)+" + quantity + " WHERE ItemsNumber='" + ItemNum + "' AND StID=(SELECT St_ID FROM Employee WHERE ID = '" + EmpID + "');";

            return dbMan.UpdateData(query);
        }

        
         //Function to auto generate the number od the reciept to be issued 
        public Int64 Receipt_AG() 
        {
            string query = " SELECT Count(Receipt#) AS AGReceiptNum FROM Receipt";
            return Int64.Parse(dbMan.ExecuteScalarQuery(query).ToString());
        }


        //function to create a new receipt
        public int CreateNewReceipt(Int64 ID, Double Total_price, Double Discount_price, int MemID, int Em_ID)
        {
            string query = "INSERT INTO Receipt (Receipt#, Total_price, Discount_price, R_Time, R_Date, MemID#, Em_ID) " +
                            "Values ('" + ID + "','" + Total_price + "','" + Discount_price + "','" + DateTime.Now.TimeOfDay + "','" + DateTime.Now.Date + "','" + MemID + "','" + Em_ID + "');";

            return Int32.Parse(dbMan.UpdateData(query).ToString());
        }

        //function to create a new shipment
        public int CreateNewShip(int ID, int SupID)
        {
            string query = "INSERT INTO Shipment (ShipmentID#, Sh_Date, SupID#) " +
                            "Values ('" + ID + "','" + DateTime.Now.Date + "','" + SupID + "');";

            return Int32.Parse(dbMan.UpdateData(query).ToString());
        }

        public int editStore(Int32 ID, Int16 Ohours, string City, string Street, string State)
        {
            string query = "UPDATE Store SET Operating_hours = '" + Ohours + "', St_City = '" + City + "', St_Street = '" + Street + "' , St_State = '" + State + "'Where Store# =" + ID + ";";
            return dbMan.UpdateData(query);
        }


        //shawkyyyyyyyy
        public DataTable EmployeeProfile(int EmpID)
        {
            string query = "SELECT E.ID, E.E_Fname, E.E_Lname, E.E_City, E.E_Street, E.E_State AS E_governorate, E.St_Hours AS Work_Hours, store.St_City AS Store_City, store.St_State AS Store_governorate, S.E_Fname AS Supervisor_Fname, S.E_Lname AS Supervisor_Lname FROM Employee AS E,Employee AS S, Store WHERE E.ID=" + EmpID + " AND E.SuperID=S.ID AND E.St_ID=Store#;";
            return dbMan.ExecuteTableQuery(query);
        }
        //Function to get all items and their info
        public DataTable Items_List()
        {
            string query = "SELECT ItemNO#, Item_discription, Item_detailed_discription, Price, Category, Brand, O_Start AS Offer_start_date, O_End AS Offer_end_date, Value AS Offer_value FROM Items, Offer WHERE Items.OfID=OfferID;";
            return dbMan.ExecuteTableQuery(query);
        }

        public int Edit_Item(Int64 ItemNO, string Item_discription, string Item_detailed_discription, double Price, string Category, string Brand, int OfID)
        {


       
            string query = "UPDATE Items SET Item_discription='" + Item_discription + "', Item_detailed_discription='" + Item_detailed_discription + "', Price=" + Price + ", Category='" + Category + "', Brand='" + Brand + "', OfID=" + OfID + " WHERE ItemNO#=" + ItemNO + " ;";

            return dbMan.UpdateData(query);
        }

        public DataTable Employees_List()
        {
            string query = "SELECT E.ID, E.E_Fname, E.E_Lname, E.E_City, E.E_Street, E.E_State AS E_governorate, E.St_Hours AS Work_Hours, store.St_City AS Store_City, store.St_State AS Store_governorate, S.E_Fname AS Supervisor_Fname, S.E_Lname AS Supervisor_Lname FROM Employee AS E,Employee AS S, Store WHERE E.SuperID=S.ID AND E.St_ID=Store#;";
            return dbMan.ExecuteTableQuery(query);
        }

        public DataTable CustomerProfile(int CustID)
        {
            string query = "SELECT MembershipID#, C_Fname, C_Lname, C_Phone#, SUM(Total_price) AS Total_cutomer_purchases FROM Customer,Receipt WHERE MemID#=MembershipID# AND MembershipID#=" + CustID + " GROUP BY MembershipID#, C_Fname, C_Lname, C_Phone#;";
            return dbMan.ExecuteTableQuery(query);
        }

        public DataTable Customers_List()
        {
            string query = "SELECT MembershipID#, C_Fname, C_Lname, C_Phone#, SUM(Total_price) AS Total_cutomer_purchases FROM Customer,Receipt WHERE MemID#=MembershipID# GROUP BY MembershipID#, C_Fname, C_Lname, C_Phone#;";
            return dbMan.ExecuteTableQuery(query);
        }


        public DataTable Shipments_List()
        {
            string query = "SELECT ShipmentID#, Sh_Date, Supplier.Su_Fname, Supplier.Su_Lname, Supplier.Su_Phone#, Supply_Store.StoreID AS ID_Of_Supplied_Store FROM Shipment, Supplier, Supply_Store WHERE Shipment.SupID#=Supplier.SupplierID# AND Supply_Store.ShipID=Shipment.ShipmentID#;";
            return dbMan.ExecuteTableQuery(query);
        }

        //User input the start and end date to this function to get all sales made during this period 
        public DataTable ItemSold_Period(string StartDate, string EndDate)
        {
            string query = "SELECT * FROM Receipt WHERE R_Date>='" + StartDate + "' AND R_Date<='" + EndDate + "';";
            return dbMan.ExecuteTableQuery(query);
        }

        public DataTable ReciptProfile(int ID)
        {
            string query = "SELECT Item#No AS Item_Number, Item_discription, Quantity , R_Contains.Price ,Discount FROM R_Contains, Receipt, Items WHERE Receipt# =" + ID + " AND Receipt#=ReceiptID AND Item#No=ItemNO#;";
            return dbMan.ExecuteTableQuery(query);
        }
        public DataTable Reciptinfo(int ID)
        {
            string query = "SELECT * FROM Receipt WHERE Receipt# =" + ID + ";";
            return dbMan.ExecuteTableQuery(query);
        }

        public void printR(int ID)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt = ReciptProfile(ID);
            dt2 = Reciptinfo(ID);

            String s = String.Format("");
            s += String.Format(" Recipt ID: ");
            s += ID + "\n";
            s += String.Format(" Date and Time: ");
            s += dt2.Rows[0][4].ToString();
            s += String.Format(" Customer ID: ");
            s += dt2.Rows[0][5].ToString() + "\n";
            s += String.Format(" Cashier ID: ");
            s += dt2.Rows[0][6].ToString() + "\n======================================================\n";
            s += String.Format("{0,5} {1,18} {2,10} {3,9} {4,3}\n======================================================\n\n", "item#", "Name", "Quantity", "Price", "Discount");

            foreach (DataRow R in dt.Rows)
            {
                s += String.Format("{0,5} {1,20} {2,5} {3,12} {4,3}\n\n",
                      R["Item_Number"].ToString(), R["Item_discription"].ToString(), R["Quantity"].ToString(), R["Price"].ToString(), R["Discount"].ToString());
            }
            s += String.Format("=======================================================\n\n");
            s += String.Format("{0,15} {1,30}", "", " total before discount: ");
            s += dt2.Rows[0][1].ToString() + "\n";
            s += String.Format("{0,15} {1,30}", "", " discount: ");
            s += dt2.Rows[0][2].ToString() + "\n";
            s += String.Format("{0,15} {1,30}", "", " total after discount: ");
            s += (Double.Parse(dt2.Rows[0][1].ToString()) - Double.Parse(dt2.Rows[0][2].ToString())).ToString() + "\n\n";
            System.IO.File.WriteAllText(@"..\..\..\recipt.txt", s);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(@"..\..\..\recipt.txt");
            psi.Verb = "PRINT";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(psi);
        }



    }
}
