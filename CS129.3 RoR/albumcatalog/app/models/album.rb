class Album < ActiveRecord::Base
	has_many :songs

	validates :album_title, presence: true
	validates :album_artist, presence: true
	validates :release_date, presence: true

	def to_s
		album_title
	end
end
