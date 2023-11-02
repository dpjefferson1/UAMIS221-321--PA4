
namespace api.Models
{
    public class GetExercise
    {
       public List<Activities> GetAllExercises(){
        List<Activities> exercise = new List<Activities>();

        Database db = new Database();
        string cs = db.cs;

        using var con = new MySqlConnection(cs);
        con.Open();

        string stm = @"SELECT * FROM vh3klcht3gjfelxy.exercise ORDER BY date desc;";

        using var cmd = new MySqlCommand(stm, con);

        using MySqlDataReader rdr = cmd.ExecuteReader();

        while(rdr.Read()){
            exercises.Add(new Activities(){
                exerciseID = rdr.GetString(0);
                activity = rdr.GetString(1);
                distance = rdr.GetString(2);
                date = rdr.GetDateTime(3);
                pinned = rdr.GetBoolean(4);
                deleted = rdr.GetBoolean(5)
            });
        }
        return exercises;
       } 
    }
}