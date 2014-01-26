class OfficesController < ApplicationController
	before_filter :authenticate_user!

	def index
		@offices = Office.all
	end

	def show
		@office = Office.find(params[:id])
	end

	def new
		@office = Office.new
	end

	def create
		@office = Office.new(office_params)

		if @office.save
			redirect_to offices_path
		else
			render :new
		end
	end

	def edit
		@office = Office.find(params[:id])
	end

	def update
		@office = Office.find(params[:id])

		if @office.update_attributes(office_params)
			redirect_to offices_path
		else
			render :edit
		end
	end

	def destroy
		@office = Office.find(params[:id])
		@office.destroy
		redirect_to offices_path
	end

	private

	def office_params
		params.require(:office).permit!
	end
end