class Client < ActiveRecord::Base

  has_many :payments
  has_attached_file :profile_picture, styles: { thumb: "50x50", medium: "250x250" }
  # sudo apt-get install imagemagick
  validates_attachment_content_type :profile_picture, content_type: ["image/jpeg", "image/jpg", "image/png"]

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

  def switch_blacklisted_status
    if self.blacklisted == true
      self.blacklisted = false
    else
      self.blacklisted = true
    end
    self.save
  end
end
