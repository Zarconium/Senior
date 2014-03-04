class AddBlacklistedToClients < ActiveRecord::Migration
  def change
    add_column :clients, :blacklisted, :boolean
  end
end
