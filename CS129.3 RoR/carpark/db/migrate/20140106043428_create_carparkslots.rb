class CreateCarparkslots < ActiveRecord::Migration
  def change
    create_table :carparkslots do |t|
      t.string :plate_number
      t.string :car_type
      t.date :parking_date
      t.decimal :number_of_hours
      t.boolean :reserved

      t.timestamps
    end
  end
end
