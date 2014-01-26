class Contact < ActiveRecord::Base
	def name
		"#{last_name}, #{first_name}"
	end

	def full_name
		"#{first_name} #{last_name}"
	end
end
