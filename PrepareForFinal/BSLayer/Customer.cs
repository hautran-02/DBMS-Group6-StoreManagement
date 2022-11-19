﻿using PrepareForFinal.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareForFinal.BSLayer
{
    public class Customer
    {
        MyData db = null;
        SqlCommand cmd;

        public Customer()
        {
            db = new MyData();
        }

        public DataSet GetCustomer()
        {
            return db.ExecuteQueryDataSet("Select * from Customer where c_status = 0", CommandType.Text);
        }

        public bool addCustomer(string cid, string name, int gender, DateTime birth, 
            string address, string phone, int point)
        {
            string queryString = "EXEC usp_AddCustomer @cid, @name, @gender, @birth, @address, @phone, @point";

            cmd = new SqlCommand(queryString, db.getSqlConn);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@birth", birth);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@point", point);

            db.openConnectionManager();
            if((cmd.ExecuteNonQuery() == 1))
            {
                db.closeConnectionManager();
                return true;
            }
            else
            {
                db.closeConnectionManager();
                return false;
            }
        }

        public bool updateCustomer(string cid, string name, int gender, DateTime birth,
            string address, string phone, int point, int status)
        {
            string queryString = "EXEC usp_UpdateCustomer @cid, @name, @gender, @birth, @address, @phone, @point, @status";

            cmd = new SqlCommand(queryString, db.getSqlConn);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@birth", birth);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@point", point);
            cmd.Parameters.AddWithValue("@status", status);

            db.openConnectionManager();
            if ((cmd.ExecuteNonQuery() == 1))
            {
                db.closeConnectionManager();
                return true;
            }
            else
            {
                db.closeConnectionManager();
                return false;
            }
        }
        
        public bool deleteCustomer(string id)
        {
            cmd = new SqlCommand("usp_DeleteCustomer @id", db.getSqlConn);
            cmd.Parameters.AddWithValue("@id", id);

            db.openConnectionManager();
            if(cmd.ExecuteNonQuery() == 1)
            {
                db.closeConnectionManager();
                return true;
            }
            else
            {
                db.closeConnectionManager();
                return false;
            }
        }

        public DataSet findCustomer(string cname)
        {
            db.openConnectionManager();

            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand("usp_FindCustomer @sql_findName", db.getSqlConn);
                cmd.Parameters.AddWithValue("@sql_findName", cname);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.closeConnectionManager();
            }

            db.closeConnectionManager();
            return ds;
        }
        public String autoGenerateID()
        {
            string result = "";
            db.openConnectionManager();
            cmd = new SqlCommand("SELECT dbo.[uf_AutoGenerateID](@name)", db.getSqlConn);
            cmd.Parameters.AddWithValue("@name", "Customer");
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            result = dr[0].ToString();
            dr.Close();
            db.closeConnectionManager();
            return result;
        }
    }
}
