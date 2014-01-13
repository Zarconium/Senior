class StudentSubjectsController < ApplicationController
  
  def index
    @studentsubjects = StudentSubject.all
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
      redirect_to studentsubjects_path
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
      redirect_to studentsubjects_path
    else
      render :edit
    end
  end

  def destroy
    @studentsubject = StudentSubject.find(params[:id])
    @studentsubject.destroy
    redirect_to studentsubjects_path
  end

  private

  def studentsubject_params
    params.require(:studentsubject).permit!
  end
end