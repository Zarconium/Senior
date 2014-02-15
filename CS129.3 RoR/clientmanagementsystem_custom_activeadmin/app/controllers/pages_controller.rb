class PagesController < ApplicationController
  def index
    @client = Client.last
  end
end
