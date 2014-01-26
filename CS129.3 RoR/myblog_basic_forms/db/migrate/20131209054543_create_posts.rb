class CreatePosts < ActiveRecord::Migration
  def change
    create_table :posts do |t|
      t.string :title
      t.string :content
      t.string :tags
      # updated_at and created_at
      t.timestamps
    end
  end
end
