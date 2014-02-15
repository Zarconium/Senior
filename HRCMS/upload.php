<?php
	require_once("Includes/db.php");
	
	if ($_SESSION['user_type'] == 'v')
	{
		header('Location: index.php');
		exit;
	}
	
	if (!empty($_FILES['resume_file']['name']))
	{
		$data = addslashes(fread(fopen($_FILES['resume_file']['tmp_name'], "r"), filesize($_FILES['resume_file']['tmp_name'])));
		CmsDB::getInstance()->add_resume_file($_POST['id'], $data, $_FILES['resume_file']['name'], $_FILES['resume_file']['type']);
	}
	header("Location: search.php");
?>