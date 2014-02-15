function add_work_history()
{
	var table = document.getElementById("work_history");
	
	table.deleteRow(table.rows.length - 1);
	
	var hidden_td = table.insertRow(table.rows.length).insertCell(0);
	hidden_td.innerHTML = "&nbsp;"
	var id = document.createElement("input");
	id.type = "hidden";
	id.name = "work_history_id[]";
	hidden_td.appendChild(id);
	
	var company_row = table.insertRow(table.rows.length);
	var company_label_td = company_row.insertCell(0).innerHTML = "Company:";
	var company_input_td = company_row.insertCell(1);
	var company_input = document.createElement("input");
	company_input.type = "text";
	company_input.name = "company[]";
	company_input_td.appendChild(company_input);
	
	var position_row = table.insertRow(table.rows.length);
	var position_label_td = position_row.insertCell(0).innerHTML = "Position:";
	var position_input_td = position_row.insertCell(1);
	var position_input = document.createElement("input");
	position_input.type = "text";
	position_input.name = "position[]";
	position_input_td.appendChild(position_input);
	
	var duration_row = table.insertRow(table.rows.length);
	var duration_label_td = duration_row.insertCell(0).innerHTML = "Duration:";
	var duration_input_td = duration_row.insertCell(1);
	var duration_start = document.createElement("input");
	duration_start.setAttribute("class", "date");
	duration_start.type = "text";
	duration_start.name = "duration_start[]";
	duration_start.size = "8";
	duration_input_td.appendChild(duration_start);
	duration_input_td.innerHTML += "-";
	var duration_end = document.createElement("input");
	duration_end.setAttribute("class", "date");
	duration_end.type = "text";
	duration_end.name = "duration_end[]";
	duration_end.size = "8";
	duration_input_td.appendChild(duration_end);
	
	var description_row = table.insertRow(table.rows.length);
	var description_label_td = description_row.insertCell(0).innerHTML = "Job description:";
	var description_input_td = description_row.insertCell(1);
	var description_input = document.createElement("textarea");
	description_input.name = "description[]";
	description_input.setAttribute("wrap", "hard");
	description_input_td.appendChild(description_input);
	
	var add_remove_row = table.insertRow(table.rows.length);
	var add_work_td = add_remove_row.insertCell(0);
	var add_work = document.createElement("a");
	add_work.setAttribute("class", "add_remove");
	add_work.setAttribute("href", "javascript:;");
	add_work.setAttribute("onclick", "add_work_history()");
	add_work.appendChild(document.createTextNode("+Add work history"));
	add_work_td.appendChild(add_work);
	var remove_work_td = add_remove_row.insertCell(1);
	var remove_work = document.createElement("a");
	remove_work.setAttribute("class", "add_remove");
	remove_work.setAttribute("href", "javascript:;");
	remove_work.setAttribute("onclick", "remove_work_history()");
	remove_work.appendChild(document.createTextNode("-Remove"));
	remove_work_td.appendChild(remove_work);
	
	$(function()
	{
		$( ".date" ).datepicker({ dateFormat: "yy-mm-dd", yearRange: "c-100:c", changeMonth: true, changeYear: true });
	});
}

function remove_work_history()
{
	var table = document.getElementById("work_history");
	
	var rowCount = table.rows.length;
	
	for (var i = rowCount - 1; i > rowCount - 7; i--)
	{
		table.deleteRow(i);
	}
	
	var add_remove_row = table.insertRow(table.rows.length);
	var add_work_td = add_remove_row.insertCell(0);
	var add_work = document.createElement("a");
	add_work.setAttribute("class", "add_remove");
	add_work.setAttribute("href", "javascript:;");
	add_work.setAttribute("onclick", "add_work_history()");
	add_work.appendChild(document.createTextNode("+Add work history"));
	add_work_td.appendChild(add_work);
	if (table.rows.length > 1)
	{
		var remove_work_td = add_remove_row.insertCell(1);
		var remove_work = document.createElement("a");
		remove_work.setAttribute("class", "add_remove");
		remove_work.setAttribute("href", "javascript:;");
		remove_work.setAttribute("onclick", "remove_work_history()");
		remove_work.appendChild(document.createTextNode("-Remove"));
		remove_work_td.appendChild(remove_work);
	}
}

