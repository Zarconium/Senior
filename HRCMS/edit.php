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
	
	if ($_SERVER['REQUEST_METHOD'] == 'POST')
	{
		$valid_name = true;
		$valid_tel_no = true;
		$valid_cell_no = true;
		
		if ($_POST['action'] == 'save')
		{
			if (isset($_POST['last_name']) && strlen(trim($_POST['last_name'])) > 0 && isset($_POST['tel_no']) && strlen(trim($_POST['tel_no'])) > 0 && isset($_POST['cell_no']) && strlen(trim($_POST['cell_no'])) > 0)
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
				
				CmsDB::getInstance()->update_resume_by_id($_POST['id'], $_POST['last_name'], $_POST['first_name'], $_POST['mi'], $_POST['birthdate'], $_POST['address'], $_POST['tel_no'], $_POST['cell_no'], $_POST['email'], $_POST['nationality'], $_POST['school'], $_POST['course'], $_POST['year_graduated'], $_POST['skills_interests'], $_POST['position_applied'], $_POST['org'], $is_interviewed, $is_hired, $_POST['date_hired']);
				
				for ($i = 0; $i < count($_POST['company']); $i++)
				{
					if ($_POST['work_history_id'][$i])
					{
						CmsDB::getInstance()->update_work_history_by_id($_POST['work_history_id'][$i], $_POST['company'][$i], $_POST['position'][$i], $_POST['duration_start'][$i], $_POST['duration_end'][$i], $_POST['description'][$i]);
					}
					else
					{
						CmsDB::getInstance()->add_work_history($_POST['id'], $_POST['company'][$i], $_POST['position'][$i], $_POST['duration_start'][$i], $_POST['duration_end'][$i], $_POST['description'][$i]);
					}
				}
				
				if (array_key_exists('comment', $_POST))
				{
					for ($i = 0; $i < count($_POST['comment']); $i++)
					{
						CmsDB::getInstance()->add_interview($_POST['id'], $_POST['comment'][$i], $_POST['interviewer'][$i], $_POST['interview_date'][$i]);
					}
				}
			}
			else
			{
				if (!isset($_POST['last_name']) || strlen(trim($_POST['last_name'])) == 0)
				{
					$valid_name = false;
				}
				if (!isset($_POST['tel_no']) || strlen(trim($_POST['tel_no'])) == 0)
				{
					$valid_tel_no = false;
				}
				if (!isset($_POST['cell_no']) || strlen(trim($_POST['cell_no'])) == 0)
				{
					$valid_cell_no = false;
				}
			}
		}
		$resume = mysqli_fetch_array(CmsDB::getInstance()->get_resume_by_id($_POST['id']));
		$work_history = CmsDB::getInstance()->get_all_work_history_by_resume_id($_POST['id']);
		$interviews = CmsDB::getInstance()->get_all_interviews_by_resume_id($_POST['id']);
	}
	else
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
		<link rel="stylesheet" href="css/ui-lightness/jquery-ui-1.10.2.custom.min.css">
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
				<form name="resume" action="edit.php" method="post">
				<table>
					<tr><th align="left">Edit Resume</th></tr>
					<tr><td>Last Name: </td><td><input type="text" name="last_name" value="<?php echo $resume['last_name'] ?>"><?php if(!$valid_name) { echo '<font class="error_message">Please enter a name.</font>'; } ?></td></tr>
					<tr><td>First Name: </td><td><input type="text" name="first_name" value="<?php echo $resume['first_name'] ?>"></td></tr>
					<tr><td>M.I.: </td><td><input type="text" name="mi" value="<?php echo $resume['mi'] ?>"></td></tr>
					<tr><td>Birthdate: </td><td><input class="date" type="text" name="birthdate" value="<?php echo $resume['birthdate'] ?>"></td></tr>
					<tr><td>Address: </td><td><input type="text" name="address" value="<?php echo $resume['address'] ?>"></td></tr>
					<tr><td>Tel. No.: </td><td><input type="text" name="tel_no" value="<?php echo $resume['tel_no'] ?>"><?php if(!$valid_tel_no) { echo '<font class="error_message">Please enter a telephone number.</font>'; } ?></td></tr>
					<tr><td>Cell. No.: </td><td><input type="text" name="cell_no" value="<?php echo $resume['cell_no'] ?>"><?php if(!$valid_cell_no) { echo '<font class="error_message">Please enter a cellphone number.</font>'; } ?></td></tr>
					<tr><td>Email: </td><td><input type="text" name="email" value="<?php echo $resume['email'] ?>"></td></tr>
					<tr><td>Nationality: </td><td><input type="text" name="nationality" value="<?php echo $resume['nationality'] ?>"></td></tr>
					<tr><td>School: </td><td><input type="text" name="school" value="<?php echo $resume['school'] ?>"></td></tr>
					<tr><td>Course: </td><td><input type="text" name="course" value="<?php echo $resume['course'] ?>"></td></tr>
					<tr><td>Year Graduated: </td><td><select id="year" name="year_graduated"></select></td></tr>
					<tr><td>&nbsp;</td></tr>
					<tr><td>Work History: </td></tr>
					<tr><td colspan="2"><table id="work_history">
						<?php
							while ($row = mysqli_fetch_array($work_history))
							{
								echo '<tr><td>&nbsp;<input type="hidden" name="work_history_id[]" value="' . $row['id'] . '"></td></tr>';
								echo '<tr><td>Company:</td><td><input type="text" name="company[]" value="' . $row['company'] . '"></td></tr>';
								echo '<tr><td>Position:</td><td><input type="text" name="position[]" value="' . $row['position'] . '"></td></tr>';
								echo '<tr><td>Duration:</td><td><input class="date" type="text" name="duration_start[]" value="' . $row['duration_start'] . '" size="8">-<input class="date" type="text" name="duration_end[]" value="' . $row['duration_end'] . '" size="8"></td></tr>';
								echo '<tr><td>Job description:</td><td><textarea name="description[]" wrap="hard">' . $row['description'] . '</textarea></td></tr>';
							}
						?>
					<tr><td><a class="add_remove" href="javascript:;" onclick="add_work_history()">+Add work history</a></td></tr>
					</table></td></tr>
					<tr><td>&nbsp;</td></tr>
					<tr><td>Skills and Interests: </td><td><input type="text" name="skills_interests" value="<?php echo $resume['skills_interests'] ?>"></td></tr>
					<tr><td>Position applied for: </td><td><input type="text" name="position_applied" value="<?php echo $resume['position'] ?>"></td></tr>
					<tr><td>Org Affiliation: </td><td><input type="text" name="org" value="<?php echo $resume['org'] ?>"></td></tr>
					<tr><td>&nbsp;</td></tr>
					<tr><td><input type="checkbox" name="is_interviewed" <?php if ($resume['is_interviewed'] == 'Y'){ echo 'checked'; } ?>>Interviewed</td><td></td></tr>
					<tr><td colspan="2">
						<table id="interviews">
							<tr><td><a class="add_remove" href="javascript:;" onclick="add_interview()">+Add interview</a></td></tr>
						</table>
					</td></tr>
					<tr><td>&nbsp;</td></tr>
					<tr><td><input type="checkbox" name="is_hired"  <?php if ($resume['is_hired'] == 'Y'){ echo 'checked'; } ?>>Hired</td><td></td></tr>
					<tr><td>Date Hired: </td><td><input class="date" type="text" name="date_hired" value="<?php echo $resume['date_hired'] ?>"></td></tr>
				</table>
					<input type="hidden" name="id" value="<?php echo $_POST['id'] ?>">
					<input type="hidden" name="action" value="save">
					<input type="submit" value="Save">
				</form>
				<script>
					var select = document.getElementById("year");
					var currentYear = new Date().getFullYear();
					var year_graduated = <?php echo $resume['year_graduated']; ?>;
					for(var i = currentYear + 100; i >= currentYear - 100; --i)
					{
						var option = document.createElement('option');
						option.text = option.value = i;
						select.add(option, 0);
						if (i - 1 == year_graduated)
						{
							select.selectedIndex = i;
						}
					}
				</script>
				<form id="delete" method="post">
					<input type="hidden" name="id" value="<?php echo $_POST['id']; ?>">
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
				</script>
				<?php
					if ($_POST['action'] == 'save' && $valid_name && $valid_tel_no && $valid_cell_no)
					{
						echo '<script>alert("Changes Saved");</script>';
					}
				?>
			</div>
		</div>
		<?php include 'Includes/footer.html'; ?>
	</body>
</html>