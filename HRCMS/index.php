<?php
	require_once("Includes/db.php");
	
	session_start();
	if (array_key_exists("user", $_SESSION))
	{
		header('Location: main.php');
		exit;
	}
	
	if ($_SERVER['REQUEST_METHOD'] == "POST")
	{
		$login_success = (CmsDB::getInstance()->login($_POST['user'], $_POST['password']));
		
		if ($login_success)
		{
			$_SESSION['user'] = $_POST['user'];
			$result = mysqli_fetch_array(CmsDB::getInstance()->get_user_type_by_username($_POST['user']));
			$_SESSION['user_type'] = $result['user_type'];
			header('Location: main.php');
			exit;
		}
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
			<div id="login-banner">
				<a href="index.php"><img style="border: none;" src="css/images/ogilvy_logo.png"></a>
			</div>
			<div id="content">
				<div id="login">
				<form action="index.php" method="post">
				<table>
					<tr><th align="left">Log in</th></tr>
					<tr><td>Username: </td><td><input type="text" name="user"></td></tr>
					<tr><td>Password: </td><td><input type="password" name="password"></td></tr>
					<tr><td></td><td><input type="submit" value="Login"></td></tr>
				</table>
				<?php
					if ($_SERVER['REQUEST_METHOD'] == "POST")
					{
						if (!$login_success)
						{
							echo '<div class="error_message">Incorrect username or password.</div>';
						}
					}
				?>
				</form>
				</div>
			</div>
		</div>
		<?php include 'Includes/footer.html'; ?>
	</body>
</html>