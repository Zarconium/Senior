Studentmanagementsystem::Application.routes.draw do
  devise_for :users
	root to: "pages#index"
	resources :students
	resources :subjects
	resources :student_subjects
	get "/students/:id/add_student_subject_record", to: "students#add_student_subject_record", as: :add_student_subject_record
	get "/students/:id/edit_student_subject_record/:student_subject_record_id", to:	"students#edit_student_subject_record", as: :edit_student_subject_record
end
