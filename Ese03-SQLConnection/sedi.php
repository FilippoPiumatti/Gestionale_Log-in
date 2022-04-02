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
    <h1 align = "center">Elenco delle Filliali</h1>
    <?php
        $idAss = $_GET["codAssicurazione"];
        echo($idAss);
        //apro connessione
        $con = new mysqli("localhost","root","","assicurazioni");
        //chekko la connesione
        if ($con->connect_errno != 0) {
            die("errore di connesione al DB MySQL" .$con->connect_errno. " "
             .$con->connect_error);// termina esecuzione di index.php, blocca lo script
         }

         $sql = "SELECT * FROM sedi WHERE codAssicurazione = $idAss";

         $rs = $con->query($sql); // metto il contenuto del record set ($rs) nella variabile $rs
         if (!$rs) {
             die("Errore nell' esecuzione della query.  " .$con->errno." ".$con->error);
         }
    ?>
     <form><table class="table">
        <thead>
            <tr>
             <th scope="col">CodSede</th>
             <th scope="col">NomeSede</th>
             <th scope="col">Responsabile</th>


             <th scope="col">Città</th>
             <th scope="col">CodAssicurazione</th>
             <th scope="col">Update</th>
             <th scope="col">Delete</th>
            </tr>
        </thead>
        <tbody>
            <?php
                while ($record = $rs->fetch_assoc()) {//prende per ogni tuo elemento del record la prende e la trasforma in un vettore associativo
                    echo ('<tr>');
                    echo ('<td>'. $record['codSede'] .'</td>');
                    echo ('<td>'. $record['NomeSede'] .'</td>');
                    echo ('<td>'. $record['ResponsabileSede'] .'</td>');
                    echo ('<td>'. $record['Citta'] .'</td>');
                    echo ('<td>'. $record['codAssicurazione'] .'</td>');
                    echo("<td><button class='btn btn-warning' type='submit' formmethod= 'post' formaction = 'update.php?codSede=".$record["codSede"]."'> Update </button></td>");
                    echo("<td><button class='btn btn-danger' type='submit' formmethod= 'post' formaction = 'delete.php?codSede=".$record["codSede"]."'> Delete </button></td>");
                    //facciamo un collegamento ad una pagina esterna php dove andro a lavorare passandoli come parametrio cod assicurazione
                    echo ('</tr>');
                }

                $con->close();
            ?>
         </tbody>
    </table></form>
    <button class="btn btn-primary"  onclick="window.location.href = 'inserisciFilliale.html' ">inserisci filliale</button>

</body>