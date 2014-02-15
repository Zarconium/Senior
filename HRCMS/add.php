<?php
	require_once("Includes/db.php");
	
	session_start();
	if (!array_key_exists("user", $_SESSION))
	{
		header('Location: index.php');
		exit;
	}
	if ($_SESSION['user_type'] == 'v')
	{
		header('Location: index.php');
		exit;
	}
	
	$valid_name = true;
	$valid_tel_no = true;
	$valid_cell_no = true;
	
	if ($_SERVER['REQUEST_METHOD'] == 'POST')
	{
		if(isset($_POST['last_name']) && strlen(trim($_POST['last_name'])) > 0 && isset($_POST['tel_no']) && strlen(trim($_POST['tel_no'])) > 0 && isset($_POST['cell_no']) && strlen(trim($_POST['cell_no'])) > 0)
		{
			$is_interviewed = "N";
			$is_hired = "N";
			
			if (isset($_POST['is_hired']))
			{
				$is_hired = "Y";
			}
			if (isset($_POST['is_interviewed']))
			{
				$is_interviewed = "Y";
			}
			
			CmsDB::getInstance()->add_resume($_POST['last_name'], $_POST['first_name'], $_POST['mi'], $_POST['birthdate'], $_POST['address'], $_POST['tel_no'], $_POST['cell_no'], $_POST['email'], $_POST['nationality'], $_POST['school'], $_POST['course'], $_POST['year_graduated'], $_POST['skills_interests'], $_POST['position'], $_POST['org'], $is_interviewed, $is_hired, $_POST['date_hired']);
			
			$result = mysqli_fetch_array(CmsDB::getInstance()->get_latest_resume());
			
			if(array_key_exists('company', $_POST))
			{
				for ($i = 0; $i < count($_POST['company']); $i++)
				{
					CmsDB::getInstance()->add_work_history($result['id'], $_POST['company'][$i], $_POST['position'][$i], $_POST['duration_start'][$i], $_POST['duration_end'][$i], $_POST['description'][$i]);
				}
			}
			
			if(array_key_exists('comment', $_POST))
			{
				for ($i = 0; $i < count($_POST['comment']); $i++)
				{
					CmsDB::getInstance()->add_interview($_POST['id'], $_POST['comment'][$i], $_POST['interviewer'][$i], $_POST['interview_date'][$i]);
				}
			}
		
			if (!empty($_FILES['resume_file']['name']))
			{
				$data = addslashes(fread(fopen($_FILES['resume_file']['tmp_name'], "r"), filesize($_FILES['resume_file']['tmp_name'])));
				CmsDB::getInstance()->add_resume_file($result['id'], $data, $_FILES['resume_file']['name'], $_FILES['resume_file']['type']);
			}
		}
		else
		{
			if(!isset($_POST['last_name']) || strlen(trim($_POST['last_name'])) == 0)
			{
				$valid_name = false;
			}
			if(!isset($_POST['tel_no']) || strlen(trim($_POST['tel_no'])) == 0)
			{
				$valid_tel_no = false;
			}
			if(!isset($_POST['cell_no']) || strlen(trim($_POST['cell_no'])) == 0)
			{
				$valid_cell_no = false;
			}
		}
	}
?>

<!DOCTYPE html>
<html>
	<head>
		<title>Ogilvy HR CMS</title>
		<link rel="stylesheet" href="css/style.css">
		<link rel="stylesheet" href="css/ui-lightness/jquery-ui-1.10.2.custom.min.css" />
		<script src="js/jquery-1.9.1.js"></script>
		<script src="js/jquery-ui-1.10.2.custom.min.js"></script>
		<script src="js/script.js"></script>
		<script>
			$(function()
			{
				$( ".date" ).datepicker({ dateFormat: "yy-mm-dd", yearRange: "c-100:c", changeMonth: true, changeYear: true });
			});
		</script>
	</head>
	<body>
		<div id="main">
			<?php include 'Includes/navbar.php';?>
				<div id="content">
				<form name="main" action="main.php">
					<input id="main-button" type="submit" value="Back to main">
				</form>
				<br><br>
				<form name="resume" action="add.php" method="post" enctype="multipart/form-data">
				<table>
				<tr><th align="left">Add Resume</th></tr>
				<tr><td>Last Name: </td><td><input type="text" name="last_name"><?php if(!$valid_name) { echo '<font class="error_message">Please enter a name.</font>'; } ?></td></tr>
				<tr><td>First Name: </td><td><input type="text" name="first_name">
				<tr><td>M.I.: </td><td><input type="text" name="mi">
				<tr><td>Birthdate: </td><td><input class="date" type="text" name="birthdate"></td></tr>
				<tr><td>Address: </td><td><input type="text" name="address"></td></tr>
				<tr><td>Tel. No.: </td><td><input type="text" name="tel_no"><?php if(!$valid_tel_no) { echo '<font class="error_message">Please enter a telephone number.</font>'; } ?></td></tr>
				<tr><td>Cell. No.: </td><td><input type="text" name="cell_no"><?php if(!$valid_cell_no) { echo '<font class="error_message">Please enter a cellphone number.</font>'; } ?></td></tr>
				<tr><td>Email: </td><td><input type="text" name="email"></td></tr>
				<tr><td>Nationality: </td><td><input type="text" name="nationality"></td></tr>
				<tr><td>School: </td><td><input type="text" name="school"></td></tr>
				<tr><td>Course: </td><td><input type="text" name="course"></td></tr>
				<tr><td>Year Graduated: </td><td><select id="year" name="year_graduated"></select></td></tr>
				<tr><td>&nbsp;</td></tr>
				<tr><td>Work History: </td></tr>
				<tr><td colspan="2">
				<table id="work_history">
					<tr><td><a class="add_remove" href="javascript:;" onclick="add_work_history()">+Add work history</a></td></tr>
				</table>
				</td></tr>
				<tr><td>&nbsp;</td></tr>
				<tr><td>Skills and Interests: </td><td><input type="text" name="skills_interests"></td></tr>
				<tr><td>Position applied for: </td><td><input type="text" name="position"></td></tr>
				<tr><td>Org Affiliation: </td><td><input type="text" name="org"></td></tr>
				<tr><td>&nbsp;</td><td></td></tr>
				<tr><td><input type="checkbox" name="is_interviewed">Interviewed</td></tr>
				<tr><td colspan="2">
					<table id="interviews">
						<tr><td><a class="add_remove" href="javascript:;" onclick="add_interview()">+Add interview</a></td></tr>
					</table>
				</td></tr>
				<tr><td>&nbsp;</td></tr>
				<tr><td><input type="checkbox" name="is_hired">Hired</td></tr>
				<tr><td>Date Hired: </td><td><input class="date" type="text" name="date_hired"></td></tr>
				<tr><td>&nbsp;</td><td></td></tr>
				<tr><td>Upload resume file: </td><td><input type="file" name="resume_file"></td></tr>
				</table>
				<br>
				<input type="submit" value="Done">
				</form>
				<script>
					var select = document.getElementById("year");
					var currentYear = new Date().getFullYear();
					for(var i = currentYear + 100; i >= currentYear - 100; --i)
					{
						var option = document.createElement('option');
						option.text = option.value = i;
						select.add(option, 0);
					}
					select.selectedIndex = 100;
				</script>
				<?php
					if ($_SERVER['REQUEST_METHOD'] == 'POST' && $valid_name && $valid_tel_no && $valid_cell_no)
					{
						echo '<script>alert("Resume added successfully.");</script>';
					}
				?>
			</div>
		</div>
		<?php include 'Includes/footer.html'; ?>
	</body>
</html>