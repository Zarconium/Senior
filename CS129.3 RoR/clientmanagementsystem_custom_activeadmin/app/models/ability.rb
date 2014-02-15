class Ability
  include CanCan::Ability

  def initialize(user)
    user ||= User.new
    if user.role == "admin"
      can :manage, :all
    else
      can :create, Client
      can :update, Client, user_id: user.id
      can :show, Client, user_id: user.id
      can :destroy, Client, user_id: user.id
    end
  end
end
