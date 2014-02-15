class CreateClients < ActiveRecord::Migration
  def change
    create_table :clients do |t|
      t.string :name
      t.string :company
      t.string :email
      t.string :contact_number
      t.text :description

      t.timestamps
    end
  end
end
