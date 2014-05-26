using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;


namespace Communicator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IProductRESTService" in code, svc and config file together.
    public class IProductRESTService : IIProductRESTService
    {

        
       
        Products obj = new Products();
        public List<Product> GetProductList()
        {
            return obj.ProductList;
        }

        public List<info> selectAll()
        {
            SqlConnection conn = ConnectionManager.getConnection();
            string query = "select * from Info  ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reads = cmd.ExecuteReader();
            List<info> lst=new List<info>();
            while (reads.Read()) {
                lst.Add(new info() { 
                Cid=reads["ids"].ToString(),
                Cname=reads["name"].ToString()
                
                
                });
            }


            return lst;


        }
        public List<info> selectAllbyName(string name)
        {
            SqlConnection conn = ConnectionManager.getConnection();
            string query = "select * from Info where name ='" + name + "' ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reads = cmd.ExecuteReader();
            List<info> lst = new List<info>();
            while (reads.Read())
            {
                lst.Add(new info()
                {
                    Cid = reads["ids"].ToString(),
                    Cname = reads["name"].ToString()


                });
            }


            return lst;


        }

        public List<info> GetAllCustomers()
        { 
            infoDBDataContext dc = new infoDBDataContext();
            List<info> results = new List<info>();

            foreach (info cust in dc.infos)
            {
                
                results.Add(new info()
                {
                    Cid = cust.ids,
                    Cname= cust.name,
                   
                });
            }

           // var q = dc.infos.Where(x => x.Cname == "q").ToList();
           // var a = (from x in dc.infos
           //          where x.Cname == "q"
           //          select new info()
           // {
           //Cid= x.ids,
           // Cname= x.name
           // }).ToList();
 
            //  where (e.EmployeeID == empId)
            //list.Where(s => s.StartsWith(startingChar))
            return results;
        }

        public int UpdateOrderAddress(Stream JSONdataStream)
        {
            try
            {
                // Read in our Stream into a string...
                StreamReader reader = new StreamReader(JSONdataStream);
                string JSONdata = reader.ReadToEnd();

                // ..then convert the string into a single "wsOrder" record.
                JavaScriptSerializer jss = new JavaScriptSerializer();
                insertInfo order = jss.Deserialize<insertInfo>(JSONdata);
                if (order == null)
                {
                    // Error: Couldn't deserialize our JSON string into a "wsOrder" object.
                    return -2;
                }

                //do whatever u want to do
                SqlConnection con = ConnectionManager.getConnection();
                con.Open();
                string query = "insert into info values('"+order.insertId+"','"+order.insertName+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 0;     // Success !
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
