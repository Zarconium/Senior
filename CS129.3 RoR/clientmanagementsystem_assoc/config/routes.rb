Clientmanagementsystem::Application.routes.draw do
  root to: "pages#index"
  resources :clients
  resources :payments
  get "/clients/:id/add_payment", to: "clients#add_payment", as: :new_client_payment
end
