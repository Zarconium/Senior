Reportcard::Application.routes.draw do
  root :to => "pages#index"
  get "/index", :to => "pages#all_report_cards", :as => :all
  get "/search", :to => "pages#search", :as => :search
  get "/search/results", :to => "pages#results", :as => :search_reportcard
  get "/new", :to => "pages#new", :as => :new_reportcard
  post "/create", :to => "pages#create", :as => :create_reportcard
  get "/edit/:id", :to => "pages#edit", :as => :edit_reportcard
  patch "/update", :to => "pages#update", :as => :update_reportcard
  get "/delete/:id", :to => "pages#delete", :as => :delete_reportcard
end
