def factorial(n)
	if (n > 1)
		n * factorial(n - 1)
	else
		return 1
	end
end

puts factorial(5)
# 120
