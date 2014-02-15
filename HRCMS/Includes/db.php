<?php
class CmsDB extends mysqli
{
    private static $instance = null;
    
    private $user = "root";//"hr_cms";
    private $pass = "";//"OgilvyDB4R@!";
    private $name = "ogilvy_hr_cms";//"admin_hrcms";
    private $host = "localhost";
    private $conn = null;

    public static function getInstance()
	{
        if (!self::$instance instanceof self)
		{
            self::$instance = new self;
        }
        return self::$instance;
    }
	
    public function __clone()
	{
        trigger_error('Clone is not allowed.', E_USER_ERROR);
    }

    public function __wakeup()
	{
        trigger_error('Deserializing is not allowed.', E_USER_ERROR);
    }

    private function __construct()
	{
        parent::__construct($this->host, $this->user, $this->pass, $this->name);
        if (mysqli_connect_error())
		{
            exit('Failed to connect to MySQL: (' . mysqli_connect_errno() . ') ' . mysqli_connect_error());
        }
        parent::set_charset('utf-8');
    }

	public function login($user, $password)
	{
        $result = $this->query("SELECT 1 FROM users WHERE username = '" . $user . "' AND password = '" . $password . "'");
		return $result->data_seek(0);
	}
	
	public function get_user_type_by_username($username)
	{
        return $this->query("SELECT user_type FROM users WHERE username = '" . $username . "'");
	}
	
    public function get_all_resumes()
	{
        return $this->query("SELECT * FROM resumes");
    }

	public function get_all_resumes_latest_order()
	{
        return $this->query("SELECT * FROM resumes ORDER BY date_added DESC");
    }
	
	public function get_all_resumes_alphabetical_order()
	{
        return $this->query("SELECT * FROM resumes ORDER BY last_name ASC");
    }
	
	public function get_all_resumes_by_name($name)
	{
        return $this->query("SELECT * FROM resumes WHERE last_name LIKE '%" . $name . "%' OR first_name LIKE '%" . $name . "%'");
    }
	
	public function get_all_resumes_by_skill($skill)
	{
        return $this->query("SELECT * FROM resumes WHERE skills_interests LIKE '%" . $skill . "%'");
    }
	
	public function get_all_resumes_by_position($position)
	{
        return $this->query("SELECT * FROM resumes WHERE position LIKE '&" . $position . "%'");
    }
	
	public function get_all_resumes_by_course($course)
	{
        return $this->query("SELECT * FROM resumes WHERE course LIKE '%" . $course . "%'");
    }
	
	public function get_all_resumes_by_year_graduated($year_graduated)
	{
        return $this->query("SELECT * FROM resumes WHERE year_graduated ='" . $year_graduated . "'");
    }
	
	public function get_all_interviewed_resumes()
	{
        return $this->query("SELECT * FROM resumes WHERE is_interviewed ='Y'");
    }
	
	public function get_all_not_interviewed_resumes()
	{
        return $this->query("SELECT * FROM resumes WHERE is_interviewed ='N'");
    }
	
	public function get_all_pending_resumes()
	{
        return $this->query("SELECT * FROM resumes WHERE is_hired ='N'");
    }
	
	public function get_all_hired_resumes()
	{
        return $this->query("SELECT * FROM resumes WHERE is_hired ='Y'");
    }
	
	public function get_resume_by_id($id)
	{
		return $this->query("SELECT * FROM resumes WHERE id=" . $id . "");
	}
	
	public function get_latest_resume()
	{
		return $this->query("SELECT * FROM resumes ORDER BY date_added DESC LIMIT 1");
	}
	
	public function get_all_work_history_by_resume_id($id)
	{
		return $this->query("SELECT * FROM work_history WHERE resume_id=" . $id . "");
	}
	
	public function get_all_interviews_by_resume_id($id)
	{
		return $this->query("SELECT * FROM interviews WHERE resume_id=" . $id . "");
	}
	
	public function get_resume_file_by_id($id)
	{
		return $this->query("SELECT * FROM resume_files WHERE id=" . $id . "");
	}
	
