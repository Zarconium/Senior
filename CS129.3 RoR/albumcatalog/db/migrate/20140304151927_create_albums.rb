class CreateAlbums < ActiveRecord::Migration
  def change
    create_table :albums do |t|
      t.string :album_title
      t.string :album_artist
      t.date :release_date

      t.timestamps
    end
  end
end
