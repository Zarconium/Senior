class CreateReportCards < ActiveRecord::Migration
  def change
    create_table :report_cards do |t|
      t.string :subject_name
      t.string :subject_code
      t.integer :number_of_units
      t.decimal :numerical_grade
      t.string :professor_name

      t.timestamps
    end
  end
end
