class Move
	attr_accessor :name, :type, :power
	
	def initialize(name, type, power)
		@name = name
		@type = type
		@power = power
	end

	def to_s
		name
	end
end
