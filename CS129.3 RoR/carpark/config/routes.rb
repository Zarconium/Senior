Carpark::Application.routes.draw do
  root :to => "pages#index"
  get "/index", :to => "pages#all_carpark_slots", :as => :all
  get "/search", :to => "pages#search", :as => :search
  get "/search/results", :to => "pages#results", :as => :search_carpark
  get "/new", :to => "pages#new", :as => :new_carpark
  post "/create", :to => "pages#create", :as => :create_carpark
  get "/edit/:id", :to => "pages#edit", :as => :edit_carpark
  patch "/update", :to => "pages#update", :as => :update_carpark
  get "/delete/:id", :to => "pages#delete", :as => :delete_carpark
end
