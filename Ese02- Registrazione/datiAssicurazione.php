<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta content="width=device-width, initial-scale=1.0" name="viewport">

    <title>Sondaggio Informatico</title>
    <!-- Favicons -->
    <link href="assets/img/hero-logo.png" rel="icon">
    <link href="assets/img/apple-touch-icon.png" rel="apple-touch-icon">

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Montserrat:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet">

    <!-- Vendor CSS Files -->
    <link href="assets/vendor/aos/aos.css" rel="stylesheet">
    <link href="assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="assets/vendor/bootstrap-icons/bootstrap-icons.css" rel="stylesheet">
    <link href="assets/vendor/boxicons/css/boxicons.min.css" rel="stylesheet">
    <link href="assets/vendor/glightbox/css/glightbox.min.css" rel="stylesheet">
    <link href="assets/vendor/swiper/swiper-bundle.min.css" rel="stylesheet">

    <!-- Template Main CSS File -->
    <link href="assets/css/style.css" rel="stylesheet">

    <!-- Vendor JS Files -->
    <script src="assets/vendor/aos/aos.js"></script>
    <script src="assets/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="assets/vendor/glightbox/js/glightbox.min.js"></script>
    <script src="assets/vendor/isotope-layout/isotope.pkgd.min.js"></script>
    <script src="assets/vendor/php-email-form/validate.js"></script>
    <script src="assets/vendor/swiper/swiper-bundle.min.js"></script>

    <link href="css/index.css" rel="stylesheet">

    <!-- Template Main JS File -->
    <script src="assets/js/main.js"></script>

    <!-- My JS -->
    <script src="https://code.jquery.com/jquery-3.5.1.js"></script>
    <script src="js/libreria.js" type="text/javascript"></script>
    <script src="js/index.js" type="text/javascript"></script>
</head>

<body>

    <!-- ======= Hero Section ======= -->
    <section id="hero">
        <div class="hero-container">
            <a href="index.html" class="hero-logo" data-aos="zoom-in"><img src="assets/img/hero-logo.png" alt=""></a>
            <h1 data-aos="zoom-in">Welcome to the TPSI PHP Course</h1>
            <h2 data-aos="fade-up">Classe 4 Info D</h2>
        </div>
    </section><!-- End Hero -->

    <section id="sondaggio" class="container">
        <div><h1>Assicurazioni</h1></div>
        <section class="container">
        <h1>Assicurazione Inserita correttamente </h1>
    </section>
    <section class="container" id="dati">
        <h2>Dati relativi all assicurazione</h2>
        <p class="lblCod">Codice Sede : 
            <?php
                if (isset($_POST["txtCodIns"])&&$_POST["txtCodIns"]!="") {
                   echo($_POST["txtCodIns"]);
                }
                else {
                    echo("Campo Non Compilato..");
                }
               
            ?>
        </p>
        <p class="lblCod">Nome Sede : 
            <?php
                if (isset($_POST["txtNomeIns"])&&$_POST["txtNomeIns"]!="") {
                    echo($_POST["txtNomeIns"]);
                }
                else {
                    echo("Campo Non Compilato..");
                }
            ?>
        </p>
        <p class="lblCod">Responsabile : 
            <?php
                 if (isset($_POST["txtResp"])&&$_POST["txtResp"]!="") {
                    echo($_POST["txtResp"]);
                }
                else {
                    echo("Campo Non Compilato..");
                }
            ?>
        </p>
        <p class="lblCod"> Città : 
            <?php
                 if (isset($_POST["txtCittaIns"])&&$_POST["txtCittaIns"]!="") {
                    echo($_POST["txtCittaIns"]);
                }
                else {
                    echo("Campo Non Compilato..");
                }
            ?>
        </p>
        <p class="lblCod">Tipo Assicurazione: 
            <?php
                 if (isset($_POST["txtCodTipoIns"])&&$_POST["txtCodTipoIns"]!="") {
                    echo($_POST["txtCodTipoIns"]);
                }
                else {
                    echo("Campo Non Compilato..");
                }
            ?>
        </p>
    </section>
    </section>
