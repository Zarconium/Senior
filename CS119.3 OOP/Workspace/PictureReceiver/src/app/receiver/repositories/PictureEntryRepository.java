package app.receiver.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import app.receiver.entities.PictureEntry;

@Repository
public interface PictureEntryRepository extends JpaRepository<PictureEntry, Long> {

}
