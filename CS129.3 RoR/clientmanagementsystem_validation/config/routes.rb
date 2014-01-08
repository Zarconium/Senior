Clientmanagementsystem::Application.routes.draw do
  root to: "pages#index"
  resources :clients
end
