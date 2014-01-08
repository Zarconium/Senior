class Client < ActiveRecord::Base

  PRIORITY = ["Low", "Medium", "High"]

  validates :first_name, presence: true
  validates :last_name, presence: true
  validates :priority, presence: true, inclusion: { in: PRIORITY }
  validates :email, presence: true, uniqueness: true

  def name
    "#{first_name} #{last_name}"
  end
end
