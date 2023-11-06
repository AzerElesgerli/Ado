using AdoNet.Models;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conn = "server=WINDOWS-JUPQ502;database=TasK ;trusted_connection=true;integrated security=true;";

            SqlConnection connection = new SqlConnection(conn);
            



             void DeleteMusic()
            {
                connection.Open();
                string SQL = "DELETE FROM Categories WHERE MusicId=1";
            SqlCommand command = new SqlCommand(SQL, connection);
                command.ExecuteNonQuery();

            }
            void CreateMusic()
            {
                connection.Open();
                string Query = "INSERT INTO Musics (Name, Duration, CategoryId) VALUES (@Name, @Duration, @CategoryId)";
                SqlCommand command = new SqlCommand(Query, connection);
                command.ExecuteNonQuery();

            }
            void GetAll()
            {
                connection.Close();
                string Query = "Select * From Musics";
                SqlCommand command = new SqlCommand(Query, connection);
                command.ExecuteNonQuery();


            }
             Musics GetMusicById(int id) 
            {
                connection.Close();

                string query = "SELECT * FROM Musics WHERE MusicId = @MusicId";
                SqlCommand command = new SqlCommand(query, connection);
                foreach (DataRow row in )
                Music music = new Music
                         MusicId = (int)row["MusicId"],
                         Name = row["Name"].ToString(),
                         Duration = Convert.ToInt32(["Duration"]),
                         CategoryId = (int)row["CategoryId"])


            }


        }
    }
}