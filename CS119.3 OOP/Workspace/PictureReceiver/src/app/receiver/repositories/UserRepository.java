package app.receiver.repositories;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import app.receiver.entities.PictureEntry;
import app.receiver.entities.User;

@Repository
public interface UserRepository extends JpaRepository<User, Long> {
	
	public User findByUserName(String userName);
	// 1. login
	// 2. register
}
