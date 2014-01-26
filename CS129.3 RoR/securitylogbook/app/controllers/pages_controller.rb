class PagesController < ApplicationController
	before_filter :authenticate_user!

	def index
		redirect_to log_records_path
	end
end
