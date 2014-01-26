Addressbook::Application.routes.draw do
  get "/contacts", :to => "contacts#index", :as => :contacts
  get "/contacts/new", :to => "contacts#new", :as => :new_contact
  post "/contacts/create", :to => "contacts#create", :as => :create_contact
  get "/contacts/remove/:id", :to => "contacts#remove", :as => :destroy_contact
end
