class PagesController < ApplicationController

	def index
		@reportcards = ReportCard.all
	end

	def search
		
	end

	def results
		@reportcards = ReportCard.where(
			"subject_name LIKE ?
			OR subject_code LIKE ?
			OR number_of_units LIKE ?
			OR numerical_grade LIKE ?
			OR professor_name LIKE ?",
			"%#{params[:input]}%",
			"%#{params[:input]}%",
			"%#{params[:input]}%",
			"%#{params[:input]}%",
			"%#{params[:input]}%")
	end

	def new
		@reportcard = ReportCard.new
	end

	def create
		@reportcard = ReportCard.new(reportcard_params)
		@reportcard.save

		redirect_to root_path
	end

	def edit
		@reportcard = ReportCard.find(params[:id])
	end

	def update
		reportcard = ReportCard.find(params[:id])
		reportcard.subject_name = reportcard_params[:subject_name]
		reportcard.subject_code = reportcard_params[:subject_code]
		reportcard.number_of_units = reportcard_params[:number_of_units]
		reportcard.numerical_grade = reportcard_params[:numerical_grade]
		reportcard.professor_name = reportcard_params[:professor_name]
		reportcard.save

		redirect_to root_path
	end

	def delete
		ReportCard.find(params[:id]).destroy
		redirect_to root_path
	end

	private

	def reportcard_params
		params.require(:report_card).permit!
	end
end
