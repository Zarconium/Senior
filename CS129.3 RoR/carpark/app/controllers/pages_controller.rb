class PagesController < ApplicationController

	def index
		@carparks = Carparkslot.all
	end

	def search
		
	end

	def results
		@carparks = Carparkslot.where(
			"plate_number LIKE ?
			OR car_type LIKE ?
			OR parking_date LIKE ?
			OR number_of_hours LIKE ?
			OR reserved LIKE ?",
			"%#{params[:input]}%",
			"%#{params[:input]}%",
			"%#{params[:input]}%",
			"%#{params[:input]}%",
			"%#{params[:input]}%")
	end

	def new
		@carpark = Carparkslot.new
	end

	def create
		@carpark = Carparkslot.new(carpark_params)
		@carpark.save

		redirect_to root_path
	end

	def edit
		@carpark = Carparkslot.find(params[:id])
	end

	def update
		carpark = Carparkslot.find(params[:id])
		carpark.plate_number = carpark_params[:plate_number]
		carpark.car_type = carpark_params[:car_type]
		carpark.parking_date = carpark_params[:parking_date]
		carpark.number_of_hours = carpark_params[:number_of_hours]
		carpark.reserved = carpark_params[:reserved]
		carpark.save

		redirect_to root_path
	end

	def delete
		Carparkslot.find(params[:id]).destroy
		redirect_to root_path
	end

	private

	def carpark_params
		params.require(:carparkslot).permit!
	end
end
