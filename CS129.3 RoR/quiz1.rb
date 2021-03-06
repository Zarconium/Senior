puts "1.)"
def sum3(nums)
	length = nums.length
	sum = 0
	
	nums.each do |n|
		sum += n
	end
	
	return sum
end

puts sum3([1, 2, 3]) # 6
puts sum3([5, 11, 2]) # 18
puts sum3([7, 0, 0]) # 7

puts
puts "2.)"
def biggerTwo(a, b)
	if b[0] + b[1] > a[0] + a[1]
		return "#{b[0]}, #{b[1]}"
	else
		return "#{a[0]}, #{a[1]}"
	end
end

puts biggerTwo([1, 2], [3, 4]) # [3, 4]
puts biggerTwo([3, 4], [1, 2]) # [3, 4]
puts biggerTwo([1, 1], [1, 2]) # [1, 2]

puts
puts "3.)"
def fix23(nums)
	if nums[0] == 2 and nums[1] == 3
		nums[1] = 0
	elsif nums[1] == 2 and nums[2] == 3
		nums[2] = 0
	end
	
	return "#{nums[0]}, #{nums[1]}, #{nums[2]}"
end

puts fix23([1, 2, 3]) # {1, 2, 0}
puts fix23([2, 3, 5]) # {2, 0, 5}
puts fix23([1, 2, 1]) # {1, 2, 1}

puts
puts "4.)"
def commonEnd(a, b)
	if a[0] == b[0] or a[a.length - 1] == b[b.length - 1]
		return true
	else
		return false
	end
end

puts commonEnd([1, 2, 3], [7, 3]) # true
puts commonEnd([1, 2, 3], [7, 3, 2]) # false
puts commonEnd([1, 2, 3], [1, 3]) # true

puts
puts "5.)"
def unlucky1(nums)
	if (nums[0] == 1 and nums[1] == 3) or (nums[1] == 1 and nums[2] == 3) or (nums[nums.length - 2] == 1 and nums[nums.length - 1] == 3)
		return true
	else 
		return false
	end
end

puts unlucky1([1, 3, 4, 5]) # true
puts unlucky1([2, 1, 3, 4, 5]) # true
puts unlucky1([1, 1, 1]) # false
