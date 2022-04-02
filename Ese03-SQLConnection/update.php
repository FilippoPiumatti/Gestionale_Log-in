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
    $con=new mysqli("localhost","root","","assicurazioni");
    if($con->connect_errno)
        die("Errore di connessione al DB MySql. ".$con->connect_errno." ".$con->connect_error);
    $sql="select * from sedi where codSede = $id";
    // il metodo query esegue la query e restituisce il recordset corrispondente
    $rs=$con->query($sql);
    // Controllo l'esistenza del recordset
    if(!$rs)
        die("Errore nell'esecuzione della query. Cancellazione non avvenuta! ".$con->errno." ".$con->error);
    echo("<form><table class='table table-striped'>");
    $jsonData=mysqli_fetch_all($rs,MYSQLI_ASSOC);
    foreach ($jsonData as $item)
        echo("<tr><td>".$item["codSede"] . "</td><td>Nome Sede: <input type='text' name='txtNomeSede' value='".$item["NomeSede"]."' /></td><td>Responsabile Sede: <input type='text' name='txtResp' value='".$item["ResponsabileSede"]."' /></td><td>Città: <input type='text' name='txtCitta' value='".$item["Citta"]."' /></td><td><button type='submit' formmethod='post' formaction='executeUpdate.php?codSede=".$item["codSede"]."' class='btn btn-warning'>Esegui Modifica</button></td></tr>");
    echo("</table></form>");
    $con->close();

    ?>

</body>
