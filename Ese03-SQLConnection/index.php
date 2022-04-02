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
    <?php
    //N:B. mai usare un else con la die, perchè se no blocca tutto il resto!!!!
        // L oggetto MySQLi ci permette la connessione con sql
        $con = new mysqli("localhost","root","","assicurazioni"); // 4 parametri : server, mysql, password ??, db
        //se errno è diverso da 0 allora la connessione non è riuscita
        if ($con->connect_errno != 0) {
           die("errore di connesione al DB MySQL" .$con->connect_errno. " "
            .$con->connect_error);// termina esecuzione di index.php, blocca lo script
        }
        $sql = "select * from assicurazioni";
        //il metodo query() esegue la query è restituisce le cose corrispondenti ad essa
        $rs = $con->query($sql); // metto il contenuto del record set ($rs) nella variabile $rs
        if (!$rs) {
            die("Errore nell' esecuzione della query." .$con->errno." ".$con->error);
        }
        //echo("<h1> Ciclo forEach + MYSQLI_ASSOC()</h1>");
       // $jsonData = mysqli_fetch_all($rs,MYSQLI_ASSOC);//prendi il record set e trasformalo in un vet associativo
        /*foreach ($jsonData as $item) {
            echo($item["codAssicurazione"] . " - " . $item["NomeAssicurazione"] . " - " . $item["Citta"] . "<br>");
        }*/
       /* echo("<h1> Ciclo while + fetch_assoc()</h1>");
        while ($record = $rs->fetch_assoc()) {//prende per ogni tuo elemento del record la prende e la trasforma in un vettore associativo
            echo($record["codAssicurazione"] . " - " . $record["NomeAssicurazione"] . " - " . $record["Citta"] . "<br>");
        }*/

    ?>
    <form><table class="table">
        <thead>
            <tr>
             <th scope="col">CodAssicurazione</th>
             <th scope="col">NomeAssicurazione</th>
             <th scope="col">Città</th>
            </tr>
        </thead>
        <tbody>
            <?php
                while ($record = $rs->fetch_assoc()) {//prende per ogni tuo elemento del record la prende e la trasforma in un vettore associativo
                    echo ('<tr>');
                    echo ('<td>'. $record['codAssicurazione'] .'</td>');
                    echo ('<td>'. $record['NomeAssicurazione'] .'</td>');
                    echo ('<td>'. $record['Citta'] .'</td>');
                    //facciamo un coollegamento ad una pagina esterna php dove andro a lavorare passandoli come parametrio cod assicurazione
                    echo("<td><button class='btn btn-primary' type='submit' formmethod= 'post' formaction = 'sedi.php?codAssicurazione=".$record["codAssicurazione"]."'> filliali </button></td>");
                    echo ('</tr>');
                }
                echo("</tbody>
                </table></form>");
                $con->close();
            ?>
           
         
    <button class="btn btn-primary"  onclick="window.location.href = 'inserisci.html' ">inserisci ass</button>
</body>