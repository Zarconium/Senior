require './employee.rb'
require './product.rb'
require './salerecord.rb'

e1 = Employee.new("Francis", "Fajardo", "Male", "1", "094200", 100.00, 0.50)
e2 = Employee.new("Paolo", "Luces", "Male", "2,", "092242", 555.55, 0.25)

p1 = Product.new("Butter Chicken", "1", 8878888)
p2 = Product.new("Siopao", "2", 7028888)
p3 = Product.new("Mocha Frappe", "3", 100000)
p4 = Product.new("Muffins", "4", 50000)
p5 = Product.new("Gravy", "5", 8878888)

s1 = Sale_Record.new("1", "5", 8878888)
s2 = Sale_Record.new("2", "2", 7028888)

puts "Enter employee number:"
emp_no = gets.chomp

if s1.employee_number == emp_no
	puts s1
	puts "Total Commission: #{e1.commission * s1.price_sold}"
elsif s2.employee_number == emp_no
	puts s2
	puts "Total Commission: #{e2.commission * s2.price_sold}"
end
