"use strict"
$(document).ready(function(){
    //l idi per pasare i parametri a jquery
    //il name per php
    $("#msg").hide();
    $("#msg1").hide();
    
    $("#btnInsert").on("click",function(){
        if ($("#txtCodAss").val() == "" || $("#txtNomeAss").val() == "" || 
             $("#txtCittaAss").val() == "") {
                 $("#msg").show();
        }
        else{

            let frm = $("form");
            frm.prop("action","inserisci.php");
            frm.prop("method","post");
            frm.submit();
        }
    });   
    $("#btnInsertS").on("click",function(){

        if ($("#txtCodSede").val() == "" || $("#txtNomeSede").val() == "" || 
        $("#txtCittaSede").val() == "" || $("#txtResponsabileSede").val()== "" || $("#txtCodAssSede").val()== "") {
            $("#msg1").show();
         }  else{
            let frm = $("form");
            frm.prop("action","inserisciFilliale.php");
            frm.prop("method","post");
            frm.submit();
         }  
    }) 
})