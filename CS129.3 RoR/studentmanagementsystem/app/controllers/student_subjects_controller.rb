class StudentSubjectsController < ApplicationController
	
	def index
		redirect_to root_path
	end

	def show
		@studentsubject = StudentSubject.find(params[:id])
	end

	def new
		@studentsubject = StudentSubject.new
	end

	def create
		@studentsubject = StudentSubject.new(studentsubject_params)

		if @studentsubject.save
			redirect_to "#{students_path}/#{@studentsubject.student_id}"
		else
			render :new
		end
	end

	def edit
		@studentsubject = StudentSubject.find(params[:id])
	end

	def update
		@studentsubject = StudentSubject.find(params[:id])

		if @studentsubject.update_attributes(studentsubject_params)
			redirect_to "#{students_path}/#{@studentsubject.student_id}"
		else
			render :edit
		end
	end

	def destroy
		@studentsubject = StudentSubject.find(params[:id])
		@studentsubject.destroy
		redirect_to students_path
	end

	private

	def studentsubject_params
		params.require(:student_subject).permit!
	end
end