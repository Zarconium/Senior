<?php
	require_once("Includes/db.php");
	
	$file = mysqli_fetch_array(CmsDB::getInstance()->get_resume_file_by_id($_POST['id']));
	header('Content-type: ' . $file['type']);
	$filename = str_replace(' ', '_', $file['filename']);
	header('Content-disposition: attachment; filename=' . $filename);
	print $file['file']
?>