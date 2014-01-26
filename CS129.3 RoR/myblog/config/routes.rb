Myblog::Application.routes.draw do
  # localhost:3000/
  root :to => "pages#index"
  get "/inex", :to => "pages#all_posts", :as => :all
  get "/all_posts/title/:letter", :to => "pages#search_title", :as => :search_title
  get "/posts/new", :to => "posts#new", :as => :new_post
  post "/posts/create", :to => "posts#create", :as => :create_post
  get "/posts", :to => "posts#index", :as => :posts
end
