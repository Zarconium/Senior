class CreateStudentSubjects < ActiveRecord::Migration
  def change
    create_table :student_subjects do |t|
      t.integer :student_id
      t.integer :subject_id
      t.date :date_enrolled
      t.date :date_completed
      t.string :letter_grade
      t.decimal :numeric_grade

      t.timestamps
    end
  end
end
