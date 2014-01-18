class StudentsController < ApplicationController

	before_filter :authenticate_user!

	def index
		@students = Student.all
	end

	def show
		@student = Student.find(params[:id])
	end

	def new
		@student = Student.new
	end

	def create
		@student = Student.new(student_params)

		if @student.save
			redirect_to "#{students_path}/#{Student.last.id}"
		else
			render :new
		end
	end

	def edit
		@student = Student.find(params[:id])
	end

	def update
		@student = Student.find(params[:id])

		if @student.update_attributes(student_params)
			redirect_to "#{students_path}/#{params[:id]}"
		else
			render :edit
		end
	end

	def destroy
		@student = Student.find(params[:id])
		@student.destroy
		redirect_to students_path
	end

	def add_student_subject_record
		@student = Student.find(params[:id])
		@studentsubject = StudentSubject.new
		@subject = Subject.first
		@studentsubject.student = @student
		@studentsubject.subject = @subject
		render "student_subjects/new"
	end

	def edit_student_subject_record
		@studentsubject = StudentSubject.find(params[:student_subject_record_id])
		render "student_subjects/edit"
	end

	private

	def student_params
		params.require(:student).permit!
	end
end