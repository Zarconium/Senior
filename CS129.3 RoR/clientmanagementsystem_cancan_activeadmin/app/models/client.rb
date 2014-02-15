class Client < ActiveRecord::Base

  has_many :payments

  PRIORITY = ["Low", "Medium", "High"]

  validates :first_name, presence: true
  validates :last_name, presence: true
  validates :middle_name, presence: true
  validates :priority, presence: true, inclusion: { in: PRIORITY }
  validates :email, presence: true, uniqueness: true

  def name
    "#{first_name} #{last_name}"
  end

  def total_amount_paid
    x = 0
    self.payments.each do |p|
      x += p.amount
    end
    x
  end

  # Expects to return the latest payment object
  def latest_payment_transacted
    self.payments.last
  end
end
