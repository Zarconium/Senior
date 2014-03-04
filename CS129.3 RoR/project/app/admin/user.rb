ActiveAdmin.register User do
  permit_params :email, :handle, :password, :password_confirmation

  menu parent: "Happygram"

  index do
    column :email
    column :handle
    column :current_sign_in_at
    column :last_sign_in_at
    column :sign_in_count
    default_actions
  end

  filter :email

  form do |f|
    f.inputs "User Details" do
      f.input :email
      f.input :handle
      f.input :password
      f.input :password_confirmation
    end
    f.actions
  end

end