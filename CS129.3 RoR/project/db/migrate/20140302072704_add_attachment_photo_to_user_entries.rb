class AddAttachmentPhotoToUserEntries < ActiveRecord::Migration
  def self.up
    change_table :user_entries do |t|
      t.attachment :photo
    end
  end

  def self.down
    drop_attached_file :user_entries, :photo
  end
end
