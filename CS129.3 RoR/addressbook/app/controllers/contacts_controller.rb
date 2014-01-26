class ContactsController < ApplicationController
	def index
		@contacts = Contact.all
	end

	def new
		@contact = Contact.new
	end

	def create
		@contact = Contact.new(contact_params)
		@contact.save
		redirect_to contacts_path
	end

	def remove
		Contact.find(params[:id]).destroy
		redirect_to contacts_path
	end

	private

	def contact_params
		params.require(:contact).permit!
	end
end
