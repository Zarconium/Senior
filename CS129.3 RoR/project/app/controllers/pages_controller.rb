class PagesController < ApplicationController
	before_filter :authenticate_user!

	def index
		friends = Array.new
		friends.push current_user.id
		if current_user.friends
			current_user.friends.each do |friend|
				friends.push friend.id
			end
		end
		@user_entries = UserEntry.where(user_id: friends).order(created_at: :desc)
	end

	def search
		@users = User.where("email LIKE ? OR handle LIKE ?", "%#{params[:search]}%", "%#{params[:search]}%")
	end
end