function add_interview()
{
	var table = document.getElementById("interviews");
	
	table.deleteRow(table.rows.length - 1);
	
	var hidden_td = table.insertRow(table.rows.length).insertCell(0);
	hidden_td.innerHTML = "&nbsp;"
	
	var comment_row = table.insertRow(table.rows.length);
	var comment_label_td = comment_row.insertCell(0).innerHTML = "Comment:";
	var comment_input_td = comment_row.insertCell(1);
	var comment_input = document.createElement("input");
	comment_input.type = "text";
	comment_input.name = "comment[]";
	comment_input_td.appendChild(comment_input);
	
	var commenter_row = table.insertRow(table.rows.length);
	var commenter_label_td = commenter_row.insertCell(0).innerHTML = "By:";
	var commenter_input_td = commenter_row.insertCell(1);
	var commenter_input = document.createElement("input");
	commenter_input.type = "text";
	commenter_input.name = "interviewer[]";
	commenter_input_td.appendChild(commenter_input);
	
	var date_row = table.insertRow(table.rows.length);
	var date_label_td = date_row.insertCell(0).innerHTML = "Date:";
	var date_input_td = date_row.insertCell(1);
	var date_end = document.createElement("input");
	date_end.setAttribute("class", "date");
	date_end.type = "text";
	date_end.name = "interview_date[]";
	date_input_td.appendChild(date_end);
	
	var add_remove_row = table.insertRow(table.rows.length);
	var add_interview_td = add_remove_row.insertCell(0);
	var add_interview = document.createElement("a");
	add_interview.setAttribute("class", "add_remove");
	add_interview.setAttribute("href", "javascript:;");
	add_interview.setAttribute("onclick", "add_interview()");
	add_interview.appendChild(document.createTextNode("+Add interview"));
	add_interview_td.appendChild(add_interview);
	var remove_interview_td = add_remove_row.insertCell(1);
	var remove_interview = document.createElement("a");
	remove_interview.setAttribute("class", "add_remove");
	remove_interview.setAttribute("href", "javascript:;");
	remove_interview.setAttribute("onclick", "remove_interview()");
	remove_interview.appendChild(document.createTextNode("-Remove"));
	remove_interview_td.appendChild(remove_interview);
	
	$(function()
	{
		$( ".date" ).datepicker({ dateFormat: "yy-mm-dd", yearRange: "c-100:c", changeMonth: true, changeYear: true });
	});
}

function remove_interview()
{
	var table = document.getElementById("interviews");
	
	var rowCount = table.rows.length;
	
	for (var i = rowCount - 1; i > rowCount - 6; i--)
	{
		table.deleteRow(i);
	}
	
	var add_remove_row = table.insertRow(table.rows.length);
	var add_interview_td = add_remove_row.insertCell(0);
	var add_interview = document.createElement("a");
	add_interview.setAttribute("class", "add_remove");
	add_interview.setAttribute("href", "javascript:;");
	add_interview.setAttribute("onclick", "add_interview()");
	add_interview.appendChild(document.createTextNode("+Add interview"));
	add_interview_td.appendChild(add_interview);
	if (table.rows.length > 1)
	{
		var remove_interview_td = add_remove_row.insertCell(1);
		var remove_interview = document.createElement("a");
		remove_interview.setAttribute("class", "add_remove");
		remove_interview.setAttribute("href", "javascript:;");
		remove_interview.setAttribute("onclick", "remove_interview()");
		remove_interview.appendChild(document.createTextNode("-Remove"));
		remove_interview_td.appendChild(remove_interview);
	}
}