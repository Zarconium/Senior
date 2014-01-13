class CreateSubjects < ActiveRecord::Migration
  def change
    create_table :subjects do |t|
      t.string :name
      t.string :code
      t.integer :num_units

      t.timestamps
    end
  end
end
