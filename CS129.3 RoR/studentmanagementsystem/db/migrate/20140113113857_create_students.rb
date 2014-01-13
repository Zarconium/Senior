class CreateStudents < ActiveRecord::Migration
  def change
    create_table :students do |t|
      t.string :first_name
      t.string :last_name
      t.string :middle_name
      t.date :date_of_birth
      t.text :address
      t.string :student_number
      t.string :contact_number
      t.string :email

      t.timestamps
    end
  end
end
