class ClientsController < ApplicationController
  
  def index
    @clients = Client.all
  end

  def show
    @client = Client.find(params[:id])
    @latest_payment_transacted = compute_latest_payment_for_client(@client)
  end

  def new
    @client = Client.new
  end

  def create
    @client = Client.new(client_params)

    if @client.save
      redirect_to clients_path
    else
      render :new
    end
  end

  def edit
    @client = Client.find(params[:id])
  end

  def update
    @client = Client.find(params[:id])

    if @client.update_attributes(client_params)
      redirect_to clients_path
    else
      render :edit
    end
  end

  def destroy
    @client = Client.find(params[:id])
    @client.destroy
    redirect_to clients_path
  end

  def add_payment
    @client = Client.find(params[:id])
    @payment = Payment.new
    @payment.client = @client
    render "payments/new"
  end

  private

  def client_params
    params.require(:client).permit!
  end

  def compute_latest_payment_for_client(client)
    client.payments.last
  end
end