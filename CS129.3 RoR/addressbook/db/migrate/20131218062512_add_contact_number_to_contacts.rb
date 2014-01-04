class AddContactNumberToContacts < ActiveRecord::Migration
  def change
  	add_column :contacts, :contact_number, :string
  end
end
