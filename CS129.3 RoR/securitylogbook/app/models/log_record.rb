class LogRecord < ActiveRecord::Base
	belongs_to :user
	belongs_to :office

	validates :user_id, presence: true
	validates :visitor_name, presence: true
	validates :purpose_of_visit, presence: true
	validates :time_of_visit, presence: true
	validates :office_id, presence: true
end
