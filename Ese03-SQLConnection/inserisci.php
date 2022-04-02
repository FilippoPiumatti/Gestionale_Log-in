<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
</head>
<body>
<h1>Inserimento di una nuova Sede </h1>
    <?php
        $codAss = $_POST["txtCod"];//metto tutti i name dei textbox come parametri
        $NomeAss = $_POST["txtNome"];
        $Citta = $_POST["txtCitta"];

        $con=new mysqli("localhost","root","","assicurazioni");
        if($con->connect_errno)
            die("Errore di connessione al DB MySql. ".$con->connect_errno." ".$con->connect_error);
        $sql="INSERT INTO assicurazioni VALUES('$codAss','$NomeAss','$Citta')";

        // il metodo query esegue la query e restituisce il recordset corrispondente
        $rs=$con->query($sql);
        // Controllo l'esistenza del recordset
        if (!$rs) {
            echo("inserimento non avvenuto");
        }
        else{
            echo("<h3>Sede assicurazione inserita correttamente</h3>");
        }
        echo("<h3><a href='index.php'>Torna alla Home Page</a></h3>");
        $con = $con->close();
    
    ?>

</body>
