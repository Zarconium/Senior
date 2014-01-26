class Office < ActiveRecord::Base
	has_many :log_records

	validates :name, presence: true
	validates :room_number, presence: true
	validates :description, presence: true

	def total_visitors
		self.log_records.count
	end
end
