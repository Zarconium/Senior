class UsersController < ApplicationController
	before_filter :authenticate_user!

	def index
	end

	def show
		@user = User.find_by handle: params[:handle]
		# @user = User.find(params[:id])
	end

	def edit
		@user = User.find_by handle: params[:handle]
		# @user = User.find(params[:id])
	end

	def update
		# @user = User.find_by handle: params[:handle]
		@user = User.find(params[:handle])

		if @user.update_attributes(user_params)
			redirect_to '/' + @user.handle
		else
			render :edit
		end
	end

	def friends
		@user = User.find_by handle: params[:handle]
	end

	def friend_requests
		@user = User.find_by handle: params[:handle]
		if @user.id != current_user.id
			redirect_to :back
		end
	end

	private

	def user_params
		params.require(:user).permit!
	end
end