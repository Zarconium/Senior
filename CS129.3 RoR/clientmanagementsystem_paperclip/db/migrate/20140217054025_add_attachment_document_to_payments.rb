class AddAttachmentDocumentToPayments < ActiveRecord::Migration
  def self.up
    change_table :payments do |t|
      t.attachment :document
    end
  end

  def self.down
    drop_attached_file :payments, :document
  end
end
