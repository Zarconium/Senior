<?php
	require_once("Includes/db.php");
	
	session_start();
	if (!array_key_exists("user", $_SESSION))
	{
		header('Location: index.php');
		exit;
	}
?>

<!DOCTYPE html>
<html>
	<head>
		<title>Ogilvy HR CMS</title>
		<link rel="stylesheet" href="css/style.css">
	</head>
	<body>
		<div id="main">
			<?php include 'Includes/navbar.php';?>
			<div id="content">
				<div id="message">
					<p class="message">"If you hire people bigger than you are,<br>we shall become a company of giants."</p>
					<p class="source">-David Ogilvy</p>
					<a id="url" href="http://www.ogilvyone.com.ph/careers.php"><p class="url">ogilvyone.com.ph/careers</p></a>
				</div>
			</div>
		</div>
		<?php include 'Includes/footer.html'; ?>
	</body>
</html>