class CommentsController < ApplicationController
	before_filter :authenticate_user!
	
	def index
	end

	def show
		@comment = Comment.find(params[:id])
	end

	def new
		@comment = Comment.new
	end

	def create
		@comment = Comment.new(comment_params)

		if @comment.save
			redirect_to user_entry_path(@comment.user_entry.id)
		else
			render :new
		end
	end

	def edit
		@comment = Comment.find(params[:id])
	end

	def update
		@comment = Comment.find(params[:id])

		if @comment.update_attributes(comment_params)
			redirect_to user_entry_path(@comment.user_entry.id)
		else
			render :edit
		end
	end

	def destroy
		@comment = Comment.find(params[:id])
		if current_user != @comment.user
			redirect_to user_entry_path(@comment.user_entry.id)
		end
		@comment.destroy
		redirect_to user_entry_path(@comment.user_entry.id)
	end

	private

	def comment_params
		params.require(:comment).permit!
	end
end