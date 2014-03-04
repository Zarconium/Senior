class UserEntry < ActiveRecord::Base
	belongs_to :user
	has_many :comments

	has_attached_file :photo, styles: { feed: "512x512" }
	validates_attachment_content_type :photo, content_type: ["image/jpeg", "image/jpg", "image/png"]
	validates_attachment_presence :photo

	validates :title, presence: true
	validates :description, presence: true
end
