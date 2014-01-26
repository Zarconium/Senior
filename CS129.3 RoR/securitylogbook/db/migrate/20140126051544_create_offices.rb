class CreateOffices < ActiveRecord::Migration
  def change
    create_table :offices do |t|
      t.string :name
      t.string :room_number
      t.text :description

      t.timestamps
    end
  end
end
