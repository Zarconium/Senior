class Sale_Record
	attr_accessor :employee_number, :product_code, :price_sold

	def initialize(employee_number, product_code, price_sold)
		@employee_number = employee_number
		@product_code = product_code
		@price_sold = price_sold
	end

	def to_s
		return "Product Code: #{product_code}\nPrice Sold: #{price_sold}"
	end
end
