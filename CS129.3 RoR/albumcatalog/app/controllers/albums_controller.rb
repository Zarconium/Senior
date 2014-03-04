class AlbumsController < ApplicationController
	def index
		@albums = Album.all
	end

	def show
		@album = Album.find(params[:id])
	end

	def new
		@album = Album.new
	end

	def create
		@album = Album.new(album_params)

		if @album.save
			redirect_to album_path(@album.id)
		else
			render :new
		end
	end

	def edit
		@album = Album.find(params[:id])
	end

	def update
		@album = Album.find(params[:id])

		if @album.update_attributes(album_params)
			redirect_to album_path(@album.id)
		else
			render :edit
		end
	end

	def destroy
		Album.find(params[:id]).destroy
		redirect_to albums_path
	end

	private

	def album_params
		params.require(:album).permit!
	end
end