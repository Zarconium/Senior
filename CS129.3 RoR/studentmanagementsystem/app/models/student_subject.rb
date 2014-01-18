class StudentSubject < ActiveRecord::Base
	belongs_to :student
	belongs_to :subject

	LETTER_GRADE = ['A', 'B+', 'B', 'C+', 'C', 'D', 'F']

	validates :student_id, presence: true
	validates :subject_id, presence: true
	validates :date_enrolled, presence: true
	validates :date_completed, presence: true
	validates :letter_grade, presence: true, inclusion: { in: LETTER_GRADE }
	validates :numeric_grade, presence: true, numericality: true
end