class CreateClientsTable < ActiveRecord::Migration
  def change
    create_table :clients do |t|
      t.string :first_name
      t.string :last_name
      t.string :company_name
      t.string :email
      t.string :contact_number
      t.string :priority
      t.text :description

      t.timestamps
    end
  end
end
