<?php
	require_once("Includes/db.php");
	
	if ($_SESSION['user_type'] == 'v')
	{
		header('Location: index.php');
		exit;
	}
	
	CmsDB::getInstance()->delete_resume_by_id($_POST['id']);
	header("Location: search.php");
?>