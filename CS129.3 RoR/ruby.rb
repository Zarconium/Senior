# basic
puts "Hello World!"

# class
class Person
	attr_accessor :first_name,  :last_name

	def initialize(first_name, last_name)
		@first_name = first_name
		@last_name = last_name
	end

	def to_s
		"#{last_name}, #{first_name}"
	end

	def full_name
		"#{first_name} #{last_name}"
	end
end

class Student < Person
	attr_accessor :id_number
end

p = Student.new("RJ", "Cruz")
p.id_number = "101047"
#puts p
#puts p.full_name
#puts p.first_name
#puts p.last_name

p2 = Student.new("Francis", "Fajardo")
p2.id_number = "094200"

p3 = Student.new("Paolo", "Luces")
p3.id_number = "092242"

students = []
students << p
students << p2
students << p3

students.each do |s|
	puts "#{s.id_number} - #{s.full_name}"

end
