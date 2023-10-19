function MostrarTemporadas(id){
    $.ajax(  
        {   
            url:'/Home/MostrarTemporadas',
            data: {IdSerie: id},
            type: 'GET',
            dataType: 'json',

            success: function(response){
                console.log(response);
                let text = "";
                response.forEach(element => {
                    text += element.tituloTemporada;
                    text += " | ";
                });
                $("#Temporadas").html(text);
                
            },
            error: function(xhr, status){
                alert('Ooops!, hubo un problema :(');
            },
            complete : function(xhr, status){
                console.log('Petición realizada');
            }
                
        }
    );
}

function MostrarActores(id){
    $.ajax(  
        {   
            url:'/Home/MostrarActores',
            data: {IdSerie: id},
            type: 'GET',
            dataType: 'json',

            success: function(response){
                console.log(response);
                let text = "";
                response.forEach(element => {
                    text += element.nombre;
                    text += " | ";
                });
                $("#Actores").html(text);
                
            },
            error: function(xhr, status){
                alert('Ooops!, hubo un problema :(');
            },
            complete : function(xhr, status){
                console.log('Petición realizada');
            }
                
        }
    );
}

function MostrarMasInfo(id){
    $.ajax({   
        url:'/Home/MostrarMasInfo',
        data: {IdSerie: id},
        type: 'GET',
        dataType: 'json',

        success: function(response){
            $("#Sinopsis").html(response.sinopsis);
        },
        error: function(xhr, status){
            alert('Ooops!, hubo un problema :(');
        },
        complete : function(xhr, status){
            console.log('Petición realizada')
        }
            
    });
}
