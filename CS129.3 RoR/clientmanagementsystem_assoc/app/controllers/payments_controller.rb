class PaymentsController < ApplicationController
  
  def index
    @payments = Payment.all
  end

  def show
    @payment = Payment.find(params[:id])
  end

  def new
    @payment = Payment.new
  end

  def create
    @payment = Payment.new(payment_params)

    if @payment.save
      redirect_to client_path(@payment.client.id)
    else
      render :new
    end
  end

  def edit
    @payment = Payment.find(params[:id])
  end

  def update
    @payment = Payment.find(params[:id])

    if @payment.update_attributes(payment_params)
      redirect_to client_path(@payment.client.id)
    else
      render :edit
    end
  end

  def destroy
    @payment = Payment.find(params[:id])
    @payment.destroy
    redirect_to payments_path
  end

  private

  def payment_params
    params.require(:payment).permit!
  end
end
