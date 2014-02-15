<?php
	require_once("Includes/db.php");
	
	session_start();
	if (!array_key_exists("user", $_SESSION))
	{
		header('Location: index.php');
		exit;
	}
	
	if ($_SERVER['REQUEST_METHOD'] != 'POST')
	{
		header('Location: index.php');
		exit;
	}
	else
	{
		if (!empty($_FILES['resume_file']['name']))
		{
			$data = addslashes(fread(fopen($_FILES['resume_file']['tmp_name'], "r"), filesize($_FILES['resume_file']['tmp_name'])));
			
			if (mysqli_num_rows(CmsDB::getInstance()->get_resume_file_by_id($_POST['id'])) > 0)
			{
				CmsDB::getInstance()->update_resume_file_by_id($_POST['id'], $data, $_FILES['resume_file']['name'], $_FILES['resume_file']['type']);
				CmsDB::getInstance()->update_resume_date_added_by_id($_POST['id']);
			}
			else
			{
				CmsDB::getInstance()->add_resume_file($_POST['id'], $data, $_FILES['resume_file']['name'], $_FILES['resume_file']['type']);
			}
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
			<?php include 'Includes/navbar.php';?>
			<div id="content">
				<form name="main" action="main.php">
					<input id="main-button" type="submit" value="Back to main">
				</form>
				<br><br>
				<?php
					$resume = mysqli_fetch_array(CmsDB::getInstance()->get_resume_by_id($_POST['id']));
					$work_history = CmsDB::getInstance()->get_all_work_history_by_resume_id($_POST['id']);
					$interviews = CmsDB::getInstance()->get_all_interviews_by_resume_id($_POST['id']);
					
					echo '<table>';
					echo '<tr><th align="left">Resume Details</th></tr>';
					echo '<tr><td>Name:</td><td>' . strtoupper($resume['last_name']) . ', ' . strtoupper($resume['first_name']) . ' ' . strtoupper($resume['mi']) . '.</td></tr>';
					echo '<tr><td>Birthdate:</td><td>' . date("M d Y", strtotime($resume['birthdate'])) . '</td></tr>';
					echo '<tr><td>Address:</td><td>' . $resume['address'] . '</td></tr>';
					echo '<tr><td>Tel. No.:</td><td>' . $resume['tel_no'] . '</td></tr>';
					echo '<tr><td>Cell. No.:</td><td>' . $resume['cell_no'] . '</td></tr>';
					echo '<tr><td>Email:</td><td>' . $resume['email'] . '</td></tr>';
					echo '<tr><td>Nationality:</td><td>' . $resume['nationality'] . '</td></tr>';
					echo '<tr><td>School:</td><td>' . $resume['school'] . '</td></tr>';
					echo '<tr><td>Course:</td><td>' . $resume['course'] . '</td></tr>';
					echo '<tr><td>Year Graduated:</td><td>' . $resume['year_graduated'] . '</td></tr>';
					echo '<tr><td>&nbsp;</td></tr>';
					echo '<tr><td>Work History:</td><td>&nbsp;</td></tr>';
					echo '<tr><td colspan="2"><table>';
					while ($row = mysqli_fetch_array($work_history))
					{
						echo '<tr><td>Company:</td><td>' . $row['company'] . '</td></tr>';
						echo '<tr><td>Position:</td><td>' . $row['position'] . '</td></tr>';
						echo '<tr><td>Duration:</td><td>' . date("M Y", strtotime($row['duration_start'])) . ' - ' . date("M Y", strtotime($row['duration_end'])) . '</td></tr>';
						echo '<tr><td>Job description:</td><td><textarea class="view" wrap="hard" readonly="yes">' . $row['description'] . '</textarea></td></tr>';
						echo '<tr><td></td></tr>';
					}
					echo '</table></td></tr>';
					echo '<tr><td>&nbsp;</td></tr>';
					echo '<tr><td>Skills and Interests:</td><td>' . $resume['skills_interests'] . '</td></tr>';
					echo '<tr><td>Position applied for:</td><td>' . $resume['position'] . '</td></tr>';
					echo '<tr><td>Org Affiliation:</td><td>' . $resume['org'] . '</td></tr>';
					echo '<tr><td>&nbsp;</td></tr>';
					echo '<tr><td>Interviewed?:</td><td>'; 
						if ($resume['is_interviewed'] == 'Y')
						{
							echo 'Yes</td></tr>';
						}
						else
						{
							echo 'No</td></tr>';
						}
					echo '<tr><td colspan="2"><table>';
					while ($row = mysqli_fetch_array($interviews))
					{
						echo '<tr><td>Comment:</td><td>' . $row['comment'] . '</td></tr>';
						echo '<tr><td>By:</td><td>' . $row['interviewer'] . '</td></tr>';
						echo '<tr><td>Date:</td><td>' . date("M d Y", strtotime($row['date'])) . '</td></tr>';
						echo '<tr><td></td></tr>';
					}
					echo '</table></td></tr>';
					echo '<tr><td>Hired?:</td><td>'; 
						if ($resume['is_hired'] == 'Y')
						{
							echo 'Yes</td></tr>';
						}
						else
						{
							echo 'No</td></tr>';
						}
					echo '<tr><td>Date Hired:</td><td>' . date("M d Y", strtotime($resume['date_hired'])) . '</td></tr>';
					echo '<tr><td>Date Added:</td><td>' . date("M d Y", strtotime($resume['date_added'])) . '</td></tr>';
					echo '<tr><td>&nbsp;</td><td></td></tr>';
					
					if ($_SESSION['user_type'] == 'a')
					{
						echo '<form action="view.php" method="post" enctype="multipart/form-data">
							<input type="hidden" name="id" value="' . $_POST['id'] . '">
							<tr><td>Upload resume file: </td><td><input type="file" name="resume_file">
							<input type="submit" value="Upload"></td></tr>
							</table>
						</form>
						<br>';
					}
					else
					{
						echo '</table></form><br>';
					}
					
					if (mysqli_num_rows(CmsDB::getInstance()->get_resume_file_by_id($_POST['id'])) > 0)
					{
						echo '<form action="download.php" method="post">';
						echo '<input type="hidden" name="id" value="' . $_POST['id'] . '">';
						echo '<input type="submit" value="Download resume file">';
						echo '</form>';
					}
					
					if ($_SESSION['user_type'] == 'a')
					{
						echo '<form action="edit.php" method="post">
							<input type="hidden" name="id" value="' . $_POST['id'] . '">
							<input type="hidden" name="action" value="view">
							<input type="submit" value="Edit">
						</form>
						<form id="delete" method="post">
							<input type="hidden" name="id" value="' . $_POST['id'] . '">
							<input id="delete_button" type="button" onclick="delete_prompt()" value="Delete">
						</form>
						<script>
							function delete_prompt()
							{
								if(confirm("Are you sure you want to delete this resume?"))
								{
									document.getElementById("delete").action = "delete.php";
									document.getElementById("delete_button").type = "submit";
								}
							}
						</script>';
					}
				
					if (!empty($_FILES['resume_file']['name']))
					{
						echo '<script>alert("Resume file uploaded")</script>;';
					}
				?>
			</div>
		</div>
		<?php include 'Includes/footer.html'; ?>
	</body>
</html>