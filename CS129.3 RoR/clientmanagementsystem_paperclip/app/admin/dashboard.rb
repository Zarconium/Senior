ActiveAdmin.register_page "Dashboard" do

  menu :priority => 1, :label => proc{ I18n.t("active_admin.dashboard") }

  content :title => "Dashboard" do
    columns do
      column do
        panel "Reporting Tools" do
          div do
            link_to "Download Client Payments", admin_dashboard_download_client_payments_path, method: :post
          end
        end
      end
    end
  end

  page_action :download_client_payments, method: :post do
    require 'csv'
    # Create data of client payments
    csv_string = CSV.generate do |csv|
      Client.all.each do |client|
        csv << [client.first_name, client.last_name, client.email]
        latest_payment = Payment.where(client_id: client.id).order("date_paid DESC").first
        csv << ["Latest Payment:", latest_payment.date_paid, latest_payment.amount] 
        csv << ["Date Paid", "Amount"]
        client.payments.each do |payment|
          csv << [payment.date_paid, payment.amount]
        end
      end
    end

    # Send the data as a csv file
    send_data csv_string, type: "text/csv; header=present", disposition: "attachment;filename=data.csv"
  end


end
