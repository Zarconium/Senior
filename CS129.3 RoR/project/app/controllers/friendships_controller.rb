class FriendshipsController < ApplicationController
	before_filter :authenticate_user!

	def index
		@friends = current_user.friends
		@pending_invited_by = current_user.pending_invited_by
		@pending_invited = current_user.pending_invited
	end

	def create
		@Friend = User.find_by handle: params[:handle]
		@friendship_created = current_user.invite(@Friend)
		redirect_to :back
	end

	def approve
		@Friend = User.find_by handle: params[:handle]
		@friendship_approved = current_user.approve(@Friend)
		@friends = current_user.friends
		@pending_invited_by = current_user.pending_invited_by
		redirect_to :back
	end

	def remove
		@Friend = User.find_by handle: params[:handle]
		@friendship = current_user.send(:find_any_friendship_with, @Friend)
		if @friendship
			@friendship.delete
			@removed = true
		end
		redirect_to :back
	end
end