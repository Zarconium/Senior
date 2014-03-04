class AddAttachmentProfilePictureToClients < ActiveRecord::Migration
  def self.up
    change_table :clients do |t|
      t.attachment :profile_picture
    end
  end

  def self.down
    drop_attached_file :clients, :profile_picture
  end
end
