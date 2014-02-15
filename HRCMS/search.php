<?php
	require_once("Includes/db.php");
	
	session_start();
	if (!array_key_exists("user", $_SESSION))
	{
		header('Location: index.php');
		exit;
	}
	
	$searchtype = "all";
	if ($_SERVER['REQUEST_METHOD'] == 'POST')
	{
		$searchtype = $_POST['searchtype'];
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
				<form name="main" action="main.php">
					<input id="main-button" type="submit" value="Back to main">
				</form>
				<br><br>
				<?php
					switch ($searchtype)
					{
						case "all":
							if (!isset($_POST['search']) || strlen(trim($_POST['search'])) == 0)
							{
								$result = CmsDB::getInstance()->get_all_resumes_alphabetical_order();
							}
							else
							{
								$result = CmsDB::getInstance()->search($_POST['search']);
							}
							break;
						case "name":
							$result = CmsDB::getInstance()->get_all_resumes_by_name($_POST['search']);
							break;
						case "skill":
							$result = CmsDB::getInstance()->get_all_resumes_by_skill($_POST['search']);
							break;
						case "position":
							$result = CmsDB::getInstance()->get_all_resumes_by_position($_POST['search']);
							break;
						case "course":
							$result = CmsDB::getInstance()->get_all_resumes_by_course($_POST['search']);
							break;
						case "year":
							$result = CmsDB::getInstance()->get_all_resumes_by_year_graduated($_POST['search']);
							break;
						case "interviewed":
							$result = CmsDB::getInstance()->get_all_interviewed_resumes();
							break;
						case "notinterviewed":
							$result = CmsDB::getInstance()->get_all_not_interviewed_resumes();
							break;
						case "pending":
							$result = CmsDB::getInstance()->get_all_pending_resumes();
							break;
						case "hired":
							$result = CmsDB::getInstance()->get_all_hired_resumes();
							break;
					}
					
					if (mysqli_num_rows($result) > 0)
					{
						echo '<table id="resume-table">
							<tr>
								<th align="left"></th>
								<th align="left">Name</th>
								<th align="left">Skills and Interests</th>
								<th align="left">Position Applied For</th>
								<th align="left">Status</th>
							</tr>';
						while($row = mysqli_fetch_array($result))
						{
							echo '<tr>';
							echo '<td width="50px"><form action="view.php" method="post"><input type="hidden" name="id" value="' . $row['id'] . '"><input type="submit" value="View"></form></td>';
							echo '<td><form action="view.php" method="post"><a class="name_link" href="javascript:;" onclick="parentNode.submit()">' . strtoupper($row['last_name']) . ', ' . strtoupper($row['first_name']) . ' ' . strtoupper($row['mi']) . '.</a><input type="hidden" name="id" value="' . $row['id'] . '"></form></td>';
							echo '<td>' . $row['skills_interests'] . '</td>';
							echo '<td>' . $row['position'] . '</td>';
							echo '<td>';
								if ($row['is_interviewed'] == 'N')
								{
									echo 'Not Interviewed';
								}
								else
								{
									if ($row['is_hired'] == 'N')
									{
										echo 'Pending';
									}
									else
									{
										echo 'Hired';
									}
								}
							echo '</td>';
							echo '</tr>';
						}
						echo '</table>';
					}
					else
					{
						echo 'No results';
					}
				?>
			</div>
		</div>
		<?php include 'Includes/footer.html'; ?>
	</body>
</html>