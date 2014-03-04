class CreateSongs < ActiveRecord::Migration
  def change
    create_table :songs do |t|
      t.integer :album_id
      t.string :song_title
      t.integer :duration
      t.string :composer

      t.timestamps
    end
  end
end
