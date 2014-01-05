class ReportCard < ActiveRecord::Base
	validates_presence_of :subject_name, :subject_code, :number_of_units, :numerical_grade, :professor_name
	validates_numericality_of :number_of_units, :only_integer => true
	validates_numericality_of :numerical_grade
end
