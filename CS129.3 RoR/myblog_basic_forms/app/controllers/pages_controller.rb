class PagesController < ApplicationController

	def index
		@first_post = Post.first
		@last_post = Post.last
	end

	def all_posts
		@posts = Post.all
	end

	def search_title
		@posts = Post.where("title like ?", "%#{params[:letter]}%")
	end

	def shops
		# Processes request
		stuff = []
		50.times do
			stuff << Shop.new
		end
		render :json => stuff.to_json
	end

end
