namespace api.Models
{
    public class DeleteExercise
    {
        public void Delete(string exerciseID){
            Database db = new Database();
            string cs = db.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm= @"UPDATE exercise SET deleted = 1 WHERE exerciseID = @exerciseID";

            using var cmd = new MySqlConnection(stm, con);

            cmd.Parameters.AddWithValue("@exerciseID", exerciseID);
            cmd.Prepare();

            cmd.ExcecuteNonQuery();
        }
    }
}