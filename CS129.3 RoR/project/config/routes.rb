Project::Application.routes.draw do
  devise_for :users
  devise_for :admin_users, ActiveAdmin::Devise.config
  ActiveAdmin.routes(self)
  root to: "pages#index"
  post "/search", to: "pages#search", as: :search
  get "/:handle/edit", to: "users#edit", as: :edit_user
  get "/:handle", to: "users#show", as: :user
  patch "/:handle", to: "users#update"
  put "/:handle", to: "users#update"
  get "/:handle/friends", to: "users#friends", as: :friends
  get "/:handle/friends/requests", to: "users#friend_requests", as: :friend_requests
  resources :user_entries
  resources :comments
  get "/:handle/add", to: "friendships#create", as: :add_friend
  get "/:handle/approve", to: "friendships#approve", as: :approve_friend
  get "/:handle/remove", to: "friendships#remove", as: :remove_friend
end