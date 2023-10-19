
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

public static Serie GetSerie(int id){
        
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series WHERE IdSerie=@id ";
            return db.QueryFirstOrDefault<Serie>(sql, new {id});
        }
    }

 public static List<Actor> ListarActores(int id){
        string sql = "SELECT * FROM Actores WHERE IdSerie = @id";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Actor>(sql, new {id}).ToList();
        }
    }

 public static List<Temporada> ListarTemporadas(int id){
        string sql = "SELECT * FROM Temporadas WHERE IdSerie = @id";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            return db.Query<Temporada>(sql, new{id}).ToList();
        }
    }
}

