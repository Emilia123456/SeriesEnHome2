    $.ajax(   
        {   
            url:'/Home/VerSinopsis',
                    
            data: {IdSerie: IdS},
            type: 'GET',
            dataType: 'json',

            success: function(response){
                $("#Sinopsis").html(response.nombre);
            },
            error: function(xhr, status){
                alert('Ooops!, hubo un problema :(');
            },
            complete : function(xhr, status){
               console.log('Petición realizada')
            }
                
        }
            
    );