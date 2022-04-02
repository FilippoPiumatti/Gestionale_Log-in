<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <title>SQLConnection</title>
</head>

<body>
    <h1 align ="center">DELETE DI UNA FILLIALE</h1>
    <?php
    $id=$_GET["codSede"];
    $con=new mysqli("localhost","root","","assicurazioni");
    if($con->connect_errno)
        die("Errore di connessione al DB MySql. ".$con->connect_errno." ".$con->connect_error);
    $sql="delete from sedi where codSede = $id";
    // il metodo query esegue la query e restituisce il recordset corrispondente
    $rs=$con->query($sql);
    // Controllo l'esistenza del recordset
    if(!$rs)
        die("Errore nell'esecuzione della query. Cancellazione non avvenuta! ".$con->errno." ".$con->error);
    else{
        header("location:index.php");
    }
    $con->close();
    ?>
</body>