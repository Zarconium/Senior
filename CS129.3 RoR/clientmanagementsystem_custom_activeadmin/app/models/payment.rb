class Payment < ActiveRecord::Base
  # Automagically relate client to client_id
  belongs_to :client

  validates :amount, presence: true, numericality: true
  validates :date_paid, presence: true
  validates :client, presence: true
end
