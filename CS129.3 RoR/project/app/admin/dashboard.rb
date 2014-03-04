ActiveAdmin.register_page "Dashboard" do

	menu priority: 1, label: proc{ I18n.t("active_admin.dashboard") }

	content title: proc{ I18n.t("active_admin.dashboard") } do
		# div class: "blank_slate_container", id: "dashboard_default_message" do
		# 	span class: "blank_slate" do
		# 		span I18n.t("active_admin.dashboard_welcome.welcome")
		# 		small I18n.t("active_admin.dashboard_welcome.call_to_action")
		# 	end
		# end

    # Here is an example of a simple dashboard with columns and panels.
    #
		columns do
			column do
				panel "Statistics" do
					ul do
						li "Total Users: #{User.all.count}"
						li "Total Posts: #{UserEntry.all.count}"
						li "Total Comments: #{Comment.all.count}"
					end
				end
			end

			column do
				panel "Info" do
					div do
						para "Welcome to ActiveAdmin for Happygram!"
					end
					div do
						link_to("Visit Happygram here", root_path)
					end
				end
			end
		end
	end # content
end
