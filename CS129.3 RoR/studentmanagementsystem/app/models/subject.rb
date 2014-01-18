class Subject < ActiveRecord::Base
	has_many :student_subjects

	validates :name, presence: true, uniqueness: true
	validates :code, presence: true, uniqueness: true
	validates :num_units, presence: true, numericality: true

	def to_s
		name
	end
end
