﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Create_items.AppCode;

namespace Create_items
{
    public class createItemManager
    {
        internal static void saveItemInfo(AppCode.createItemInfo acreateItemInfo)
        {
            SqlConnection connection = new SqlConnection(DBManager.OraConnString());
            SqlTransaction transaction;
            try
            {
                // int success = 0, MstId = 0;
                connection.Open();
                transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;

                command.CommandText = @"
                INSERT INTO [dbo].[createItems]  ([itemCode],[itemName],[itemShortName],[SizeID],[CategoryID],[subCategoryID])
                     VALUES('" + acreateItemInfo.itemCode + "','" + acreateItemInfo.itemFulName + "','" + acreateItemInfo.itemShortName + "','" + acreateItemInfo.sizeID + "','" + acreateItemInfo.CatagryID + "','" + acreateItemInfo.subCatagoryID + "')";
                                command.ExecuteNonQuery();

               

                transaction.Commit();
                //return MstId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
            //throw new NotImplementedException();
        }



        internal static DataTable ShowItem()
        {
            SqlConnection connection = new SqlConnection(DBManager.OraConnString());
            SqlTransaction transaction;
            try
            {
                DataTable dataTable = new DataTable();
                // int success = 0, MstId = 0;
                connection.Open();
                transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;

                command.CommandText = @"Select * from createItems";
                //command.ExecuteQuery();

                SqlDataAdapter da = new SqlDataAdapter(command);
                // this will query your database and return the result to your datatable
                da.Fill(dataTable);
                da.Dispose();
                transaction.Commit();
                return dataTable;
                //return MstId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
        }


        internal static AppCode.createItemInfo getItemInfoDetails(string mstid)
        {
            SqlConnection connection = new SqlConnection(DBManager.OraConnString());
            SqlTransaction transaction;
            try
            {
                DataTable dataTable = new DataTable();
                // int success = 0, MstId = 0;
                connection.Open();
                transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;

                command.CommandText = @"Select * from createItems where id='" + mstid + "'";
                //command.ExecuteQuery();

                SqlDataAdapter da = new SqlDataAdapter(command);
                // this will query your database and return the result to your datatable
                da.Fill(dataTable);
                da.Dispose();
                transaction.Commit();

                if (dataTable.Rows.Count == 0)
                {
                    return null;
                }
                return new createItemInfo(dataTable.Rows[0]);    //bujte hobe 

            }
            catch (Exception ex)
            {
                return null;
            }
           // throw new NotImplementedException();
        }

        internal static int DeleteItemInfo(createItemInfo acreateItemInfo)
        {
            SqlConnection connection = new SqlConnection(DBManager.OraConnString());
            SqlTransaction transaction;
            try
            {
                // int success = 0, MstId = 0;
                connection.Open();
                transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;

                command.CommandText = @"
                delete from [dbo].[createItems] where id='" + acreateItemInfo.ID + "'";
                command.ExecuteNonQuery();



                transaction.Commit();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
            throw new NotImplementedException();
        }

        internal static int updateItem(createItemInfo acreateItemInfo)
        {
            SqlConnection connection = new SqlConnection(DBManager.OraConnString());
            SqlTransaction transaction;
            try
            {
                // int success = 0, MstId = 0;
                connection.Open();
                transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;

                command.CommandText = @"
                Update [dbo].[createItems] set itemCode='" + acreateItemInfo.itemCode + "' , itemName='" + acreateItemInfo.itemFulName + "',itemShortName='" + acreateItemInfo.itemShortName + "',SizeID='" + acreateItemInfo.sizeID + "',CategoryID='" + acreateItemInfo.CatagryID + "',subCategoryID='" + acreateItemInfo.subCatagoryID + "' where id='" + acreateItemInfo.ID + "'";
                command.ExecuteNonQuery();



                transaction.Commit();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
            throw new NotImplementedException();
        }


        internal static object GetCatagory(string p)
        {
            string ConnectinString = DBManager.OraConnString();
            string query = "SELECT * from Category";
            var data = DBManager.ExecuteQuery(ConnectinString, query, "Category");
            return data;
        }

        internal static object GetSubCatagory(string catagoryID)
        {
            string ConnectinString = DBManager.OraConnString();
            string query = "SELECT * FROM [firstTestProject].[dbo].[SubCategory] where CategoryID='" + catagoryID + "'";
            var data = DBManager.ExecuteQuery(ConnectinString, query, "SubCategory");
            return data;
        }

        internal static object GetSize(string p)
        {
            string ConnectinString = DBManager.OraConnString();
            string query = "SELECT * from Size";
            var data = DBManager.ExecuteQuery(ConnectinString, query, "Size");
            return data;
        }
    }
}