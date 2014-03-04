class User < ActiveRecord::Base
	include Amistad::FriendModel
	has_many :user_entries
	has_many :comments
	# Include default devise modules. Others available are:
	# :confirmable, :lockable, :timeoutable and :omniauthable
	devise :database_authenticatable, :registerable, :recoverable, :rememberable, :trackable, :validatable

	has_attached_file :profile_picture, styles: { profile: "110x110", nav: "25x25", feed: "40x40" }, :default_url => "/assets/missing-:style.png"
	validates_attachment_content_type :profile_picture, content_type: ["image/jpeg", "image/jpg", "image/png"]

	validates :email, presence: true
	validates :handle, presence: true
end