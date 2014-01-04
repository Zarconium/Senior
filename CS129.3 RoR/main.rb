require './pokemon.rb'
require './move.rb'

puts "Create a Pokemon!"
puts "Enter pokemon name:"
name = gets.chomp
puts "Enter pokemon type:"
type = gets.chomp

pokemon = Pokemon.new(name, type)
count = 1
4.times do
	puts "Enter move #{count} name:"
	move_name = gets.chomp
	puts "Enter move #{count} type:"
	move_type = gets.chomp
	puts "Enter move #{count} power:"
	move_power = gets.chomp
	
	move = Move.new(move_name, move_type, move_power)
	pokemon.add_move(move)
	count += 1
end

puts pokemon.inspect
