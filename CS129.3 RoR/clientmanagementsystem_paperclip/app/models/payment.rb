class Payment < ActiveRecord::Base
  # Automagically relate client to client_id
  belongs_to :client

  has_attached_file :document
  validates_attachment_content_type :document, content_type: ["application/msword", "application/pdf", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"]

  validates :amount, presence: true, numericality: true
  validates :date_paid, presence: true
  validates :client, presence: true
end
