using MySql.Data.MySqlClient; // Add this using directive for MySqlConnection

namespace api.Models
{
    public class AddExercise
    {
        public void Add(Activities exercises){
            Database db = new Database();
            string cs = db.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO exercise (exerciseID, activity, distance, date, pinned, deleted) VALUES(@exerciseID, @activity, @distance, @date, @pinned, @deleted)";

            using var cmd = new MySqlConnection(stm,con);

            cmd.Parameters.AddWithValue("@exerciseID", exercises.exerciseID);
            cmd.Parameters.AddWithValue("@actvity", exercises.activity);
            cmd.Parameters.AddWithValue("@distance", exercises.distance);
            cmd.Parameters.AddWithValue("@date",exercises.date);
            cmd.Parameters.AddWithValue("@pinned", exercises.pinned);
            cmd.Parameters.AddWithValue("@deleted", exercises.deleted);

            cmd.Prepare();
            cmd.ExcecuteNonQuery();
        }
    }
}