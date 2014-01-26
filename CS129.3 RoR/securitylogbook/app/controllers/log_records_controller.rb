class LogRecordsController < ApplicationController
	before_filter :authenticate_user!

	def index
		@logrecords = User.find(current_user.id).log_records
	end

	def show
		@logrecord = LogRecord.find(params[:id])

		if current_user != @logrecord.user
			redirect_to log_records_path
		end
	end

	def new
		@logrecord = LogRecord.new
	end

	def create
		@logrecord = LogRecord.new(logrecord_params)

		if @logrecord.save
			redirect_to log_records_path
		else
			render :new
		end
	end

	def edit
		@logrecord = LogRecord.find(params[:id])

		if current_user != @logrecord.user
			redirect_to log_records_path
		end
	end

	def update
		@logrecord = LogRecord.find(params[:id])

		if @logrecord.update_attributes(logrecord_params)
			redirect_to "#{log_records_path}/#{params[:id]}"
		else
			render :edit
		end
	end

	def destroy
		@logrecord = LogRecord.find(params[:id])
		if current_user != @logrecord.user
			redirect_to log_records_path
		end
		@logrecord.destroy
		redirect_to log_records_path
	end

	private

	def logrecord_params
		params.require(:log_record).permit!
	end
end
