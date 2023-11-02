using api.Models;
using api.DataAccess;
using api.MySql.MySqlClient;

namespace api.Models
{
    public class PinExercise
    {
        public void Pin(string exerciseID){
            Database db = new Database();
            string cs = db.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE exercise SET pinned = 1 WHERE exerciseID = @exerciseID";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@exerciseID" , exerciseID);
            cmd.Prepare();

            cmd.ExcecuteNonQuery();
        }

        public void Unpin(string exerciseID){
            Database db = new Database();
            string cs = db.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE exercise SET pinned = 1 WHERE exerciseID = @exerciseID";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@exerciseID" , exerciseID);
            cmd.Prepare();

            cmd.ExcecuteNonQuery();
        }

    }
}