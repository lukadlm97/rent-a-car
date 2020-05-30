using rent_a_car.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace rent_a_car.DatabaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlTransaction transaction;
        private SqlDataReader reader;

        private static Broker instance;

        public static Broker Instance
        {
            get
            {
                if (instance == null)
                    instance = new Broker();
                return instance;
            }
        }

        private Broker() { }

        public void OpenConnection()
        {
            try
            {
                connection = new SqlConnection(@"");
                connection.Open();
            }
            catch (Exception)
            {
                
            }
        }

        public void StartTransaction()
        {
            try
            {
                transaction = connection.BeginTransaction();
                command = new SqlCommand("", connection, transaction);
            }
            catch (Exception)
            {

            }
        }

        public void CommitTransaction()
        {
            try
            {
                transaction.Commit();
            }
            catch (Exception)
            {

            }
        }

        public void RollbackTransaction()
        {
            try
            {
                transaction.Rollback();
            }
            catch (Exception)
            {

            }
        }

        public void CloseTransaction()
        {
            try
            {
                connection.Close();
            }
            catch (Exception)
            {

            }
        }

        public void Insert(DomainObject domainObject)
        {
            try
            {
                command.CommandText = $"INSERT INTO {domainObject.TableName} {domainObject.Insert}";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }

        public void DeleteOne(DomainObject domainObject)
        {
            try
            {
                command.CommandText = $"DELETE FROM {domainObject.TableName} WHERE {domainObject.ConditionID}";
                command.ExecuteNonQuery();
            }
            catch(Exception)
            {

            }
        }

        public List<DomainObject> GetAll(DomainObject domainObject)
        {
            List<DomainObject> lists = new List<DomainObject>();

            try
            {
                command.CommandText = $"SELECT * FROM {domainObject.TableName}";
                reader = command.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                foreach(DataRow row in table.Rows)
                {
                    lists.Add(domainObject.ReadRowOfTable(row));
                }

                reader.Close();

                return lists;
            }
            catch (Exception)
            {
                reader.Close();
                throw;
            }
        }

        public int GetID(DomainObject domainObject)
        {
            try
            {
                command.CommandText = $"SELECT MAX({domainObject.ID}) FROM {domainObject.TableName}";

                try
                {
                    return Convert.ToInt32(command.ExecuteScalar()) + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }





    }
}
