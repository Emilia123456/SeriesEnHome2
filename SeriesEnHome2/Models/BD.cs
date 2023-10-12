
using System.Data.SqlClient;
using Dapper;
public class BD{
    private static string _connectionString = @"Server=localhost; DataBase=BDSeries;Trusted_Connection=True;";

 public static List<Serie> ListarSeries(){
        string sql = "SELECT * FROM Series";
        //ir a buscarla AHORA a la base de datos y retornearla
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Serie>(sql).ToList();
        }
    }


 public static List<string> ListarSinopsis(){
        string sql = "SELECT Sinopsis FROM Series";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<string>(sql).ToList();
        }
    }

 public static List<Actor> ListarActores(){
        string sql = "SELECT * FROM Actores";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Actor>(sql).ToList();
        }
    }

 public static List<Temporada> ListarTemporadas(){
        string sql = "SELECT * FROM Temporadas";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Temporada>(sql).ToList();
        }
    }
}

