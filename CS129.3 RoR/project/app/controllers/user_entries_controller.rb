class UserEntriesController < ApplicationController
	before_filter :authenticate_user!

	def index
	end

	def show
		@user_entry = UserEntry.find(params[:id])
		@comment = Comment.new(:user_entry => @user_entry)
	end

	def new
		@user_entry = UserEntry.new
	end

	def create
		@user_entry = UserEntry.new(user_entry_params)

		if @user_entry.save
			redirect_to root_path
		else
			render :new
		end
	end

	def edit
		@user_entry = UserEntry.find(params[:id])
	end

	def update
		@user_entry = UserEntry.find(params[:id])

		if @user_entry.update_attributes(user_entry_params)
			redirect_to user_entry_path(@user_entry.id)
		else
			render :edit
		end
	end

	def destroy
		@user_entry = UserEntry.find(params[:id])
		if current_user != @user_entry.user
			redirect_to root_path
		end
		@user_entry.destroy
		redirect_to root_path
	end

	private

	def user_entry_params
		params.require(:user_entry).permit!
	end
end