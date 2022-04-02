"use strict"
//altro modo per chiamare il document ready
$(() => {
    //trasmissione dei dati tramite get: senza privacy (visibili nel URL)
    //trasmissione dei dati tramite post: con privacy (non visibili nel URL)
    $("#cmbResidenza").val([]); // per svuotare la combo
    console.log("indice della combo selezionato: " + $("#cmbResidenza").prop("selectedIndex"));
    $("#btnJq").on("click",function(){

        let DatiOk = true;
        let ErrMessage = "";
        /* controllo dei campi textbox */
        if ($("#txtCognome").val()=="") {
            DatiOk = false;
            ErrMessage += "inserire il valore del Cognome..<br>";
        }

        if ($("#txtNome").val()=="") {
            DatiOk = false;
            ErrMessage += "inserire il valore del Nome..<br>";
        }

        /** controllo radio button */
        if ($("input[type = radio]:checked").length==0) {//"se nessun radio è selezionato"
            DatiOk = false;
            ErrMessage += "selezionare il livello di formazione..<br>"
        }

        /** controllo checkbox */
        if ($("input[type = checkbox]:checked").length==0) {//"se nessun radio è selezionato"
            DatiOk = false;
            ErrMessage += "selezionare almeno un ambito di sviluppo..<br>";
        }

        if ($("#cmbResidenza").prop("selectedIndex")==-1) {
            DatiOk = false;
            ErrMessage += "selezionare la provincia di residenza..<br>";
        }

        if (DatiOk==true) {
            $("#pErr").html("");
            let FrmInviaJq = $("#fmrReg");
            FrmInviaJq.prop("method","get");
            FrmInviaJq.prop("action","dati.php");
            FrmInviaJq.submit();//metodo che simula un bottone di submit
        }else{
            $("#pErr").html(ErrMessage)
        }

    })
});