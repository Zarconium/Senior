ActiveAdmin.register Client do
  permit_params :first_name

  menu parent: "Business"

  # Default actions: show, edit, destroy
  actions :all, except: [:destroy]

  member_action :change_status, method: :post do
    client = Client.find(params[:id])
    client.switch_blacklisted_status
    redirect_to admin_clients_path
  end

  member_action :payments do
    @client = Client.find(params[:id])
  end

  index do
    column :name
    column :total_amount_paid
    column :blacklisted
    column :actions do |client|
      link_to "Switch", change_status_admin_client_path(client.id), method: :post
    end
  end
end
