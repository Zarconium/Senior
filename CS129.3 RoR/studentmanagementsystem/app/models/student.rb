class Student < ActiveRecord::Base
	has_many :student_subjects

	validates :first_name, presence: true
	validates :last_name, presence: true
	validates :middle_name, presence: true
	validates :date_of_birth, presence: true
	validates :address, presence: true
	validates :student_number, presence: true, uniqueness: true
	validates :contact_number, presence: true
	validates :email, presence: true, uniqueness: true

	def to_s
		student_number
	end

	def name
		"#{last_name}, #{first_name} #{middle_name}"
	end

	def average
		if self.student_subjects.count > 0
			sum = 0

			self.student_subjects.each do |s|
				sum += s.numeric_grade
			end

			sum / self.student_subjects.count
		else
			0
		end
	end
end