class Song < ActiveRecord::Base
	belongs_to :album

	validates :album, presence: true
	validates :song_title, presence: true
	validates :duration, presence: true
	validates :composer, presence: true

	def to_s
		song_title
	end
end
