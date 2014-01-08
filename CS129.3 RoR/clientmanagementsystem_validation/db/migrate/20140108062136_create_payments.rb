class CreatePayments < ActiveRecord::Migration
  def change
    create_table :payments do |t|
      t.decimal :amount
      t.date :date_paid
      t.integer :client_id

      t.timestamps
    end
  end
end
