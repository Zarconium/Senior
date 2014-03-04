ActiveAdmin.register UserEntry do
  permit_params :title, :description, :photo, :user

  menu parent: "Happygram"

  index do
    column :title
    column :description
    column :user
    default_actions
  end

  filter :title
  filter :description
  filter :photo
  filter :user

  form do |f|
    f.inputs "User Entry Details" do
      f.input :title
      f.input :description
      f.input :photo
      f.input :user
    end
    f.actions
  end

end