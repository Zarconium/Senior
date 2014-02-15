ActiveAdmin.register Contact do
  permit_params :first_name, :last_name, :email, :address, :contact_number

  menu parent: "Business"

  index do
    column :first_name
    column :last_name
    column :email
    column :address
    column :contact_number
    default_actions
  end

  form do |f|
    f.inputs "Contact Details" do
      f.input :first_name
      f.input :last_name
      f.input :email
      f.input :address
      f.input :contact_number
      f.actions
    end
  end
end
