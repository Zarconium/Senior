require './person.rb'

class Employee < Person
	attr_accessor :employee_number, :social_security_number, :gross_sales, :commission
	
	def initialize(first_name, last_name, gender, employee_number, social_security_number, gross_sales, commission)
		super(first_name, last_name, gender)
		@employee_number = employee_number
		@social_security_number = social_security_number
		@gross_sales = gross_sales
		@commission = commission
	end
end
