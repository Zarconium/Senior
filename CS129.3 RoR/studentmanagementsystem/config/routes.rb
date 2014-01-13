Studentmanagementsystem::Application.routes.draw do
  root to: "pages#index"
  resources :students
  resources :subjects
  resources :studentsubjects
end
