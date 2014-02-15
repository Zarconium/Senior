ActiveAdmin.register Payment do
  menu parent: "Business"

  filter :client
  filter :amount
  filter :date_paid

  # Custom filters: MetaSearch
  filter :client_first_name_or_client_last_name, as: :string

  index do
    column :client
    column :amount
    column :date_paid
    default_actions
  end
end
