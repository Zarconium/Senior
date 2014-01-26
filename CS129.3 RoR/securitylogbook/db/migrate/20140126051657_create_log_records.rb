class CreateLogRecords < ActiveRecord::Migration
  def change
    create_table :log_records do |t|
      t.integer :user_id
      t.string :visitor_name
      t.string :purpose_of_visit
      t.datetime :time_of_visit
      t.integer :office_id

      t.timestamps
    end
  end
end
