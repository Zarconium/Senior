<div id="navbar">
	<a href="main.php"><img class="navbar-logo" src="css/images/ogilvy_logo.png"></a>
	<?php
		if ($_SESSION['user_type'] == 'a')
		{
			echo '<form class="navbar" name="add" action="add.php">
				<input type="submit" class="navbar-button" value="ADD RESUME">
			</form>';
		}
	?>
	<form class="navbar" name="searchtypedropdown" action="search.php" method="post">
		<input type="submit" class="navbar-button" value="SEARCH">
		<select name="searchtype">
		<option value="all">All</option>
		<option value="name">By name</option>
		<option value="skill">By skill</option>
		<option value="position">By position</option>
		<option value="course">By course</option>
		<option value="year">Year graduated</option>
		<option value="interviewed">Interviewed</option>
		<option value="notinterviewed">Not interviewed</option>
		<option value="pending">Pending</option>
		<option value="hired">Hired</option>
		</select>
		<input type="text" name="search" size="50">
	</form>
	<form class="navbar_logout" name="logout" action="logout.php">
		<input type="submit" class="navbar-button" value="LOG OUT">
	</form>
	<form class="navbar_name">
		<input type="submit" class="navbar-button-disabled" value="Welcome, <?php echo $_SESSION['user']; ?>" disabled>
	</form>
</div>