Securitylogbook::Application.routes.draw do
  get "pages/index"
  devise_for :users
  root to: "pages#index"
  resources :offices
  resources :log_records
end
