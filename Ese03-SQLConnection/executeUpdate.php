<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <title>MySQL Connection</title>
</head>

<body>
    <h1>Update di una filiale</h1>
    <?php
    $id=$_GET["codSede"];
    $nomeSede=$_POST["txtNomeSede"];
    $resp=$_POST["txtResp"];
    $citta=$_POST["txtCitta"];
    $con=new mysqli("localhost","root","","assicurazioni");
    if($con->connect_errno)
    die("Errore di connessione al DB MySql. ".$con->connect_errno." ".$con->connect_error);
    $sql="update sedi set NomeSede = '$nomeSede', ResponsabileSede = '$resp', Citta = '$citta' where codSede = $id";
    // il metodo query esegue la query e restituisce il recordset corrispondente
    $rs=$con->query($sql);
    // Controllo l'esistenza del recordset
    if(!$rs)
        die("Errore nell'esecuzione della query. Aggiornamento sede non avvenuto! ".$con->errno." ".$con->error);
    else{
        echo("<h3>Sede assicurazione aggiornata correttamente</h3>");
        echo("<h3><a href='index.php'>Torna alla Home Page</a></h3>");
    }
    $con->close();
    ?>
</body>