	public function search($search)
	{
		return $this->query("SELECT DISTINCT r.id, r.last_name, r.first_name, r.mi, r.skills_interests, r.position, r.is_interviewed, r.is_hired
										FROM resumes r
										RIGHT JOIN work_history w
										ON r.id=w.resume_id
										WHERE r.last_name LIKE '%" . $search . "%'
										OR r.first_name LIKE '%" . $search . "%'
										OR r.birthdate LIKE '%" . $search . "%'
										OR r.address LIKE '%" . $search . "%'
										OR r.tel_no LIKE '%" . $search . "%'
										OR r.cell_no LIKE '%" . $search . "%'
										OR r.email LIKE '%" . $search . "%'
										OR r.nationality LIKE '%" . $search . "%'
										OR r.school LIKE '%" . $search . "%'
										OR r.course LIKE '%" . $search . "%'
										OR r.year_graduated LIKE '%" . $search . "%'
										OR r.skills_interests LIKE '%" . $search . "%'
										OR r.position LIKE '%" . $search . "%'
										OR r.org LIKE '%" . $search . "%'
										OR w.company LIKE '%" . $search . "%'
										OR w.position LIKE '%" . $search . "%'
										OR w.description LIKE '%" . $search . "%'");
	}
	
	public function add_resume($last_name, $first_name, $mi, $birthdate, $address, $tel_no, $cell_no, $email, $nationality, $school, $course, $year_graduated, $skills_interests, $position, $org, $is_interviewed, $is_hired, $date_hired)
	{
		$this->query("INSERT INTO resumes (last_name, first_name, mi, birthdate, address, tel_no, cell_no, email, nationality, school, course, year_graduated, skills_interests, position, org, is_interviewed, is_hired, date_hired)
								VALUES (
								'" . $last_name . "',
								'" . $first_name . "',
								'" . $mi . "',
								'" . $birthdate . "',
								'" . $address . "',
								'" . $tel_no . "',
								'" . $cell_no . "',
								'" . $email . "',
								'" . $nationality . "',
								'" . $school . "',
								'" . $course . "',
								'" . $year_graduated . "',
								'" . $skills_interests . "',
								'" . $position . "',
								'" . $org . "',
								'" . $is_interviewed . "',
								'" . $is_hired . "',
								'" . $date_hired . "'
								)");
	}
	
	public function add_work_history($resume_id, $company, $position, $duration_start, $duration_end, $description)
	{
		$this->query("INSERT INTO work_history (resume_id, company, position, duration_start, duration_end, description)
								VALUES (
								" . $resume_id . ",
								'" . $company . "',
								'" . $position . "',
								'" . $duration_start . "',
								'" . $duration_end . "',
								'" . $description . "'
								)");
	}
	
	public function add_interview($resume_id, $comment, $interviewer, $date)
	{
		$this->query("INSERT INTO interviews (resume_id, comment, interviewer, date)
								VALUES (
								" . $resume_id . ",
								'" . $comment . "',
								'" . $interviewer . "',
								'" . $date . "'
								)");
	}
	
	public function add_resume_file($id, $file, $name, $type)
	{
		$this->query("INSERT INTO resume_files
								VALUES (
								" . $id . ",
								'" . $file . "',
								'" . $name . "',
								'" . $type . "'
								)");
	}
	
	public function update_resume_by_id($id, $last_name, $first_name, $mi, $birthdate, $address, $tel_no, $cell_no, $email, $nationality, $school, $course, $year_graduated, $skills_interests, $position, $org, $is_interviewed, $is_hired, $date_hired)
	{
		$this->query("UPDATE resumes SET 
								last_name='" . $last_name . "',
								first_name='" . $first_name . "',
								mi='" . $mi . "',
								birthdate='" . $birthdate . "',
								address='" . $address . "',
								tel_no='" . $tel_no . "',
								cell_no='" . $cell_no . "',
								email='" . $email . "',
								nationality='" . $nationality . "',
								school='" . $school . "',
								course='" . $course . "',
								year_graduated='" . $year_graduated . "',
								skills_interests='" . $skills_interests . "',
								position='" . $position . "',
								org='" . $org . "',
								is_interviewed='" . $is_interviewed . "',
								is_hired='" . $is_hired . "',
								date_hired='" . $date_hired . "' 
								WHERE id=" . $id . "");
	}
	
	public function update_work_history_by_id($id, $company, $position, $duration_start, $duration_end, $description)
	{
		$this->query("UPDATE work_history SET 
								company='" . $company . "',
								position='" . $position . "',
								duration_start='" . $duration_start . "',
								duration_end='" . $duration_end . "',
								description='" . $description . "'
								WHERE id=" . $id . "");
	}
	
	public function update_resume_file_by_id($id, $file, $name, $type)
	{
		$this->query("UPDATE resume_files SET 
								file='" . $file . "',
								filename='" . $name . "',
								type='" . $type . "' 
								WHERE id=" . $id . "");
	}
	
	public function update_resume_date_added_by_id($id)
	{
		$this->query("UPDATE resumes SET date_added='" . date("Y-m-d") . "' WHERE id=" . $id . "");
	}
	
	public function delete_resume_by_id($id)
	{
		$this->query("DELETE FROM resumes WHERE id=" . $id . "");
	}
}
?>