using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SpaceExplorationGameDatabase {
    public class Database {
        
        public MySqlConnection Connection() { 
            try {
                string MySqlCon = "server=127.0.0.1; user=root; Database=characterdatabase; password=";
                MySqlConnection mySqlConnection = new MySqlConnection(MySqlCon);
                mySqlConnection.Open();
                Console.WriteLine("Success");
                return mySqlConnection;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public bool Create(string TableName, Dictionary<string, object> Object)  {
            using (MySqlConnection mySqlConnection = Connection()) {
                if (mySqlConnection == null) {
                    return false;
                }

                var Columns = new List<string>();
                var Values = new List<string>();
                var Parameters = new List<MySqlParameter>();

                foreach (var Property in Object) {
                    Columns.Add(Property.Key);
                    Values.Add("?");
                    object Value = Property.Value ?? DBNull.Value;
                    Parameters.Add(new MySqlParameter($"@{Property.Key}", Value));
                }

                string Query = $"INSERT INTO {TableName} ({string.Join(", ", Columns)}) VALUES ({string.Join(", ", Values)})";
                Console.WriteLine("Generated Query: " + Query);

                try {
                    using (MySqlCommand Command = new MySqlCommand(Query, mySqlConnection)) {
                        Command.Parameters.AddRange(Parameters.ToArray());
                        int Result = Command.ExecuteNonQuery();
                        Console.WriteLine("Rows Affected: " + Result);
                        return Result > 0;
                    }
                } catch(Exception e) {
                    Console.WriteLine($"Query Error: {e.Message}");
                    return false;
                }            
            }
        }

        public bool Delete(string TableName, int Id) {
            using (MySqlConnection MySqlConnection = Connection()) { 
                if (Connection ==  null) { 
                    return false; 
                }

                string Query = $"DELETE FROM {TableName} WHERE id = @id";

                try {
                    using (MySqlCommand Command = new MySqlCommand(Query, MySqlConnection)) {
                        Command.Parameters.AddWithValue("id", Id);
                        int Result = Command.ExecuteNonQuery();
                        Console.WriteLine("Rows Affected: " + Result);
                        return Result > 0;
                    }
                } catch (Exception e) {
                    Console.WriteLine($"Query Error: {e.Message}");
                    return false;
                }
            }        
        }

        //public List<Dictionary<string, object>> GetData() {

        //}
    }
}
